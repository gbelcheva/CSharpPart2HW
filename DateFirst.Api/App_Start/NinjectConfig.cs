namespace DateFirst.Api
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Reflection;

    using Data.Repositories;
    using Infrastructure;
    using Ninject;

    public static class NinjectConfig
    {
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Reviewed. Needed for Ninject.")]
        public static Lazy<IKernel> CreateKernel = new Lazy<IKernel>(() =>
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            RegisterServices(kernel);

            return kernel;
        });

        /// <summary>
        /// Required for integration testing (for mocking, or more specifically, for replacing)
        /// </summary>
        public static Action<IKernel> ResolveDependencies = kernel =>
        {
            kernel.Bind<IDateFirstData>().To<DateFirstData>();
            kernel.Bind<IIdentityProvider>().To<AspNetIdentityProvider>();
        };

        private static void RegisterServices(KernelBase kernel)
        {
            ResolveDependencies(kernel);
        }
    }
}