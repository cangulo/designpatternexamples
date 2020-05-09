using FactoryAndStrategyByVersionAutofac.Validators;
using System.Collections.Generic;
using System.Linq;

namespace FactoryAndStrategyAutofac
{
    public class ValidatorFactory : IValidatorsByVersionFactory
    {
        private IEnumerable<IValidator> _validators;

        public ValidatorFactory(IEnumerable<IValidator> validators)
        {
            _validators = validators;
        }

        public IEnumerable<IValidator> GetValidators(int requestVersion)
        {
            return _validators
                        .Where(x => x.GetVersion() <= requestVersion)
                        .OrderBy(x => x.GetVersion());
        }
    }
}
