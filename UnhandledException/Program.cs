using System;
using System.Threading;
using System.Windows.Forms;

namespace UnhandledException
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;


            new App().Run();
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            const string description = "Unhandled app domain exception";
            var str = $"Unhandled: {description}; {e.ExceptionObject}";
            MessageBox.Show(str);
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            const string description = "Unhandled thread exception";
            var str = $"Thread: {description}; {e.Exception}";
            MessageBox.Show(str);
        }
    }
}
