using System;
using System.Windows.Forms;

namespace GYM_Proyecto2_Forms_Ext
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Form1());
        }
    }
}