using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Zografou.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Add the <see cref="TestingDataDirectoryNameConvention"/> implementation of <see cref="ITestingDataDirectoryNameConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultTestingDataDirectoryNameConvention(this IServiceCollection services)
        {
            services.AddSingleton<ITestingDataDirectoryNameConvention, TestingDataDirectoryNameConvention>();

            return services;
        }

        /// <summary>
        /// Add the <see cref="TestingDataDirectoryNameConvention"/> implementation of <see cref="ITestingDataDirectoryNameConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<ITestingDataDirectoryNameConvention> AddDefaultTestingDataDirectoryNameConventionAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ITestingDataDirectoryNameConvention>(() => services.AddDefaultTestingDataDirectoryNameConvention());
            return serviceAction;
        }
    }
}
