
namespace FactoryAndStrategyByVersionAutofac.Validators
{
    public class ValidatorV1 : IValidator
    {
        public int GetVersion()
        {
            return 1;
        }

        public bool Validate(string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}
