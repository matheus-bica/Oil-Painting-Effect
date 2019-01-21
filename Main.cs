using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Windows.Media.Imaging;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace TrabalhoFPI
{
    class Program
    {
        [STAThread]
        public static int Main()
        {
            MainWindow janela = new MainWindow();
            Application.EnableVisualStyles();
            janela.Show();
            Application.Run();

           

            return 0;
        }
    }
}
