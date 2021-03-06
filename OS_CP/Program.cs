﻿using OS_CP.Presenter;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_CP
{
    /// <summary>
    /// The main class of program
    /// </summary>
    internal static class Program
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
                .RegisterView<ISaveView, SaveView>()
                .RegisterView<IAboutView, AboutView>()
                .RegisterView<ISplashView, SplashView>()
                .RegisterView<ISettingsView, SettingsView>()
                .RegisterView<IProcessView, ProcessView>()
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
