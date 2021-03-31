using Conforyon.Culture;
using System;
using System.Windows.Forms;

namespace Conforyon.UI
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Cultures.SetCulture();
            Cultures.SetUICulture();
            Cultures.SetThreadCulture();
            Cultures.SetThreadUICulture();
            Application.EnableVisualStyles();
#if NETCOREAPP3_1 || NET5_0 || NET6_0
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}