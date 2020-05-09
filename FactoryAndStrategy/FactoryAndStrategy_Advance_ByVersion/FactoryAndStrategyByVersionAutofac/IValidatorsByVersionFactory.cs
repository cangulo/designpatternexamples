using FactoryAndStrategyByVersionAutofac.Validators;
using System.Collections.Generic;

namespace FactoryAndStrategyAutofac
{
    public interface IValidatorsByVersionFactory
    {
        IEnumerable<IValidator> GetValidators(int requestVersion);
    }
}