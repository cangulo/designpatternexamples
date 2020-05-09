
namespace FactoryAndStrategyByVersionAutofac.Validators
{
    public class ValidatorV3 : IValidator
    {
        public int GetVersion()
        {
            return 3;
        }

        public bool Validate(string value)
        {
            return value != "hello";
        }
    }
}
