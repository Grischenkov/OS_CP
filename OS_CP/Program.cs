using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using OS_CP.Presenter;

namespace OS_CP
{
    /// <summary>
    /// The main class of program
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IApplicationController controller = new ApplicationController(new LightInjectAdapter())
                .RegisterView<IHelpView, HelpView>()
                .RegisterView<IMainView, MainView>()
                .RegisterView<IAboutView, AboutView>()
                .RegisterView<ISplashView, SplashView>()
                .RegisterView<ISettingsView, SettingsView>()
                .RegisterInstance(new ApplicationContext());
            
            //Showing splash if user selected
            if (RegistryFunctions.GetValue(RegistryFunctions.CheckRegistry(Properties.Settings.Default.RegistryPath), "ShowLoad") == "True")
            {
                Task.Run(() => controller.Run<SplashPresenter>());
                Thread.Sleep(5000);
            }

            //Starting program
            controller.Run<MainPresenter>();
        }
    }
}
