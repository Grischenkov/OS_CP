namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific presenter interface for Help view
    /// </summary>
    public sealed class HelpPresenter : BasePresenter<IHelpView>
    {
        /// <summary>
        /// Constructor of AboutPresenter class
        /// </summary>
        /// <param name="controller"> Application controller </param>
        /// <param name="view"> View </param>
        public HelpPresenter(IApplicationController controller, IHelpView view) : base(controller, view)
        {
        }
    }
}