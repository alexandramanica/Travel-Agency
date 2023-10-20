using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW2023_Tursim.Base
{
    public partial class RateExperience : Form
    {
        //data binding
        public RateExperience()
        {
            InitializeComponent();
            var rateExperience = new List<int>();
            rateExperience.Add(1);
            rateExperience.Add(2);
            rateExperience.Add(3);
            rateExperience.Add(4);
            rateExperience.Add(5);
            comboBoxRate.DataSource=rateExperience;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Doriti sa trimiteti recenzia experientiei voastre catre administrator?", "Recenzie aplicatie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
