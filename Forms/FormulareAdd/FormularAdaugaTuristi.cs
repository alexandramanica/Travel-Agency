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

namespace ProiectPAW2023_Tursim.Forms
{
    public partial class FormularAdaugaTuristi : Form
    {
        Turisti turisti;
        public FormularAdaugaTuristi(Turisti turisti_)
        {
            InitializeComponent();
            this.turisti = turisti_;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //inchidem fereastra
        }

        private void tbId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbNume.Focus();
                e.SuppressKeyPress = true;
                tbNume.Clear();
            }
        }
        private void tbNume_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPrenume.Focus();
                e.SuppressKeyPress = true;
                tbPrenume.Clear();
            }
        }

        private void tbPrenume_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                tbTelefon.Focus();
                e.SuppressKeyPress = true;
                tbTelefon.Clear();
            }
        }

        private void tbTelefon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbMail.Focus();
                e.SuppressKeyPress = true;
                tbMail.Clear();
            }
        }

        private void tbMail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtDataNastere.Focus();
                e.SuppressKeyPress = true;
               
            }
        }

        private void btnAddTuristForm_Click(object sender, EventArgs e)
        {
            turisti.dt.Rows.Add(int.Parse(tbId.Text),tbNume.Text,tbPrenume.Text,tbMail.Text,tbTelefon.Text,dtDataNastere.Value);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbId.Clear();
            tbNume.Clear();
            tbPrenume.Clear();
            tbTelefon.Clear();
            tbMail.Clear();
           
        }

        private void tbId_MouseClick(object sender, MouseEventArgs e)
        {
            tbId.Clear();
        }

        private void tbNume_MouseClick(object sender, MouseEventArgs e)
        {
            tbNume.Clear();
        }

        private void tbPrenume_MouseClick(object sender, MouseEventArgs e)
        {
            tbPrenume.Clear();
        }

        private void tbTelefon_MouseClick(object sender, MouseEventArgs e)
        {
            tbTelefon.Clear();
        }

        private void tbMail_MouseClick(object sender, MouseEventArgs e)
        {
            tbMail.Clear();
        }
    }
}
