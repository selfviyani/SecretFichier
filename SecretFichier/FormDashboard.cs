using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretFichier
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void bt_add_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog () == DialogResult.OK)
            {
                tb_dshow.Text = ofd.FileName;
            }
        }
        
        private void bn_ok_Click(object sender, EventArgs e)
        {
            FormProcess ipass = new FormProcess(tb_dshow.Text, rb_encryp.Checked);
            this.Hide();
            ipass.ShowDialog();
        }

        private void rb_encryp_CheckedChanged(object sender, EventArgs e)
        {
                bn_start.Enabled = true;
        }

        private void rb_decryp_CheckedChanged(object sender, EventArgs e)
        {
            bn_start.Enabled = true;
        }

        private void bn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bn_about_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }
    }
}
