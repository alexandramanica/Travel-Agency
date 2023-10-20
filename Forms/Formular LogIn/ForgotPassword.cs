using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW2023_Tursim.Forms.Formular_LogIn
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Un email a fost trimis la adresa respectivă!","Recuperare parolă",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void tbEmailFP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSendEmail.PerformClick();
            }
        }
        private void tbEmailFP_Click(object sender, EventArgs e)
        {
            tbEmailFP.Clear();
        }
    }
}
