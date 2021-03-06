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
        Color mouseMoveBackColor = Color.FromArgb(30, Color.Black);
        private static readonly ILog logger = LogManager.GetLogger(typeof(mainForm));
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
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //Our Codes
            this.btns = new System.Windows.Forms.Button[9];
            for (int i = 0; i < 9; i++)
            {
                btns[i] = new System.Windows.Forms.Button();
                this.gamePanel.Controls.Add(btns[i]);
                this.btns[i].Location = new System.Drawing.Point((i % 3) * 110, (i / 3) *100);
                this.btns[i].Name = "btn" + i;
                this.btns[i].Size = new System.Drawing.Size(90, 90);
                this.btns[i].TabIndex = i+3;
                //this.btns[i].UseVisualStyleBackColor = true;
                this.btns[i].Click += new System.EventHandler(this.btn_Click);
                this.btns[i].FlatAppearance.BorderSize = 0;
                this.btns[i].FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
                this.btns[i].FlatAppearance.MouseOverBackColor = mouseMoveBackColor;
                this.btns[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;

                this.btns[i].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            
            }

            this.game = new MultiplayerOfflineGame("Name1", "Name1");
            this.game.Update += new System.EventHandler(this.updateInterface);
            game.reset(true);

            logger.Info("Game components initiated");
            //TcpClient tcp = new TcpClient();
        } 

        private void updateInterface(object sender, EventArgs e) //To Ravindu: Improve this function
        {
            int[,] table = game.getTable();
            for(int i=0;i<9;i++)
            {
                if (table[i / 3, i % 3] == 1)
                {
                    btns[i].BackgroundImage = global::Tik_Tac_Toe.Properties.Resources.red;
                    btns[i].FlatAppearance.MouseOverBackColor = Color.Transparent;
                }
                else if(table[i / 3, i % 3] == -1)
                {
                    btns[i].BackgroundImage = global::Tik_Tac_Toe.Properties.Resources.blue;
                    btns[i].FlatAppearance.MouseOverBackColor = Color.Transparent;
                }
                else
                {
                    btns[i].BackgroundImage = btnReset.BackgroundImage;
                    btns[i].FlatAppearance.MouseOverBackColor = mouseMoveBackColor;
                    btns[i].BackColor = Color.Transparent;
                }
            }
            playAgain.Visible = false;
            //Increase marks
            lblPlayer1.Text = game.getPlayer(-1).name + " has " + game.getPlayer(-1).points + " points " ;
            lblPlayer2.Text = game.getPlayer(1).name + " has " + game.getPlayer(1).points + " points ";

            // =0 game is going on | =1,-1 wins and =2 draw
            if (game.getWinner() == 0)
            {

                result.Text = "Game is going on....";
                if (game.getState() == Game.WaitingForConnection) result.Text = "Connecting...";
            }

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
                int[] winCells = game.getWinCells();
                for (int i = 0; i < 3; i++)
                    btns[winCells[i]].BackColor = Color.FromArgb(40,Color.Black);

          }

            if (game.getWinner() == -1)
            {
                result.Text = game.getPlayer(-1).name + " won!!!";
                result.ForeColor = System.Drawing.Color.Blue;
            }
            if (game.getWinner() == 1)
            {
                result.Text = game.getPlayer(1).name + " won!!!";
                result.ForeColor = System.Drawing.Color.Red;
            }
            if (game.getWinner() == 2)
            {
               
                result.Text = "Game is 'Drawn";
            }
          playAgain.Visible = true;
            
          }

        private void btn_Click(object sender, EventArgs e)
        {
            int index = int.Parse( (sender as Button).Name.Substring(3) ); //Find the button clicked
            game.updateMove(index / 3, index % 3);
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            //not showing other buttons
            btnMultiplayerOnline.Visible = false;
            btnMultiplayerOffline.Visible = false;

            singlePlayerPanel.Visible = true;
            gamePanel.Visible = false;

        } 

 



        private void btnReset_Click(object sender, EventArgs e)
        {
 
            game.reset(true);
            logger.Info("game reset");
        }

        private void btnMultiplayerOffline_Click(object sender, EventArgs e)// add a window to enter name, select difficulty
        {
           
            //not showin other buttons 
            btnSinglePlayer.Visible = false;
            btnMultiplayerOnline.Visible = false;

            multiPlayerOfflinePanel.Visible = true;
            gamePanel.Visible = false;

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

            game = new MultiplayerOnlineGame(startForm3.path, startForm3.playerName,startForm3.isRed);
            this.game.Update += new System.EventHandler(this.updateInterface);
            game.reset(true);
            startForm3.Dispose();


            gamePanel.Visible = true;
        }

        //Global variables;
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        private void mainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }

        }

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {

             _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void mainForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; 
        }

        private void lblPlayer2_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int difficulty = 0;
            if (Easy.Checked) { difficulty = 0; }
            if (Medium.Checked) { difficulty = 1;}
            if (Hard.Checked) { difficulty = 2; } 
     
            Random rand = new Random();
            game = new SinglePlayerGame(SinglePlayerName.Text, rand.Next(0, 2) == 0 ? 1 : -1,difficulty);
            game.Update += new System.EventHandler(this.updateInterface);
            game.reset(true);


            singlePlayerPanel.Visible = false; ;
            gamePanel.Visible = true;

            btnMultiplayerOnline.Visible = true;
            btnMultiplayerOffline.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            singlePlayerPanel.Visible=false;

            btnMultiplayerOnline.Visible = true;
            btnMultiplayerOffline.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            game.reset(false);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void singlePlayerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            multiPlayerOfflinePanel.Visible = false;

            btnSinglePlayer.Visible = true;
            btnMultiplayerOnline.Visible = true;
        }

        private void multiPlayerOK_Click(object sender, EventArgs e)
        {
            this.game = new MultiplayerOfflineGame(player1Name.Text,player2Name.Text);
            this.game.Update += new System.EventHandler(this.updateInterface);
            game.reset(true);

            gamePanel.Visible = true;
            multiPlayerOfflinePanel.Visible = false;

            btnSinglePlayer.Visible = true;
            btnMultiplayerOnline.Visible =true;
        }


    }
}
