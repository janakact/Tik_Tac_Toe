namespace Tik_Tac_Toe
{
    partial class StartForm3
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
            this.txtIPAdr = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.RadioButton();
            this.btnServer = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtIPAdr
            // 
            this.txtIPAdr.Location = new System.Drawing.Point(16, 117);
            this.txtIPAdr.Name = "txtIPAdr";
            this.txtIPAdr.Size = new System.Drawing.Size(300, 20);
            this.txtIPAdr.TabIndex = 0;
            this.txtIPAdr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(161, 143);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(242, 143);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the IP address of the server.";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 20);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnClient
            // 
            this.btnClient.AutoSize = true;
            this.btnClient.BackColor = System.Drawing.Color.Transparent;
            this.btnClient.Checked = true;
            this.btnClient.Location = new System.Drawing.Point(16, 56);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(74, 17);
            this.btnClient.TabIndex = 6;
            this.btnClient.TabStop = true;
            this.btnClient.Text = "As a client";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.CheckedChanged += new System.EventHandler(this.btnClient_CheckedChanged);
            // 
            // btnServer
            // 
            this.btnServer.AutoSize = true;
            this.btnServer.BackColor = System.Drawing.Color.Transparent;
            this.btnServer.Location = new System.Drawing.Point(170, 56);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(78, 17);
            this.btnServer.TabIndex = 7;
            this.btnServer.Text = "As a server";
            this.btnServer.UseVisualStyleBackColor = false;
            this.btnServer.CheckedChanged += new System.EventHandler(this.btnServer_CheckedChanged);
            // 
            // StartForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tik_Tac_Toe.Properties.Resources.wood;
            this.ClientSize = new System.Drawing.Size(321, 172);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtIPAdr);
            this.Name = "StartForm3";
            this.Text = "Connect To the server";
            this.Load += new System.EventHandler(this.StartForm3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIPAdr;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton btnClient;
        private System.Windows.Forms.RadioButton btnServer;
    }
}