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
            this.btnStop = new System.Windows.Forms.Button();
            this.btnMultiplayerOnline = new System.Windows.Forms.Button();
            this.btnMultiplayerOffline = new System.Windows.Forms.Button();
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.p = new System.IO.FileSystemWatcher();
            this.homePanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p)).BeginInit();
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
            this.homePanel.Location = new System.Drawing.Point(85, 12);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(198, 311);
            this.homePanel.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(4, 185);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(190, 39);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Close";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnMultiplayerOnline
            // 
            this.btnMultiplayerOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnMultiplayerOnline.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMultiplayerOnline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnMultiplayerOnline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnMultiplayerOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplayerOnline.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplayerOnline.Location = new System.Drawing.Point(4, 112);
            this.btnMultiplayerOnline.Name = "btnMultiplayerOnline";
            this.btnMultiplayerOnline.Size = new System.Drawing.Size(190, 39);
            this.btnMultiplayerOnline.TabIndex = 2;
            this.btnMultiplayerOnline.Text = "Multiplayer (online)";
            this.btnMultiplayerOnline.UseVisualStyleBackColor = false;
            this.btnMultiplayerOnline.Click += new System.EventHandler(this.btnMultiplayerOnline_Click);
            // 
            // btnMultiplayerOffline
            // 
            this.btnMultiplayerOffline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnMultiplayerOffline.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMultiplayerOffline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnMultiplayerOffline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnMultiplayerOffline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplayerOffline.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplayerOffline.Location = new System.Drawing.Point(4, 62);
            this.btnMultiplayerOffline.Name = "btnMultiplayerOffline";
            this.btnMultiplayerOffline.Size = new System.Drawing.Size(190, 39);
            this.btnMultiplayerOffline.TabIndex = 1;
            this.btnMultiplayerOffline.Text = "Multiplayer (offline)";
            this.btnMultiplayerOffline.UseVisualStyleBackColor = false;
            this.btnMultiplayerOffline.Click += new System.EventHandler(this.btnMultiplayerOffline_Click);
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnSinglePlayer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSinglePlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnSinglePlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnSinglePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinglePlayer.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinglePlayer.Location = new System.Drawing.Point(3, 3);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(190, 39);
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
            this.gamePanel.Controls.Add(this.label3);
            this.gamePanel.Location = new System.Drawing.Point(302, 20);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(423, 298);
            this.gamePanel.TabIndex = 1;
            this.gamePanel.Visible = false;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(307, 249);
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
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPlayer1.Location = new System.Drawing.Point(303, 31);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(100, 20);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Player1 Wins";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.Brown;
            this.lblPlayer2.Location = new System.Drawing.Point(306, 68);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(61, 20);
            this.lblPlayer2.TabIndex = 3;
            this.lblPlayer2.Text = "Player2";
            this.lblPlayer2.Click += new System.EventHandler(this.lblPlayer2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(403, 180);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(0, 13);
            this.lblState.TabIndex = 5;
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
            this.BackgroundImage = global::Tik_Tac_Toe.Properties.Resources.back5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(801, 335);
            this.ControlBox = false;
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.homePanel);
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
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label label3; //Buttons 
        private Game game;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnReset;
        private System.IO.FileSystemWatcher p;
    }
}

