namespace OS_CP.Presenter
{
    /// <summary>
    /// Parent presenter interface for specific form interfaces
    /// </summary>
    public interface IPresenter
    {
        /// <summary>
        /// Running form
        /// </summary>
        void Run();

        /// <summary>
        /// Exiting program
        /// </summary>
        void Exit();
    }
}