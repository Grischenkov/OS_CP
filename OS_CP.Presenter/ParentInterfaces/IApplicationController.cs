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
    }
}