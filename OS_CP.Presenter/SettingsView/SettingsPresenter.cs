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
        }
    }
}