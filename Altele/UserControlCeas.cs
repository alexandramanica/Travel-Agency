using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW2023_Tursim
{
  
    public partial class UserControlCeas : UserControl
    {
        Timer tm;
        public UserControlCeas()
        {
            InitializeComponent();
            tm = new Timer();
            tm.Interval = 1;
            tm.Tick += tm_Tick;
            tm.Start();
        }
        void tm_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
