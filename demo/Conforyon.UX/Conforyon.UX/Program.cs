﻿using Conforyon.Culture;
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
#if NETCOREAPP3_1 || NET6_0 || NET7_0
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MAIN());
        }
    }
}