using ProiectPAW2023_Tursim.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using ProiectPAW2023_Tursim.Base;
using System.Runtime.CompilerServices;

namespace ProiectPAW2023_Tursim.Forms.FormulareAdd
{
    public partial class FormularAdaugaTranzactie : Form
    {
        Tranzactii tranz;
        public FormularAdaugaTranzactie(Tranzactii tranz_)
        {
            InitializeComponent();
            this.tranz = tranz_;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ev de enter in formular pentru fiecare textbox
        private void tbIdTranzactie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    tbValoareTranzactie.Focus();
                    e.SuppressKeyPress = true;
                    tbValoareTranzactie.Clear();
            }
        }
        private void tbValoareTranzactie_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                tbCodClient.Focus();
                e.SuppressKeyPress = true;
                tbCodClient.Clear();

            }
        }
        private void tbCodClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbCodServiciu.Focus();
                e.SuppressKeyPress = true;
                tbCodServiciu.Clear();
            }
        }

        private void tbCodServiciu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtDataTranzactie.Focus();
                e.SuppressKeyPress = true;
               
            }
        }

        private void btnAddTranzactieForm_Click(object sender, EventArgs e)
        {

            tranz.dt.Rows.Add(int.Parse(tbIdTranzactie.Text),double.Parse(tbValoareTranzactie.Text),int.Parse(tbCodClient.Text),int.Parse(tbCodServiciu.Text),dtDataTranzactie.Value);
            
        }

        private void tbIdTranzactie_MouseClick(object sender, MouseEventArgs e)
        {
            tbIdTranzactie.Clear();
            
        }

        private void tbValoareTranzactie_MouseClick(object sender, MouseEventArgs e)
        {
            tbValoareTranzactie.Clear();
        }

        private void tbCodClient_MouseClick(object sender, MouseEventArgs e)
        {
            tbCodClient.Clear();
        }

        private void tbCodServiciu_MouseClick(object sender, MouseEventArgs e)
        {
            tbCodServiciu.Clear();
        }

        private void FormularAdaugaTranzactie_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbIdTranzactie.Clear();
            tbValoareTranzactie.Clear();
            tbCodClient.Clear();
            tbCodServiciu.Clear();
        }
    }

}
