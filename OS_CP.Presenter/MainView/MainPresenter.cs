namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific presenter interface for Main view
    /// </summary>
    public sealed class MainPresenter : BasePresenter<IMainView>
    {
        /// <summary>
        /// Constructor of MainPresenter class
        /// </summary>
        /// <param name="controller"> Application controller </param>
        /// <param name="view"> View </param>
        public MainPresenter(IApplicationController controller, IMainView view) : base(controller, view)
        {
        }
    }
}