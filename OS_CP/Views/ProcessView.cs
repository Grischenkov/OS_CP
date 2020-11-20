using OS_CP.Presenter;
using System.Windows.Forms;

namespace OS_CP
{
    public partial class ProcessView : Form, IProcessView
    {
        public ProcessView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Showing splash screen
        /// </summary>
        public new void Show()
        {
            ShowDialog();
        }
    }
}
