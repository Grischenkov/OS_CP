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

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TArg"></typeparam>
    public interface IPresenter<in TArg>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="argument"></param>
        void Run(TArg argument);
    }
}