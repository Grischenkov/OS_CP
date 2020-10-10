using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                .RegisterView<IMainView, MainView>()
                .RegisterView<IAboutView, AboutView>()
                .RegisterView<IHelpView, HelpView>()
                .RegisterInstance(new ApplicationContext());

            //Starting program
            controller.Run<MainPresenter>();
        }
    }
}
