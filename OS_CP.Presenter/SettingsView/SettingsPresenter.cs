namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific presenter interface for Settings view
    /// </summary>
    public sealed class SettingsPresenter : BasePresenter<ISettingsView>
    {
        /// <summary>
        /// Constructor of SettingsPresenter class
        /// </summary>
        /// <param name="controller"> Application controller </param>
        /// <param name="view"> View </param>
        public SettingsPresenter(IApplicationController controller, ISettingsView view) : base(controller, view)
        {
            View.LoadShowing += LoadShowing;
            View.VideoShowing += VideoShowing;
            View.SelectExport += SelectExport;
            View.SelectInterpolation += SelectInterpolation;
        }

        /// <summary>
        /// Change load settings
        /// </summary>
        private void LoadShowing()
        {
            //TODO
        }

        /// <summary>
        /// Change video settings
        /// </summary>
        private void VideoShowing()
        {
            //TODO
        }

        /// <summary>
        /// Load export type DLL
        /// </summary>
        private void SelectExport()
        {
            //TODO
        }

        /// <summary>
        /// Load interpolation type DLL
        /// </summary>
        private void SelectInterpolation()
        {
            //TODO
        }
    }
}