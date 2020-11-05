using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmColorPicker
{
    public partial class FrmColorPicker : Form
    {
        public FrmColorPicker()
        {
            InitializeComponent();
        }

        private void selectColor()
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            colorDialog.Color = colorClientPanel.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                txtClientRed.Text = colorDialog.Color.R.ToString();
                txtClientGreen.Text = colorDialog.Color.G.ToString();
                txtClientBlue.Text = colorDialog.Color.B.ToString();

                colorClientPanel.BackColor = colorDialog.Color;
            }

            if (btnKirim.Enabled.Equals(false))
            {
                btnKirim.Enabled = true;
            }
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            StringBuilder color = new StringBuilder();
            color.Append(txtClientRed.Text)
                .Append(",")
                .Append(txtClientGreen.Text)
                .Append(",")
                .Append(txtClientBlue.Text);

            varGlobal.alamatIPServer = txtIPClient.Text;
            varGlobal.port = Int16.Parse(txtPortClient.Text);
            SocketColorPicker.StartClient(color.ToString()); ;
        }

        private void btnCustomColor_Click(object sender, EventArgs e)
        {
            selectColor();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(listenSocket);
            if (txtIPServer.Text != "" && txtPortServer.Text != "")
            {
                thr.Start();
                btnListen.Enabled = false;
                txtIPServer.Enabled = false;
                txtPortServer.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lengkapi port dan alamat IP terlebih dahulu !!!");
            }
        }

        private void listenSocket()
        {
            varGlobal.port = Int16.Parse(txtPortServer.Text); // konversi daristring ke integer
            varGlobal.alamatIPServer = txtIPServer.Text;
            SocketColorPicker.StartListening();
        }

        private void timerServer_Tick(object sender, EventArgs e)
        {
            if (varGlobal.terimapesandiserver.Length > 1)
            {
                colorServerPanel.BackColor = Color.Transparent;
                string[] data = varGlobal.terimapesandiserver.Trim().Split(',');
                txtRed.Text = data[0];
                txtGreen.Text = data[1];
                txtBlue.Text = data[2];

                int r = 0;
                int g = 0;
                int b = 0;

                if (Int32.TryParse(txtRed.Text, out r)
                    && Int32.TryParse(txtGreen.Text, out g)
                    && Int32.TryParse(txtBlue.Text, out b))
                {
                    colorServerPanel.BackColor = Color.FromArgb(r, g, b);
                }
            }
        }
    }
}
