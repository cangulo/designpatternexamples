
namespace FactoryAndStrategyByVersionAutofac.Validators
{
    public class ValidatorV2 : IValidator
    {
        public int GetVersion()
        {
            return 2;
        }

        public bool Validate(string value)
        {
            return value != "hola";
        }
    }
}
