using System;

namespace FactoryAndStrategyAutofac.ILoginProcess
{
    public class LoginServiceForFacebook : ILoginService
    {
        public LoginProvidersEnum GetProviderType()
        {
            return LoginProvidersEnum.Facebook;
        }

        public bool Login(string username, string password)
        {
            Console.WriteLine("LoginServiceForFacebook");
            return true;
        }
    }
}
