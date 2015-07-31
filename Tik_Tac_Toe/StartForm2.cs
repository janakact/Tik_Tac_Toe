using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tik_Tac_Toe
{
    public partial class StartForm2 : Form
    {

        public String player1Name;
        public String player2Name;
        public StartForm2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String temp = sender.ToString().Substring(36);
            this.player1Name = temp;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String temp = sender.ToString().Substring(36);
            this.player2Name = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
