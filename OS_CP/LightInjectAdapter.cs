using LightInject;
using OS_CP.Presenter;

namespace OS_CP
{
    /// <summary>
    /// Class of program for adapting LightInject library for application controller 
    /// </summary>
    public sealed class LightInjectAdapter : IContainer
    {
        private readonly ServiceContainer _container = new ServiceContainer(); //Object of IContainer interface

        /// <summary>
        /// Register view 
        /// </summary>
        /// <typeparam name="TArgument"> typeof argument </typeparam>
        /// <typeparam name="TImplementation"> implementation of interface </typeparam>
        public void Register<TArgument, TImplementation>() where TImplementation : TArgument
        {
            _container.Register<TArgument, TImplementation>();
        }

        /// <summary>
        /// Register presenter 
        /// </summary>
        /// <typeparam name="TArgument"> typeof argument </typeparam>
        public void Register<TArgument>()
        {
            _container.Register<TArgument>();
        }

        /// <summary>
        /// Register instance 
        /// </summary>
        /// <typeparam name="T"> typeof </typeparam>
        /// <param name="instance"> instance </param>
        public void RegisterInstance<T>(T instance)
        {
            _container.RegisterInstance(instance);
        }

        /// <summary>
        /// Resolving 
        /// </summary>
        /// <typeparam name="TArgument"> typeof argument </typeparam>
        /// <returns> instance </returns>
        public TArgument Resolve<TArgument>()
        {
            return _container.GetInstance<TArgument>();
        }

        /// <summary>
        /// Checking registration 
        /// </summary>
        /// <typeparam name="TArgument"> typeof argument </typeparam>
        /// <returns> is registered </returns>
        public bool IsRegistered<TArgument>()
        {
            return _container.CanGetInstance(typeof(TArgument), string.Empty);
        }
    }
}