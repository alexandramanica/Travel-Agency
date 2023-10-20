using ProiectPAW2023_Tursim.Base;
using ProiectPAW2023_Tursim.Classes;
using ProiectPAW2023_Tursim.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW2023_Tursim
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            Text = "Alexandra";
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initializare home
            {
               
               lbStatistici.Text = "Statistici";
                this.pnlContent.Controls.Clear();
                Home home = new Home()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                this.pnlContent.Controls.Add(home);
                home.Show();
            }


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lbStatistici.Text = "Statistici";
            this.pnlContent.Controls.Clear();
            Home home = new Home()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.pnlContent.Controls.Add(home);
            home.Show();
        }

        private void btnTuristi_Click(object sender, EventArgs e)
        {
            lbStatistici.Text = "Informatii Turisti";
            this.pnlContent.Controls.Clear();
            Turisti turisti = new Turisti()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.pnlContent.Controls.Add(turisti);
            turisti.Show();
        }

        private void btnServicii_Click(object sender, EventArgs e)
        {
            lbStatistici.Text = "Informatii Servicii";
            this.pnlContent.Controls.Clear();
            Servicii servicii = new Servicii()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.pnlContent.Controls.Add(servicii);
            servicii.Show();
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Doriti sa parasiti aplicatia?", "Iesire din aplicatie", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes);
            { 
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
          
            FormularLogIn formularLogIn = new FormularLogIn();
            formularLogIn.ShowDialog();
        }

        private void btnTranzactii_Click(object sender, EventArgs e)
        {
            lbStatistici.Text = "Informatii Tranzactii";
            this.pnlContent.Controls.Clear();
            Tranzactii tranzactii = new Tranzactii()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.pnlContent.Controls.Add(tranzactii);
            tranzactii.Show();
        }
    }
}
