using FactoryAndStrategyAutofac.ILoginProcess;

namespace FactoryAndStrategyAutofac
{
    public interface ILoginService
    {
        bool Login(string username, string password);
        LoginProvidersEnum GetProviderType();
    }
}
