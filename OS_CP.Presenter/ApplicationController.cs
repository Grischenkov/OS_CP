namespace OS_CP.Presenter
{
    /// <summary>
    /// Class of program for work with Application Controller
    /// </summary>
    public sealed class ApplicationController : IApplicationController
    {
        private readonly IContainer _container; //Object of IContainer interface

        /// <summary>
        /// Constructor of class 
        /// </summary>
        /// <param name="container"> object of IContainer interface </param>

        public ApplicationController(IContainer container)
        {
            _container = container;
            _container.RegisterInstance<IApplicationController>(this);
        }

        /// <summary>
        /// Registering view 
        /// </summary>
        /// <typeparam name="TView"> View interface </typeparam>
        /// <typeparam name="TImplementation"> implementation of View interface </typeparam>
        /// <returns></returns>
        public IApplicationController RegisterView<TView, TImplementation>() where TImplementation : class, TView where TView : IView
        {
            _container.Register<TView, TImplementation>();
            return this;
        }

        /// <summary>
        /// Registering  instance 
        /// </summary>
        /// <typeparam name="TInstance"> typeof instance </typeparam>
        /// <param name="instance"> instance </param>
        /// <returns></returns>
        public IApplicationController RegisterInstance<TInstance>(TInstance instance)
        {
            _container.RegisterInstance(instance);
            return this;
        }

        /// <summary>
        /// Form launching through presenter 
        /// </summary>
        /// <typeparam name="TPresenter"> typeof presenter </typeparam>
        public void Run<TPresenter>() where TPresenter : class, IPresenter
        {
            if (!_container.IsRegistered<TPresenter>())
            {
                _container.Register<TPresenter>();
            }

            TPresenter presenter = _container.Resolve<TPresenter>();
            presenter.Run();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TPresenter"></typeparam>
        /// <typeparam name="TArg1"></typeparam>
        /// <typeparam name="TArg2"></typeparam>
        /// <param name="argument1"></param>
        /// <param name="argument2"></param>
        public void Run<TPresenter, TArg1, TArg2>(TArg1 argument1, TArg2 argument2) where TPresenter : class, IPresenter<TArg1, TArg2>
        {
            if (!_container.IsRegistered<TPresenter>())
                _container.Register<TPresenter>();

            TPresenter presenter = _container.Resolve<TPresenter>();
            presenter.Run(argument1, argument2);
        }
    }
}