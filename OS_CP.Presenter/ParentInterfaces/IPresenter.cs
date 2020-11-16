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
    /// <typeparam name="TArg1"></typeparam>
    /// <typeparam name="TArg2"></typeparam>
    public interface IPresenter<in TArg1, in TArg2>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="argument1"></param>
        /// <param name="argument2"></param>
        void Run(TArg1 argument1, TArg2 argument2);
    }
}