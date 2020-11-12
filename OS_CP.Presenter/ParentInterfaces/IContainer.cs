namespace OS_CP.Presenter
{
    /// <summary>
    /// Parent container interface for Adapter
    /// </summary>
    public interface IContainer
    {
        /// <summary>
        /// Register view
        /// </summary>
        /// <typeparam name="TArgument"> View interface </typeparam>
        /// <typeparam name="TImplementation"> Implementation of interface </typeparam>
        void Register<TArgument, TImplementation>() where TImplementation : TArgument;

        /// <summary>
        /// Register presenter
        /// </summary>
        /// <typeparam name="TArgument"> View presenter </typeparam>
        void Register<TArgument>();

        /// <summary>
        /// Register instance
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance"> Application context </param>
        void RegisterInstance<T>(T instance);

        /// <summary>
        /// Resolving
        /// </summary>
        /// <typeparam name="TArgument"> View presenter </typeparam>
        /// <returns> Instance </returns>
        TArgument Resolve<TArgument>();

        /// <summary>
        /// Checking registration
        /// </summary>
        /// <typeparam name="TArgument"> View presenter </typeparam>
        /// <returns> Is registered </returns>
        bool IsRegistered<TArgument>();
    }
}