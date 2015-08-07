using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

//For network
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

using System.Windows.Forms;

namespace Tik_Tac_Toe
{
    class MultiplayerOnlineGame:Game
    {


        

        //logger
        private static readonly ILog logger = LogManager.GetLogger(typeof(MultiplayerOnlineGame));

        //is this is the chance of network player
        public bool closed = false;
        private bool isNetworkMove = false;
        int networkPlayerI = 1;
        String writePath ;
        String readPath ;
        String txtBackup = "";
        bool configuredConnection = false;
        
        private Thread listenerThread;

        public MultiplayerOnlineGame(String path, String playerName, bool isRed):base()
        {
            state = Game.WaitingForConnection;
            if (isRed)
            {
                isNetworkMove = true;
                networkPlayerI = -1;
                writePath = path + "\\" + "red.dat";
                readPath = path + "\\" + "blue.dat";
                setPlayers(new Player("<waiting>"), new Player(playerName));
            }
            else
            {
                isNetworkMove = false;
                networkPlayerI = 1;
                readPath = path + "\\" + "red.dat";
                writePath = path + "\\" + "blue.dat";
                setPlayers(new Player(playerName), new Player("<waiting>"));
            }

            write();
            listenerThread = new Thread(new ThreadStart(threadListen));
            listenerThread.Start();
        }

        public void threadListen()
        {
            while (!closed)
            {
                read();
                Thread.Sleep(1000);
                logger.Info("Reading");
            }
        }

        public override bool updateMove(int row, int col)
        {
            if (!configuredConnection) return false;
            if (table[row, col] != 0 || isNetworkMove)
            {
                logger.Warn("Requested a imposible move");
                return false;
            }
            logger.Info("Trying to write file");
            isNetworkMove = true;
            updateMove(row, col, networkPlayerI*(-1)); //Mark the moves
            write();
            callUpdate();       //Update Interface

            return false;
        }

        private void write()
        {
            try
            {
                String txt = "";
                for (int i = 0; i < 9; i++ )
                {
                    txt += table[i / 3, i % 3] == -1 ? 2 : table[i / 3, i % 3];
                }
                txt += "\n";
                txt += players[0].name + "\n" + players[0].points + "\n";
                txt += players[1].name + "\n" + players[1].points + "\n";
                txt += isNetworkMove ? '1' : '0'; //It is your move next;
                File.WriteAllText(writePath, txt);
            }
            catch
            {
                return;
            }
        }

        private void read()
        {
            //Try to read and update
            String txt;
            try
            {
                txt = File.ReadAllText(readPath);
                if (txt == txtBackup) return;

                String[] arr = txt.Split(Environment.NewLine.ToCharArray());
                txtBackup = txt;

                if (networkPlayerI == -1)
                {
                    getPlayer(-1).name = arr[1];
                    getPlayer(-1).points = int.Parse(arr[2]);
                }
                else
                {
                    getPlayer(1).name = arr[3];
                    getPlayer(1).points = int.Parse(arr[4]);
                }

                if (arr[1] != "<waiting>" && arr[3] != "<waiting>")
                {
                    configuredConnection = true;
                    state = Game.GoingOn;
                }

                if (!configuredConnection) return;
               // if (!isNetworkMove ) return;
                //Update table
                for (int i = 0; i < 9; i++)
                {
                    logger.Info(txt[i] - '0');
                    table[i / 3, i % 3] = txt[i] == '2' ? -1 : txt[i] - '0';
                    int x = txt[i] - '0';
                }
                if (arr[5] == "1")
                    isNetworkMove = false;
                else
                    isNetworkMove = true;
                callUpdate();
            }
            catch
            {
                return;
            }
        }

        public override void reset(bool full)
        {
            base.reset(full);
            isNetworkMove = false;
            write();
        }

    }
}
