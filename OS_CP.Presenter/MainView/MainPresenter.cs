namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific presenter interface for Main view
    /// </summary>
    public sealed class MainPresenter : BasePresenter<IMainView>
    {
        private Function _function; //Object of class Function for work with model

        /// <summary>
        /// Constructor of MainPresenter class
        /// </summary>
        /// <param name="controller"> Application controller </param>
        /// <param name="view"> View </param>
        public MainPresenter(IApplicationController controller, IMainView view) : base(controller, view)
        {
            _function = new Function();

            View.Calculate += () => Calculate();
            View.Open += Open;
            View.Save += Save;
            View.Export += Export;
            View.About += About;
            View.Help += Help;
            View.Settings += Settings;
            View.Exit += Exit;
        }

        /// <summary>
        /// Display data
        /// </summary>
        private void Calculate()
        {
            View.FunctionName = GetFunction();
            View.DrawChart();
        }

        /// <summary>
        /// Showing about form
        /// </summary>
        private void Open()
        {
            Controller.Run<OpenPresenter>();
        }

        /// <summary>
        /// Showing about form
        /// </summary>
        private void Save()
        {
            Controller.Run<SavePresenter>();
        }

        /// <summary>
        /// Showing about form
        /// </summary>
        private void Export()
        {
            Controller.Run<ExportPresenter>();
        }

        /// <summary>
        /// Showing about form
        /// </summary>
        private void About()
        {
            Controller.Run<AboutPresenter>();
        }

        /// <summary>
        /// Showing settings form
        /// </summary>
        private void Help()
        {
            Controller.Run<HelpPresenter>();
        }

        /// <summary>
        /// Showing settings form
        /// </summary>
        private void Settings()
        {
            Controller.Run<SettingsPresenter>();
        }
    }
}