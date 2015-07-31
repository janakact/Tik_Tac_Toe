﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tik_Tac_Toe
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            InitializeGameComponent();

        }



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
                this.btns[i].TabIndex = 0;
                this.btns[i].Text = i + "";
                this.btns[i].UseVisualStyleBackColor = true;
                this.btns[i].Click += new System.EventHandler(this.btn_Click);
                
            }

            this.game = new Game();
            this.game.Update += new System.EventHandler(this.updateInterface);
            game.reset(true);
          
        }

        private void updateInterface(object sender, EventArgs e) //To Ravindu: Improve this function
        {
            int[,] table = game.getTable();
            for(int i=0;i<9;i++)
            {
                btns[i].Text = table[i / 3, i % 3].ToString();
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
                DialogResult gameResult = MessageBox.Show("WINNER is : " + game.getPlayer(game.getWinner()).name + "\n \n Start New Game? \n",
                                                         "Game Result",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Information
                                                          );
                if (gameResult == DialogResult.Yes)
                {
                    game.reset(false);
                }
            }

            else
            { 
                DialogResult gameResult1 = MessageBox.Show("Game is Drawn \n \n Start New Game?",
                                                         "Game Result",
                                                         MessageBoxButtons.YesNo,//convert this into continue & start new session
                                                         MessageBoxIcon.Information
                                                          );
                if (gameResult1 == DialogResult.Yes)
                {
                    game.reset(false);
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
            StartForm startForm = new StartForm();
            startForm.OKPressed += new System.EventHandler(this.singlePlayerOK_Click);
            startForm.ShowDialog();
           

        }

        //OK Press listener
        private void singlePlayerOK_Click(object sender, EventArgs e)
        {
            game = new SinglePlayerGame("Me", 1, SinglePlayerGame.EasyLevel);
            game.Update += new System.EventHandler(this.updateInterface);
            game.reset(true);
           
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
            this.game = new Game();
            this.game.Update += new System.EventHandler(this.updateInterface);
            game.reset(true);
           

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

    }
}
