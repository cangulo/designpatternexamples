using FactoryAndStrategyAutofac.ILoginProcess;

namespace FactoryAndStrategyAutofac
{
    public interface ILoginProcessFactory
    {
        ILoginService GetLoginProvider(LoginProvidersEnum providerRequired);
    }
}