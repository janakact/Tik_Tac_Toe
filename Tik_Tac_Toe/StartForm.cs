using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
namespace Tik_Tac_Toe
{
    public partial class StartForm : Form
    {
        public String singlePlayerName;
        public int difficulty;
        
        public event EventHandler OKPressed; // Eevnt handler 
        private static readonly ILog logger = LogManager.GetLogger(typeof(StartForm));


        public StartForm()
        {

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioButton1.Checked)
            {
                difficulty = SinglePlayerGame.EasyLevel;
            }
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
            {
                difficulty = SinglePlayerGame.MediumLevel;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked)
            {
                difficulty = SinglePlayerGame.HardLevel;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") singlePlayerName = "Player1";
            if (OKPressed != null)
            {
                //logger.("OK button pressed");
                OKPressed(this, EventArgs.Empty);
            }
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String temp = sender.ToString().Substring(36);
            this.singlePlayerName =temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
