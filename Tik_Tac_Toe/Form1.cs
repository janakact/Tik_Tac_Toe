using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

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
                this.btns[i].Text = "Button " + i;
                this.btns[i].UseVisualStyleBackColor = true;
                this.btns[i].Click += new System.EventHandler(this.btn_Click);
            }

            //Grid
            this.grid = new Grid();

        }

        private void btn_Click(object sender, EventArgs e)
        {
            (sender as System.Windows.Forms.Button).Text = " ";
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
