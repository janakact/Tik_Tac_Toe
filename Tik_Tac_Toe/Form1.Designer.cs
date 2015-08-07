namespace Tik_Tac_Toe
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.homePanel = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnMultiplayerOnline = new System.Windows.Forms.Button();
            this.btnMultiplayerOffline = new System.Windows.Forms.Button();
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.result = new System.Windows.Forms.Label();
            this.playAgain = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.p = new System.IO.FileSystemWatcher();
            this.singlePlayerPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SinglePlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hard = new System.Windows.Forms.RadioButton();
            this.Medium = new System.Windows.Forms.RadioButton();
            this.Easy = new System.Windows.Forms.RadioButton();
            this.multiPlayerOfflinePanel = new System.Windows.Forms.Panel();
            this.multiPlayerCancel = new System.Windows.Forms.Button();
            this.multiPlayerOK = new System.Windows.Forms.Button();
            this.player2Name = new System.Windows.Forms.TextBox();
            this.player1Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.homePanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p)).BeginInit();
            this.singlePlayerPanel.SuspendLayout();
            this.multiPlayerOfflinePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.Transparent;
            this.homePanel.Controls.Add(this.btnStop);
            this.homePanel.Controls.Add(this.btnMultiplayerOnline);
            this.homePanel.Controls.Add(this.btnMultiplayerOffline);
            this.homePanel.Controls.Add(this.btnSinglePlayer);
            this.homePanel.ForeColor = System.Drawing.Color.Black;
            this.homePanel.Location = new System.Drawing.Point(2, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(198, 311);
            this.homePanel.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Informal Roman", 14.25F);
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(3, 250);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(190, 30);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Close";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnMultiplayerOnline
            // 
            this.btnMultiplayerOnline.BackColor = System.Drawing.Color.Transparent;
            this.btnMultiplayerOnline.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMultiplayerOnline.FlatAppearance.BorderSize = 0;
            this.btnMultiplayerOnline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnMultiplayerOnline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnMultiplayerOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplayerOnline.Font = new System.Drawing.Font("Informal Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplayerOnline.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMultiplayerOnline.Location = new System.Drawing.Point(5, 154);
            this.btnMultiplayerOnline.Name = "btnMultiplayerOnline";
            this.btnMultiplayerOnline.Size = new System.Drawing.Size(190, 31);
            this.btnMultiplayerOnline.TabIndex = 2;
            this.btnMultiplayerOnline.Text = "Multiplayer (online)";
            this.btnMultiplayerOnline.UseVisualStyleBackColor = false;
            this.btnMultiplayerOnline.Click += new System.EventHandler(this.btnMultiplayerOnline_Click);
            // 
            // btnMultiplayerOffline
            // 
            this.btnMultiplayerOffline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnMultiplayerOffline.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMultiplayerOffline.FlatAppearance.BorderSize = 0;
            this.btnMultiplayerOffline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnMultiplayerOffline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnMultiplayerOffline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplayerOffline.Font = new System.Drawing.Font("Informal Roman", 14.25F);
            this.btnMultiplayerOffline.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMultiplayerOffline.Location = new System.Drawing.Point(3, 83);
            this.btnMultiplayerOffline.Name = "btnMultiplayerOffline";
            this.btnMultiplayerOffline.Size = new System.Drawing.Size(190, 35);
            this.btnMultiplayerOffline.TabIndex = 1;
            this.btnMultiplayerOffline.Text = "Multiplayer (offline)";
            this.btnMultiplayerOffline.UseVisualStyleBackColor = false;
            this.btnMultiplayerOffline.Click += new System.EventHandler(this.btnMultiplayerOffline_Click);
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnSinglePlayer.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSinglePlayer.FlatAppearance.BorderSize = 0;
            this.btnSinglePlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnSinglePlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnSinglePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinglePlayer.Font = new System.Drawing.Font("Informal Roman", 14.25F);
            this.btnSinglePlayer.Location = new System.Drawing.Point(0, 11);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(190, 35);
            this.btnSinglePlayer.TabIndex = 0;
            this.btnSinglePlayer.Text = "Single Player";
            this.btnSinglePlayer.UseVisualStyleBackColor = false;
            this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Transparent;
            this.gamePanel.Controls.Add(this.result);
            this.gamePanel.Controls.Add(this.playAgain);
            this.gamePanel.Controls.Add(this.btnReset);
            this.gamePanel.Controls.Add(this.lblPlayer1);
            this.gamePanel.Controls.Add(this.lblPlayer2);
            this.gamePanel.Controls.Add(this.lblResult);
            this.gamePanel.Location = new System.Drawing.Point(228, 25);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(496, 306);
            this.gamePanel.TabIndex = 1;
            this.gamePanel.Visible = false;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Jokerman", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.result.Location = new System.Drawing.Point(353, 117);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(50, 17);
            this.result.TabIndex = 8;
            this.result.Text = "label2";
            // 
            // playAgain
            // 
            this.playAgain.BackColor = System.Drawing.Color.Transparent;
            this.playAgain.FlatAppearance.BorderSize = 0;
            this.playAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playAgain.Font = new System.Drawing.Font("Informal Roman", 14.25F);
            this.playAgain.Location = new System.Drawing.Point(387, 186);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(109, 33);
            this.playAgain.TabIndex = 7;
            this.playAgain.Text = "Play Again!";
            this.playAgain.UseVisualStyleBackColor = false;
            this.playAgain.Visible = false;
            this.playAgain.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Informal Roman", 14.25F);
            this.btnReset.Location = new System.Drawing.Point(383, 225);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 30);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Informal Roman", 14.25F);
            this.lblPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPlayer1.Location = new System.Drawing.Point(323, 38);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(97, 21);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Player1 Wins";
            this.lblPlayer1.Click += new System.EventHandler(this.lblPlayer1_Click);
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Informal Roman", 14.25F);
            this.lblPlayer2.ForeColor = System.Drawing.Color.Brown;
            this.lblPlayer2.Location = new System.Drawing.Point(323, 59);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(62, 21);
            this.lblPlayer2.TabIndex = 3;
            this.lblPlayer2.Text = "Player2";
            this.lblPlayer2.Click += new System.EventHandler(this.lblPlayer2_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(306, 150);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 4;
            this.lblResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(152, 166);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(0, 13);
            this.lblState.TabIndex = 5;
            // 
            // p
            // 
            this.p.EnableRaisingEvents = true;
            this.p.SynchronizingObject = this;
            // 
            // singlePlayerPanel
            // 
            this.singlePlayerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.singlePlayerPanel.Controls.Add(this.button2);
            this.singlePlayerPanel.Controls.Add(this.button1);
            this.singlePlayerPanel.Controls.Add(this.SinglePlayerName);
            this.singlePlayerPanel.Controls.Add(this.label1);
            this.singlePlayerPanel.Controls.Add(this.Hard);
            this.singlePlayerPanel.Controls.Add(this.Medium);
            this.singlePlayerPanel.Controls.Add(this.Easy);
            this.singlePlayerPanel.Controls.Add(this.lblState);
            this.singlePlayerPanel.Location = new System.Drawing.Point(201, 0);
            this.singlePlayerPanel.Name = "singlePlayerPanel";
            this.singlePlayerPanel.Size = new System.Drawing.Size(353, 85);
            this.singlePlayerPanel.TabIndex = 6;
            this.singlePlayerPanel.Visible = false;
            this.singlePlayerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.singlePlayerPanel_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SinglePlayerName
            // 
            this.SinglePlayerName.Location = new System.Drawing.Point(87, 15);
            this.SinglePlayerName.Name = "SinglePlayerName";
            this.SinglePlayerName.Size = new System.Drawing.Size(155, 20);
            this.SinglePlayerName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Player Name";
            // 
            // Hard
            // 
            this.Hard.Location = new System.Drawing.Point(162, 45);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(104, 24);
            this.Hard.TabIndex = 13;
            this.Hard.Text = "Hard";
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.Location = new System.Drawing.Point(90, 48);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(62, 17);
            this.Medium.TabIndex = 7;
            this.Medium.TabStop = true;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            this.Medium.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Easy
            // 
            this.Easy.AutoSize = true;
            this.Easy.Location = new System.Drawing.Point(17, 49);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(48, 17);
            this.Easy.TabIndex = 6;
            this.Easy.TabStop = true;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = true;
            // 
            // multiPlayerOfflinePanel
            // 
            this.multiPlayerOfflinePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.multiPlayerOfflinePanel.Controls.Add(this.multiPlayerCancel);
            this.multiPlayerOfflinePanel.Controls.Add(this.multiPlayerOK);
            this.multiPlayerOfflinePanel.Controls.Add(this.player2Name);
            this.multiPlayerOfflinePanel.Controls.Add(this.player1Name);
            this.multiPlayerOfflinePanel.Controls.Add(this.label3);
            this.multiPlayerOfflinePanel.Controls.Add(this.label2);
            this.multiPlayerOfflinePanel.Location = new System.Drawing.Point(202, 87);
            this.multiPlayerOfflinePanel.Name = "multiPlayerOfflinePanel";
            this.multiPlayerOfflinePanel.Size = new System.Drawing.Size(353, 67);
            this.multiPlayerOfflinePanel.TabIndex = 7;
            this.multiPlayerOfflinePanel.Visible = false;
            // 
            // multiPlayerCancel
            // 
            this.multiPlayerCancel.Location = new System.Drawing.Point(272, 37);
            this.multiPlayerCancel.Name = "multiPlayerCancel";
            this.multiPlayerCancel.Size = new System.Drawing.Size(60, 23);
            this.multiPlayerCancel.TabIndex = 5;
            this.multiPlayerCancel.Text = "Cancel";
            this.multiPlayerCancel.UseVisualStyleBackColor = true;
            this.multiPlayerCancel.Click += new System.EventHandler(this.button4_Click);
            // 
            // multiPlayerOK
            // 
            this.multiPlayerOK.Location = new System.Drawing.Point(271, 9);
            this.multiPlayerOK.Name = "multiPlayerOK";
            this.multiPlayerOK.Size = new System.Drawing.Size(61, 23);
            this.multiPlayerOK.TabIndex = 4;
            this.multiPlayerOK.Text = "OK";
            this.multiPlayerOK.UseVisualStyleBackColor = true;
            this.multiPlayerOK.Click += new System.EventHandler(this.multiPlayerOK_Click);
            // 
            // player2Name
            // 
            this.player2Name.Location = new System.Drawing.Point(86, 38);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(155, 20);
            this.player2Name.TabIndex = 3;
            // 
            // player1Name
            // 
            this.player1Name.Location = new System.Drawing.Point(86, 11);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(155, 20);
            this.player1Name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(26, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Player 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(23, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player 1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 330);
            this.ControlBox = false;
            this.Controls.Add(this.multiPlayerOfflinePanel);
            this.Controls.Add(this.singlePlayerPanel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.homePanel);
            this.DoubleBuffered = true;
            this.Name = "mainForm";
            this.Text = "Tik Tac Toe";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseUp);
            this.homePanel.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p)).EndInit();
            this.singlePlayerPanel.ResumeLayout(false);
            this.singlePlayerPanel.PerformLayout();
            this.multiPlayerOfflinePanel.ResumeLayout(false);
            this.multiPlayerOfflinePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel singlePlayerPanel;

        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Button btnMultiplayerOnline;
        private System.Windows.Forms.Button btnMultiplayerOffline;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button[] btns;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblResult; //Buttons 
        private Game game;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnReset;
        private System.IO.FileSystemWatcher p;
        private System.Windows.Forms.RadioButton Hard;
        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.RadioButton Easy;
        private System.Windows.Forms.TextBox SinglePlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Panel multiPlayerOfflinePanel;
        private System.Windows.Forms.Button multiPlayerCancel;
        private System.Windows.Forms.Button multiPlayerOK;
        private System.Windows.Forms.TextBox player2Name;
        private System.Windows.Forms.TextBox player1Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

