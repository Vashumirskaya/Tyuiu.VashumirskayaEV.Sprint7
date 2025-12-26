using System;
using System.Windows.Forms;
using Tyuiu.VashumirskayaEV.Sprint7.Project.V10;

namespace Tyuiu.VashumirskayaVEV.Sprint7.Project.V10
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain_VEV());
        }
    }
}
