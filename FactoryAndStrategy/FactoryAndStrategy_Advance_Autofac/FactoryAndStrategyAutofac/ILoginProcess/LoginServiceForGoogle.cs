using System;

namespace FactoryAndStrategyAutofac.ILoginProcess
{
    public class LoginServiceForGoogle : ILoginService
    {
        public LoginProvidersEnum GetProviderType()
        {
            return LoginProvidersEnum.Google;
        }

        public bool Login(string username, string password)
        {
            Console.WriteLine("LoginServiceForGoogle");
            return true;
        }
    }
}
