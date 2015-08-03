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
        String writePath = "E:\\a.txt";
        String readPath = "E:\\b.txt";
        String txtBackup = "";
        
        private Thread listenerThread;

        public MultiplayerOnlineGame(String pathWrite, String pathRead):base()
        {
            //writePath = pathWrite;
           // readPath = pathRead;
            listenerThread = new Thread(new ThreadStart(threadListen));
            listenerThread.Start();
            setPlayers(new Player("haha"), new Player("lol"));
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
            if (table[row, col] != 0 || isNetworkMove)
            {
               // logger.Warn("Requested a imposible move");
               // return false;
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
            String txt = "";
            for (int i = 0; i < 9; i++ )
            {
                txt += table[i / 3, i % 3] == -1 ? 2 : table[i / 3, i % 3];
            }
            txt += "\n";
            txt += players[0].name + "\n" + players[0].points + "\n";
            txt += players[1].name + "\n" + players[1].points + "\n";

            File.WriteAllText(writePath, txt);
        }

        private void read()
        {
            String txt = File.ReadAllText(readPath);
            if (txt == txtBackup) return;
            txtBackup = txt;
            //Update table
            for(int i=0; i<9; i++)
            {
                logger.Info(txt[i] - '0');
                table[i / 3, i % 3] = txt[i] == '2' ? -1 : txt[i]-'0';
                int x = txt[i] - '0';
            }

            callUpdate();
        }

        public override void reset(bool full)
        {
            base.reset(full);
            write();
        }

    }
}
