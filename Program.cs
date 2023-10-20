using ProiectPAW2023_Tursim.Classes;
using ProiectPAW2023_Tursim.Forms;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProiectPAW2023_Tursim
{
    
    internal static class Program
    {
 
        

       
        [STAThread]
        static void Main()
        {
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormularLogIn());
            
        }
    }
}
