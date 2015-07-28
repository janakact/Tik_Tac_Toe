﻿namespace Tik_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homePanel = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnMultiplayerOnline = new System.Windows.Forms.Button();
            this.btnMultiplayerOffline = new System.Windows.Forms.Button();
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.homePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.btnStop);
            this.homePanel.Controls.Add(this.btnMultiplayerOnline);
            this.homePanel.Controls.Add(this.btnMultiplayerOffline);
            this.homePanel.Controls.Add(this.btnSinglePlayer);
            this.homePanel.Location = new System.Drawing.Point(12, 12);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(133, 217);
            this.homePanel.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(4, 185);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(124, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnMultiplayerOnline
            // 
            this.btnMultiplayerOnline.Location = new System.Drawing.Point(4, 61);
            this.btnMultiplayerOnline.Name = "btnMultiplayerOnline";
            this.btnMultiplayerOnline.Size = new System.Drawing.Size(125, 23);
            this.btnMultiplayerOnline.TabIndex = 2;
            this.btnMultiplayerOnline.Text = "Multiplayer (online)";
            this.btnMultiplayerOnline.UseVisualStyleBackColor = true;
            // 
            // btnMultiplayerOffline
            // 
            this.btnMultiplayerOffline.Location = new System.Drawing.Point(3, 32);
            this.btnMultiplayerOffline.Name = "btnMultiplayerOffline";
            this.btnMultiplayerOffline.Size = new System.Drawing.Size(125, 23);
            this.btnMultiplayerOffline.TabIndex = 1;
            this.btnMultiplayerOffline.Text = "Multiplayer (offline)";
            this.btnMultiplayerOffline.UseVisualStyleBackColor = true;
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.Location = new System.Drawing.Point(3, 3);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(125, 23);
            this.btnSinglePlayer.TabIndex = 0;
            this.btnSinglePlayer.Text = "Single Player";
            this.btnSinglePlayer.UseVisualStyleBackColor = true;
            this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.Location = new System.Drawing.Point(151, 12);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(218, 217);
            this.gamePanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player1 Wins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 241);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.homePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.homePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();




        }

        #endregion

        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Button btnMultiplayerOnline;
        private System.Windows.Forms.Button btnMultiplayerOffline;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button[] btns;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3; //Buttons 
        private Grid grid;
    }
}
