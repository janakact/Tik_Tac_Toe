﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;


//For test 

using System.Net;
using System.Net.Sockets;

namespace Tik_Tac_Toe
{
    public partial class mainForm : Form
    {

        private static readonly ILog logger = LogManager.GetLogger(typeof(Game));
        public mainForm()
        {
            InitializeComponent();
            InitializeGameComponent();

            logger.Fatal("Game Created");
        }

        //im creating start forms here
        StartForm startForm;
        StartForm2 startForm2;
        StartForm3 startForm3;
        private void InitializeGameComponent()
        {
            //Our Codes
            this.btns = new System.Windows.Forms.Button[9];
            for (int i = 0; i < 9; i++)
            {
                btns[i] = new System.Windows.Forms.Button();
                this.gamePanel.Controls.Add(btns[i]);
                this.btns[i].Location = new System.Drawing.Point((i % 3) * 60, (i / 3) * 60);
                this.btns[i].Name = "btn" + i;
                this.btns[i].Size = new System.Drawing.Size(50, 50);
                this.btns[i].TabIndex = i+3;
                //this.btns[i].UseVisualStyleBackColor = true;
                this.btns[i].Click += new System.EventHandler(this.btn_Click);
                this.btns[i].BackColor = Color.Green;
            }

            this.game = new MultiplayerOfflineGame("Name1", "Name1");
            this.game.Update += new System.EventHandler(this.updateInterface);
            game.reset(true);

            //TcpClient tcp = new TcpClient();
        }

        private void updateInterface(object sender, EventArgs e) //To Ravindu: Improve this function
        {
            int[,] table = game.getTable();
            for(int i=0;i<9;i++)
            {
                if (table[i / 3, i % 3] == 1)
                {
                    btns[i].BackColor = Color.Red;
                }
                else if(table[i / 3, i % 3] == -1)
                {
                    btns[i].BackColor = Color.Blue;
                }
                else
                {
                    btns[i].BackColor = Color.Green;
                }
            }

            //Increase marks
            lblPlayer1.Text = game.getPlayer(-1).name + " has " + game.getPlayer(-1).points + " points " ;
            lblPlayer2.Text = game.getPlayer(1).name + " has " + game.getPlayer(1).points + " points ";

            // =0 game is going on | =1,-1 wins and =2 draw
            if (game.getWinner() != 0)
            {
                gameFinished();
            }
        }

        private void gameFinished() //To Ravindu
        {
            //lblState.Text = "winner is " + game.getWinner();

            //To Do - 
            //      Disable grid,
            //      show reset(Play again) button 
            if (game.getWinner()==1 || game.getWinner()==-1)
            {
                DialogResult gameResult = MessageBox.Show("WINNER is : " + game.getPlayer(game.getWinner()).name + "\n \n Do u want to continue this game session? \n",
                                                         "Game Result",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Information
                                                          );
                if (gameResult == DialogResult.Yes)
                {
                    game.reset(false);
                }
                if (gameResult == DialogResult.No)
                {
                    game.reset(false);
            }
            }

            else
            { 
                DialogResult gameResult1 = MessageBox.Show("Game is Drawn \n \n Do you want to continue this game session?",
                                                         "Game Result",
                                                         MessageBoxButtons.YesNo,//convert this into continue & start new session
                                                         MessageBoxIcon.Information
                                                          );
                if (gameResult1 == DialogResult.Yes)
                {
                    game.reset(false);
                }
                if (gameResult1 == DialogResult.No)
                {
                    game.reset(true);
            }
          }
          }

        private void btn_Click(object sender, EventArgs e)
        {
            int index = int.Parse( (sender as Button).Name.Substring(3) ); //Find the button clicked
            game.updateMove(index / 3, index % 3);
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            
            //Grid
            startForm = new StartForm();
            // added a event handler to ok button pressed scenario
            startForm.OKPressed += new System.EventHandler(this.singlePlayerOK_Click);
            startForm.ShowDialog();
           

        }

        //OK Press listener
        private void singlePlayerOK_Click(object sender, EventArgs e)   
        {
            // i want to choose randomly which player palys first
            Random rand = new Random();
            game = new SinglePlayerGame(this.startForm.singlePlayerName, rand.Next(0,2)==0?1:-1 ,startForm.difficulty);
            game.Update += new System.EventHandler(this.updateInterface);
            game.reset(true);
            startForm.Dispose();


            gamePanel.Visible = true;
           
        }




        private void btnReset_Click(object sender, EventArgs e)
        {
           
            // have to show this after game started
            if (game.getWinner() == 0)
            {
                DialogResult result= MessageBox.Show("Current game data will be lost. Are you sure you want to continue!!",
                    "Reset Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) 
                {
                    game.reset(false);
                }
                
            }
            else game.reset(false);
           
        }

        private void btnMultiplayerOffline_Click(object sender, EventArgs e)// add a window to enter name, select difficulty
        {

            startForm2 = new StartForm2();
            startForm2.OKPressed += new System.EventHandler(this.multiPlayerOK_Click);
            startForm2.ShowDialog();
            

        }
        private void multiPlayerOK_Click(object sender, EventArgs e)
        {

            this.game = new MultiplayerOfflineGame(startForm2.player1Name, startForm2.player2Name);
            this.game.Update += new System.EventHandler(this.updateInterface);
            game.reset(true);
            startForm2.Dispose();


            gamePanel.Visible = true;
      
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void mainForm_Load2(object sender, EventArgs e)
        {

        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnMultiplayerOnline_Click(object sender, EventArgs e)
        {
            startForm3 = new StartForm3();
            startForm3.OKPressed += new System.EventHandler(this.multiPlayerOnlineOK_Click);
            startForm3.ShowDialog();
        }

        private void multiPlayerOnlineOK_Click(object sender, EventArgs e)
        {
            if(startForm3.isClient)
            {
                this.game = new MultiplayerOnlineGame(true,startForm3.ip, startForm3.playerName);

            }
            if(startForm3.isServer)
            {

                this.game = new MultiplayerOnlineGame(false, startForm3.ip, startForm3.playerName);
            }
            else
            {
                logger.Error("Invalid multiplayer game request." + startForm3.isServer + " and " + startForm3.isClient);
            }

            this.game.Update += new System.EventHandler(this.updateInterface);
            game.reset(true);
            startForm3.Dispose();


            gamePanel.Visible = true;
        }

    }
}
