using Autofac;
using FactoryAndStrategyByVersionAutofac.Validators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryAndStrategyAutofac
{
    public class Program
    {

        static void Main(string[] args)
        {
            using (var scope = CompositionRoot().BeginLifetimeScope())
            {
                string requestToValidate = "testContent";
                var version = 1;

                var validators = scope.Resolve<IValidatorsByVersionFactory>().GetValidators(version);

                Console.WriteLine($"Request version ${version} - Validators found ${validators.Count()}");
                var result = validators.Any(x => !x.Validate(requestToValidate));
                Console.WriteLine($"request is valid : ${result.ToString()}");


                requestToValidate = null;
                version = 2;
                validators = scope.Resolve<IValidatorsByVersionFactory>().GetValidators(version);

                Console.WriteLine($"Request version ${version} - Validators found ${validators.Count()}");
                result = validators.Any(x => !x.Validate(requestToValidate));
                Console.WriteLine($"request is valid : ${result.ToString()}");


                requestToValidate = null;
                version = 2;
                validators = scope.Resolve<IValidatorsByVersionFactory>().GetValidators(version);

                Console.WriteLine($"Request version ${version} - Validators found ${validators.Count()}");
                result = validators.Any(x => !x.Validate(requestToValidate));
                Console.WriteLine($"request is valid : ${result.ToString()}");
            }
        }


        /// <summary>
        /// Autofac DI 
        /// </summary>
        /// <returns></returns>
        private static IContainer CompositionRoot()
        {
            var builder = new ContainerBuilder();


            var validators = typeof(Program)
                                            .Assembly
                                            .GetTypes()
                                            .Where(x =>
                                                x.IsClass &&
                                                x.GetInterfaces().Any(x => x == typeof(IValidator)))
                                            .ToArray();
            builder
                .RegisterTypes(validators)
                .AsImplementedInterfaces();

            builder
                .Register(c =>
                    new ValidatorFactory(c.Resolve<IEnumerable<IValidator>>()))
                .As<IValidatorsByVersionFactory>();


            return builder.Build();
        }
    }
}
