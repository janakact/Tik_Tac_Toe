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
            this.homePanel = new System.Windows.Forms.Panel();
            this.MultiPlayerOfflinePanel = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnMultiplayerOnline = new System.Windows.Forms.Button();
            this.btnMultiplayerOffline = new System.Windows.Forms.Button();
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.singlePlayerPanel = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.player2Name = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SinglePlayerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.player1Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Hard = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Medium = new System.Windows.Forms.RadioButton();
            this.Easy = new System.Windows.Forms.RadioButton();
            this.lblState = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.p = new System.IO.FileSystemWatcher();
            this.homePanel.SuspendLayout();
            this.MultiPlayerOfflinePanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.singlePlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p)).BeginInit();
            this.SuspendLayout();
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.Transparent;
            this.homePanel.Controls.Add(this.singlePlayerPanel);
            this.homePanel.Controls.Add(this.MultiPlayerOfflinePanel);
            this.homePanel.Controls.Add(this.btnStop);
            this.homePanel.Controls.Add(this.btnMultiplayerOnline);
            this.homePanel.Controls.Add(this.btnMultiplayerOffline);
            this.homePanel.Controls.Add(this.btnSinglePlayer);
            this.homePanel.ForeColor = System.Drawing.Color.Black;
            this.homePanel.Location = new System.Drawing.Point(12, 7);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(184, 311);
            this.homePanel.TabIndex = 0;
            // 
            // MultiPlayerOfflinePanel
            // 
            this.MultiPlayerOfflinePanel.BackColor = System.Drawing.Color.White;
            this.MultiPlayerOfflinePanel.Controls.Add(this.button7);
            this.MultiPlayerOfflinePanel.Controls.Add(this.radioButton1);
            this.MultiPlayerOfflinePanel.Controls.Add(this.radioButton2);
            this.MultiPlayerOfflinePanel.Controls.Add(this.radioButton3);
            this.MultiPlayerOfflinePanel.Controls.Add(this.label5);
            this.MultiPlayerOfflinePanel.Controls.Add(this.button5);
            this.MultiPlayerOfflinePanel.Controls.Add(this.textBox1);
            this.MultiPlayerOfflinePanel.Location = new System.Drawing.Point(15, 219);
            this.MultiPlayerOfflinePanel.Name = "MultiPlayerOfflinePanel";
            this.MultiPlayerOfflinePanel.Size = new System.Drawing.Size(268, 92);
            this.MultiPlayerOfflinePanel.TabIndex = 2;
            this.MultiPlayerOfflinePanel.Visible = false;
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
            this.gamePanel.Controls.Add(this.btnReset);
            this.gamePanel.Controls.Add(this.lblPlayer1);
            this.gamePanel.Controls.Add(this.lblPlayer2);
            this.gamePanel.Controls.Add(this.lblResult);
            this.gamePanel.Location = new System.Drawing.Point(202, 12);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(454, 306);
            this.gamePanel.TabIndex = 3;
            this.gamePanel.Visible = false;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            // 
            // singlePlayerPanel
            // 
            
            this.singlePlayerPanel.BackColor = System.Drawing.Color.White;
            this.singlePlayerPanel.Controls.Add(this.button8);
            this.singlePlayerPanel.Controls.Add(this.button4);
            this.singlePlayerPanel.Controls.Add(this.button2);
            this.singlePlayerPanel.Controls.Add(this.button6);
            this.singlePlayerPanel.Controls.Add(this.label4);
            this.singlePlayerPanel.Controls.Add(this.button3);
            this.singlePlayerPanel.Controls.Add(this.button1);
            this.singlePlayerPanel.Controls.Add(this.textBox3);
            this.singlePlayerPanel.Controls.Add(this.textBox2);
            this.singlePlayerPanel.Controls.Add(this.player2Name);
            this.singlePlayerPanel.Controls.Add(this.SinglePlayerName);
            this.singlePlayerPanel.Controls.Add(this.label6);
            this.singlePlayerPanel.Controls.Add(this.player1Name);
            this.singlePlayerPanel.Controls.Add(this.label3);
            this.singlePlayerPanel.Controls.Add(this.label1);
            this.singlePlayerPanel.Controls.Add(this.label2);
            this.singlePlayerPanel.Controls.Add(this.Hard);
            this.singlePlayerPanel.Controls.Add(this.Medium);
            this.singlePlayerPanel.Controls.Add(this.Easy);
            this.singlePlayerPanel.Controls.Add(this.lblState);
            this.singlePlayerPanel.Location = new System.Drawing.Point(143, 11);
            this.singlePlayerPanel.Name = "singlePlayerPanel";
            this.singlePlayerPanel.Size = new System.Drawing.Size(318, 74);
            this.singlePlayerPanel.TabIndex = 1;
            this.singlePlayerPanel.Visible = false;
            this.singlePlayerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.singlePlayerPanel_Paint);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(209, 52);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 28);
            this.button8.TabIndex = 5;
            this.button8.Text = "Cancel";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(419, 152);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 28);
            this.button4.TabIndex = 5;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(188, 42);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 33);
            this.button7.TabIndex = 12;
            this.button7.Text = "Cancel";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(209, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 28);
            this.button6.TabIndex = 4;
            this.button6.Text = "OK";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button3_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(419, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(188, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 31);
            this.button5.TabIndex = 11;
            this.button5.Text = "OK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(108, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 20);
            this.textBox2.TabIndex = 10;
            // 
            // player2Name
            // 
            this.player2Name.Location = new System.Drawing.Point(311, 152);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(100, 20);
            this.player2Name.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // SinglePlayerName
            // 
            this.SinglePlayerName.Location = new System.Drawing.Point(305, 127);
            this.SinglePlayerName.Name = "SinglePlayerName";
            this.SinglePlayerName.Size = new System.Drawing.Size(106, 20);
            this.SinglePlayerName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Player 2 Name";
            // 
            // player1Name
            // 
            this.player1Name.Location = new System.Drawing.Point(311, 126);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(100, 20);
            this.player1Name.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(0, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Player Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Player 2 Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Player 1 Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(229, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Player Name";
            // 
            // radioButton3
            // 
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Location = new System.Drawing.Point(128, 48);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 24);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.Text = "Hard";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player 1 Name";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(60, 51);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Medium";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Hard
            // 
            this.Hard.BackColor = System.Drawing.Color.Transparent;
            this.Hard.Location = new System.Drawing.Point(357, 155);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(54, 24);
            this.Hard.TabIndex = 13;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(6, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Easy";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.BackColor = System.Drawing.Color.Transparent;
            this.Medium.Location = new System.Drawing.Point(289, 158);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(62, 17);
            this.Medium.TabIndex = 7;
            this.Medium.TabStop = true;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = false;
            this.Medium.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Easy
            // 
            this.Easy.AutoSize = true;
            this.Easy.BackColor = System.Drawing.Color.Transparent;
            this.Easy.Location = new System.Drawing.Point(235, 158);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(48, 17);
            this.Easy.TabIndex = 6;
            this.Easy.TabStop = true;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = false;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(152, 166);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(0, 13);
            this.lblState.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Informal Roman", 14.25F);
            this.btnReset.Location = new System.Drawing.Point(310, 239);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 36);
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
            this.lblPlayer1.Location = new System.Drawing.Point(306, 39);
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
            this.lblPlayer2.Location = new System.Drawing.Point(306, 59);
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
            // p
            // 
            this.p.EnableRaisingEvents = true;
            this.p.SynchronizingObject = this;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Tik_Tac_Toe.Properties.Resources.ruled_paper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 321);
            this.ControlBox = false;
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.gamePanel);
            this.DoubleBuffered = true;
            this.Name = "mainForm";
            this.Text = "Tik Tac Toe";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseUp);
            this.homePanel.ResumeLayout(false);
            this.MultiPlayerOfflinePanel.ResumeLayout(false);
            this.MultiPlayerOfflinePanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.singlePlayerPanel.ResumeLayout(false);
            this.singlePlayerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Panel singlePlayerPanel;
        private System.Windows.Forms.RadioButton Hard;
        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.RadioButton Easy;
        private System.Windows.Forms.TextBox SinglePlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel MultiPlayerOfflinePanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox player2Name;
        private System.Windows.Forms.TextBox player1Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

