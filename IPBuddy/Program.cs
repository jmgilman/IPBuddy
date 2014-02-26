using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Diagnostics;

namespace IPBuddy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Logger.Initialize();

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                if (ApplicationDeployment.CurrentDeployment.IsFirstRun)
                {
                    DialogResult dialogResult = MessageBox.Show("Would you like to view the changelog for the new version of IPBuddy?", "Update", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Process.Start("IExplore.exe", "http://www.joshmgilman.com/IPBuddy/changelog.htm");
                    }
                }
            }

            if (!AppDomain.CurrentDomain.FriendlyName.EndsWith("vshost.exe"))
            {
                Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Logger.CatchThread);
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(Logger.CatchUnhandled);
            }

            try
            {
                Logger.WriteMessage("Application initialized.");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            }
            catch (Exception e)
            {
                Logger.WriteMessage("Exception caught in Main thread");
                Logger.WriteException(e);
                Logger.PromptLogReview();
            }
        }
    }
}
