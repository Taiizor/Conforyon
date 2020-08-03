using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace _53X
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        private static Assembly DLLInject(object sender, ResolveEventArgs args)
        {
            try
            {
                string[] DLL = args.Name.ToString().Split(',');
                string DLLName = "_" + Application.ProductName + ".DLL." + DLL[0] + ".dll";
                Assembly FirstAssembly = Assembly.GetExecutingAssembly();
                Stream AssemblyStream = FirstAssembly.GetManifestResourceStream(DLLName);
                byte[] RAW = new byte[AssemblyStream.Length];
                AssemblyStream.Read(RAW, 0, RAW.Length);
                return Assembly.Load(RAW);
            }
            catch
            {
                //MessageBox.Show("Please, Reporting Error..", "53X BiGBaNG2 Error.!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Assembly.Load("");
            }
        }

        static readonly Mutex Mutex = new Mutex(true, "{" + ((GuidAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(GuidAttribute), false)).Value + "}");

        [STAThread]
        static void Main()
        {

            if (Application.ExecutablePath.EndsWith("/" + Application.ProductName + ".EXE") || Application.ExecutablePath.EndsWith("/" + Application.ProductName + ".exe") || Application.ExecutablePath.EndsWith("\\" + Application.ProductName + ".EXE") || Application.ExecutablePath.EndsWith("\\" + Application.ProductName + ".exe"))
            {
                //Bir Nevi Bilgisayar Bazında Kitliyoruz Burayı
                if (Mutex.WaitOne(TimeSpan.Zero, true))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(DLLInject);
                    Control.CheckForIllegalCrossThreadCalls = false;
                    Application.Run(new Form1());
                    Mutex.ReleaseMutex();
                }
            }
            else
                Application.Exit();
        }
    }
}
