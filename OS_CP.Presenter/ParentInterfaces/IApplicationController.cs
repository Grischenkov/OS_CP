namespace OS_CP.Presenter
{
    /// <summary>
    /// Parent application controller interface
    /// </summary>
    public interface IApplicationController
    {
        /// <summary>
        /// Registering view
        /// </summary>
        /// <typeparam name="TView"> View interface </typeparam>
        /// <typeparam name="TImplementation"> View </typeparam>
        /// <returns> View </returns>
        IApplicationController RegisterView<TView, TImplementation>() where TImplementation : class, TView where TView : IView;

        /// <summary>
        /// Registering instance
        /// </summary>
        /// <typeparam name="TArgument"></typeparam>
        /// <param name="instance"> Application context </param>
        /// <returns> Instance </returns>
        IApplicationController RegisterInstance<TArgument>(TArgument instance);

        /// <summary>
        /// Form launching through presenter 
        /// </summary>
        /// <typeparam name="TPresenter"> View presenter </typeparam>
        void Run<TPresenter>() where TPresenter : class, IPresenter;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TPresenter"></typeparam>
        /// <typeparam name="TArg1"></typeparam>
        /// <typeparam name="TArg2"></typeparam>
        /// <param name="argument1"></param>
        /// <param name="argument2"></param>
        void Run<TPresenter, TArg1, TArg2>(TArg1 argument1, TArg2 argument2) where TPresenter : class, IPresenter<TArg1, TArg2>;
    }
}