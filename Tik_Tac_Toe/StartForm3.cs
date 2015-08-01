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
    public partial class StartForm3 : Form
    {
        public bool isServer = false;
        public bool isClient = true;
        public String playerName;
        public String ip;
        public event EventHandler OKPressed; // Eevnt handler 

        public StartForm3()
        {
            InitializeComponent();
        }

        private void StartForm3_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (OKPressed != null)
            {
                OKPressed(this, EventArgs.Empty);
            }
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ip = txtIPAdr.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            playerName = txtName.Text;
        }

        private void btnClient_CheckedChanged(object sender, EventArgs e)
        {
            isClient = btnClient.Checked;
            if(isClient)
            {
                txtIPAdr.Enabled = true;
            }
            else
            {
                txtIPAdr.Enabled = false;
            }
        }

        private void btnServer_CheckedChanged(object sender, EventArgs e)
        {
            isServer = btnServer.Checked;
        }
    }
}
