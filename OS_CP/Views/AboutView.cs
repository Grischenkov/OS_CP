using OS_CP.Presenter;
using System.Windows.Forms;

namespace OS_CP
{
    /// <summary>
    /// Class of program for work with about screen
    /// </summary>
    public sealed partial class AboutView : Form, IAboutView
    {
        /// <summary>
        /// Base constructor
        /// </summary>
        public AboutView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Showing about screen
        /// </summary>
        public new void Show()
        {
            ShowDialog();
        }
    }
}
