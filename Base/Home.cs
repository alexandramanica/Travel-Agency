using ProiectPAW2023_Tursim.Base;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace ProiectPAW2023_Tursim.Forms
{
   
    public partial class Home : Form
    {
        public Home()
        {

            InitializeComponent();
            FillChart();
        }

        void FillChart()
        {
            chart1.Series["s1"].Points.AddXY("2022", "2342");
            chart1.Series["s1"].Points.AddXY("2021", "3340");
            chart1.Series["s1"].Points.AddXY("2020", "1014");
            chart1.Series["s1"].Points.AddXY("2019", "2200");
        }

        private void btnInformatiiSuplimentare_Click(object sender, EventArgs e)
        {
            InformatiiSuplimentare informatiiSuplimentare = new InformatiiSuplimentare();
            informatiiSuplimentare.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Doriti sa parasiti aplicatia?", "Iesire din aplicatie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            RateExperience rateExperience = new RateExperience();
            rateExperience.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
