using System;
using System.Threading;
using System.Windows.Forms;

namespace Metro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //For some reason the glow has to be initialized outside of the parent form
            TestForm form = new TestForm();
            MetroFormGlow glow = new MetroFormGlow(form);
            form.glow = glow;
            glow.Show();

            Application.Run(form);
        }
    }
}
