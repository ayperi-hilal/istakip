using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personelisTakip
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new ekran());
            //Application.Run(new departmanlar());
            //Application.Run(new personeller());           
            //Application.Run(new personelİstatistigi());         ,
            //Application.Run(new gorevListesi());
            //Application.Run(new anaform());
           Application.Run(new Login.login());
            
        }
    }
}
