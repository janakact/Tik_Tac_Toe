namespace Tik_Tac_Toe
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
            this.homeScene = new System.Windows.Forms.Panel();
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.btnMultiplayerOffline = new System.Windows.Forms.Button();
            this.btnMultiplayerOnline = new System.Windows.Forms.Button();
            this.homeScene.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeScene
            // 
            this.homeScene.Controls.Add(this.btnMultiplayerOnline);
            this.homeScene.Controls.Add(this.btnMultiplayerOffline);
            this.homeScene.Controls.Add(this.btnSinglePlayer);
            this.homeScene.Location = new System.Drawing.Point(12, 12);
            this.homeScene.Name = "homeScene";
            this.homeScene.Size = new System.Drawing.Size(133, 217);
            this.homeScene.TabIndex = 0;
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
            // btnMultiplayerOffline
            // 
            this.btnMultiplayerOffline.Location = new System.Drawing.Point(3, 32);
            this.btnMultiplayerOffline.Name = "btnMultiplayerOffline";
            this.btnMultiplayerOffline.Size = new System.Drawing.Size(125, 23);
            this.btnMultiplayerOffline.TabIndex = 1;
            this.btnMultiplayerOffline.Text = "Multiplayer (offline)";
            this.btnMultiplayerOffline.UseVisualStyleBackColor = true;
            // 
            // btnMultiplayerOnline
            // 
            this.btnMultiplayerOnline.Location = new System.Drawing.Point(3, 61);
            this.btnMultiplayerOnline.Name = "btnMultiplayerOnline";
            this.btnMultiplayerOnline.Size = new System.Drawing.Size(125, 23);
            this.btnMultiplayerOnline.TabIndex = 2;
            this.btnMultiplayerOnline.Text = "Multiplayer (online)";
            this.btnMultiplayerOnline.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 241);
            this.Controls.Add(this.homeScene);
            this.Name = "Form1";
            this.Text = "Form1";
            this.homeScene.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homeScene;
        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Button btnMultiplayerOnline;
        private System.Windows.Forms.Button btnMultiplayerOffline;
    }
}

