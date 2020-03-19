using Autofac;
using FactoryAndStrategyAutofac.ILoginProcess;
using System;
using System.Linq;

namespace FactoryAndStrategyAutofac
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var scope = CompositionRoot().BeginLifetimeScope())
            {
                string username = "ChuckNorris";
                string password = "https://chucknorris.com";
                LoginProvidersEnum currentProvider = LoginProvidersEnum.Facebook;

                var loginProvider = scope.Resolve<ILoginProcessFactory>().GetLoginProvider(currentProvider);

                var loginResult = loginProvider.Login(username, password);

                if (loginResult)
                    Console.WriteLine("Login Success");
                else
                    Console.WriteLine("Bad Credential");
            }
        }


        /// <summary>
        /// Autofac DI 
        /// </summary>
        /// <returns></returns>
        private static IContainer CompositionRoot()
        {
            var builder = new ContainerBuilder();


            var loginProcessProviders = typeof(Program)
                                            .Assembly
                                            .GetTypes()
                                            .Where(x =>
                                                x.IsClass &&
                                                x.GetInterfaces().Any(x => x == typeof(ILoginService)))
                                            .Select(x => (ILoginService)x);

            builder.Register(c => new LoginProcessFactory(loginProcessProviders)).As<ILoginProcessFactory>();


            return builder.Build();
        }
    }
}
