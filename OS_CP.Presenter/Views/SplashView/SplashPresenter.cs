namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific presenter interface for Splash view
    /// </summary>
    public sealed class SplashPresenter : BasePresenter<ISplashView>
    {
        /// <summary>
        /// Constructor of SplashPresenter class
        /// </summary>
        /// <param name="controller"> Application controller </param>
        /// <param name="view"> View </param>
        public SplashPresenter(IApplicationController controller, ISplashView view) : base(controller, view)
        {
        }
    }
}
