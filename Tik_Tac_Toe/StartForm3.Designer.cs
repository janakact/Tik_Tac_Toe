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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRed = new System.Windows.Forms.RadioButton();
            this.btnBlue = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(15, 106);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(300, 20);
            this.txtPath.TabIndex = 0;
            this.txtPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(159, 132);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(240, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shared directory path";
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
            // btnRed
            // 
            this.btnRed.AutoSize = true;
            this.btnRed.BackColor = System.Drawing.Color.Transparent;
            this.btnRed.Checked = true;
            this.btnRed.Location = new System.Drawing.Point(16, 56);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(45, 17);
            this.btnRed.TabIndex = 6;
            this.btnRed.TabStop = true;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.CheckedChanged += new System.EventHandler(this.btnClient_CheckedChanged);
            // 
            // btnBlue
            // 
            this.btnBlue.AutoSize = true;
            this.btnBlue.BackColor = System.Drawing.Color.Transparent;
            this.btnBlue.Location = new System.Drawing.Point(159, 56);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(46, 17);
            this.btnBlue.TabIndex = 7;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.CheckedChanged += new System.EventHandler(this.btnServer_CheckedChanged);
            // 
            // StartForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 167);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPath);
            this.Name = "StartForm3";
            this.Text = "Connect To the server";
            this.Load += new System.EventHandler(this.StartForm3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton btnRed;
        private System.Windows.Forms.RadioButton btnBlue;
    }
}