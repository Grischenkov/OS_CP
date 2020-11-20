namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific presenter interface for Splash view
    /// </summary>
    public sealed class ProcessPresenter : BasePresenter<IProcessView>
    {
        /// <summary>
        /// Constructor of SplashPresenter class
        /// </summary>
        /// <param name="controller"> Application controller </param>
        /// <param name="view"> View </param>
        public ProcessPresenter(IApplicationController controller, IProcessView view) : base(controller, view)
        {
        }
    }
}
