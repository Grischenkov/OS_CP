using OS_CP.Presenter;
using System.Threading;
using System.Windows.Forms;

namespace OS_CP
{
    public partial class SplashView : Form, ISplashView
    {
        /// <summary>
        /// Base constructor
        /// </summary>
        public SplashView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Showing splash screen
        /// </summary>
        public new void Show()
        {
            Thread thread = new Thread(Start);
            thread.Start();
            Thread.Sleep(5000);
            thread.Abort();
        }

        /// <summary>
        /// Starting application 
        /// </summary>
        private void Start()
        {
            Application.Run(this);
        }
    }
}
