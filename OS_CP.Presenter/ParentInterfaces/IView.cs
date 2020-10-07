namespace OS_CP.Presenter
{
    /// <summary>
    /// Parent view interface for specific form interfaces
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Showing form
        /// </summary>
        void Show();

        /// <summary>
        /// Closing form
        /// </summary>
        void Close();
    }
}