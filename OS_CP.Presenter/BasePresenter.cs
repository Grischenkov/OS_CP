namespace OS_CP.Presenter
{
    /// <summary>
    /// Base Presenter abstract class for specific presenters
    /// </summary>
    public abstract class BasePresenter<TView> : IPresenter where TView : IView
    {
        /// <summary>
        /// Getting View
        /// </summary>
        protected TView View { get; }

        /// <summary>
        /// Getting controller
        /// </summary>
        protected IApplicationController Controller { get; }

        /// <summary>
        /// Base constructor of class
        /// </summary>
        protected BasePresenter()
        {

        }

        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="controller"> Application controller </param>
        /// <param name="view"> View </param>
        protected BasePresenter(IApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        /// <summary>
        /// Showing form
        /// </summary>
        public void Run()
        {
            View.Show();
        }

        /// <summary>
        /// Exiting program
        /// </summary>
        public void Exit()
        {
            View.Close();
        }
    }

    public abstract class BasePresenter<TView, TArg> : IPresenter<TArg> where TView : IView
    {
        /// <summary>
        /// 
        /// </summary>
        protected TView View { get; }

        /// <summary>
        /// 
        /// </summary>
        protected IApplicationController Controller { get; }

        /// <summary>
        /// Base constructor of class
        /// </summary>
        protected BasePresenter()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="view"></param>
        protected BasePresenter(IApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argument"></param>
        public abstract void Run(TArg argument);
    }
}
