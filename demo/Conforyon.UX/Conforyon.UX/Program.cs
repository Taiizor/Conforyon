using Conforyon.Culture;
using Conforyon.UX.UI;
using System;
using System.Windows.Forms;

namespace Conforyon.UX
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Cultures.SetAllCulture();
            Application.EnableVisualStyles();
#if NET5_0 || NET6_0
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MAIN());
        }
    }
}