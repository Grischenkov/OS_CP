namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific presenter interface for Splash view
    /// </summary>
    public sealed class SavePresenter : BasePresenter<ISaveView>
    {
        /// <summary>
        /// Constructor of SplashPresenter class
        /// </summary>
        /// <param name="controller"> Application controller </param>
        /// <param name="view"> View </param>
        public SavePresenter(IApplicationController controller, ISaveView view) : base(controller, view)
        {
        }
    }
}
