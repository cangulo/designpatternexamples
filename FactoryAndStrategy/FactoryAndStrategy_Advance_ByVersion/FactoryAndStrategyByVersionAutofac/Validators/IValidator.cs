namespace FactoryAndStrategyByVersionAutofac.Validators
{
    public interface IValidator : IVersionHandler
    {
        bool Validate(string value);
    }
}
