using ProiectPAW2023_Tursim.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW2023_Tursim.Forms.FormulareAdd
{
    public partial class FormularAddServiciu : Form
    {
        Servicii servicii;
        public FormularAddServiciu(Servicii servicii_)
        {
            InitializeComponent();
            this.servicii = servicii_;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTuristForm_Click(object sender, EventArgs e)
        {
            servicii.dt.Rows.Add(int.Parse(tbIdServiciu.Text), tbNumeDestinatie.Text, double.Parse(tbPretPerZi.Text), int.Parse(tbNrZile.Text), int.Parse(tbNrPers.Text),tbHotel.Text, dtDataRezervare.Value);
        }

        private void tbIdServiciu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbNumeDestinatie.Focus();
                e.SuppressKeyPress = true;
                tbNumeDestinatie.Clear();
            }
        }

        private void tbNumeDestinatie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPretPerZi.Focus();
                e.SuppressKeyPress = true;
                tbPretPerZi.Clear();
            }
        }

       

        private void tbNrZile_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                tbNrPers.Focus();
                e.SuppressKeyPress = true;
                tbNrPers .Clear();
            }
        }

        private void tbNrPers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbHotel.Focus();
                e.SuppressKeyPress = true;
                tbHotel.Clear();
            }
        }

        private void tbHotel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtDataRezervare.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void tbPretPerZi_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                tbNrZile.Focus();
                e.SuppressKeyPress = true;
                tbNrZile .Clear();
            }
        }

        private void tbIdServiciu_MouseClick(object sender, MouseEventArgs e)
        {
            tbIdServiciu.Clear();
        }

       

        private void tbPretPerZi_MouseClick(object sender, MouseEventArgs e)
        {
            tbPretPerZi.Clear();
        }

        private void tbNrZile_MouseClick(object sender, MouseEventArgs e)
        {
            tbNrZile.Clear();
        }

        private void tbNrPers_MouseClick(object sender, MouseEventArgs e)
        {
            tbNrPers.Clear();
        }

        private void tbHotel_MouseClick(object sender, MouseEventArgs e)
        {
            tbHotel.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbIdServiciu.Clear();
            tbNumeDestinatie.Clear();
            tbPretPerZi.Clear();
            tbNrZile.Clear();
            tbNrPers.Clear();
            tbHotel.Clear();
        }

        private void tbNumeDestinatie_MouseClick(object sender, MouseEventArgs e)
        {
            tbNumeDestinatie.Clear();
        }
    }
}
