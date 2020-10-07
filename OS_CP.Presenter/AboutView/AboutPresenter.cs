namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific presenter interface for About view
    /// </summary>
    public sealed class AboutPresenter : BasePresenter<IAboutView>
    {
        /// <summary>
        /// Constructor of AboutPresenter class
        /// </summary>
        /// <param name="controller"> Application controller </param>
        /// <param name="view"> View </param>
        public AboutPresenter(IApplicationController controller, IAboutView view) : base(controller, view)
        {
        }
    }
}