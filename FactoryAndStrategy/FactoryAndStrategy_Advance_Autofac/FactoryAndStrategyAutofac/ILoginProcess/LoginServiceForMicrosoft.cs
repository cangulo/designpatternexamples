using System;

namespace FactoryAndStrategyAutofac.ILoginProcess
{
    public class LoginServiceForMicrosoft : ILoginService
    {
        public LoginProvidersEnum GetProviderType()
        {
            return LoginProvidersEnum.Microsoft;
        }

        public bool Login(string username, string password)
        {
            Console.WriteLine("LoginServiceForMicrosoft");
            return true;
        }
    }
}
