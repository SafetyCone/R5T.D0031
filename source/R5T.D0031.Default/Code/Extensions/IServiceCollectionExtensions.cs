using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0031.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="StaticValuedOutputFilePathProvider"/> implementation of <see cref="IOutputFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddStaticValuedOutputFilePathProvider(this IServiceCollection services)
        {
            services.AddSingleton<IOutputFilePathProvider, StaticValuedOutputFilePathProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="StaticValuedOutputFilePathProvider"/> implementation of <see cref="IOutputFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOutputFilePathProvider> AddStaticValuedOutputFilePathProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IOutputFilePathProvider>(() => services.AddStaticValuedOutputFilePathProvider());
            return serviceAction;
        }
    }
}
