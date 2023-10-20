using ProiectPAW2023_Tursim.Forms.Formular_LogIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace ProiectPAW2023_Tursim.Forms
{
    public partial class FormularLogIn : Form
    {

        public FormularLogIn()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Doriti sa parasiti aplicatia?", "Iesire din aplicatie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        private bool IsUsernameValid()
        {
            return string.IsNullOrWhiteSpace(tbUsername.Text.Trim());
        }

        private bool IsPasswordValid()
        {
            return string.IsNullOrWhiteSpace(tbPassword.Text.Trim());
        }

        //Logare user
        private void Login_Click(object sender, EventArgs e)
        {

            String username, password;
            username = tbUsername.Text;
            password = tbPassword.Text;

            if (ValidateChildren())
            {
                MessageBox.Show("Completeaza campurile aferente pentru a te loga!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (username == "admin" && password == "admin")
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Autentificare nereusita.Incercati din nou", "Autentificare nereusita", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }
            

    

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            tbPassword.Focus();
             e.SuppressKeyPress = true;
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login.PerformClick();
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.ShowDialog();
        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Clear();
        }

        private void tbUsername_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError((Control)sender, string.Empty);
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (!IsUsernameValid())
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Username lipseste!");
            }
        }

        private void tbPassword_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError((Control)sender, string.Empty);
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!IsPasswordValid())
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Parola lipseste!");
            }
        }
    }
}
