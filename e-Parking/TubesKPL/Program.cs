using System;
using System.Windows.Forms;

namespace TubesKPL
{
    static class Program
    {
        // Yang pertama di run ketika program dijalankan.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignIn());
        }
    }
}
