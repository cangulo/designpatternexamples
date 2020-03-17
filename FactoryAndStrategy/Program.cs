using FactoryAndStrategy.ILoginProcess;
using System;

namespace FactoryAndStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "ChuckNorris";
            string password = "https://chucknorris.com";
            LoginProvidersEnum currentProvider = LoginProvidersEnum.Facebook;

            var loginProvider = (new LoginProcessFactory()).GetLoginProvider(currentProvider);

            var loginResult = loginProvider.Login(username, password);

            if (loginResult)
                Console.WriteLine("Login Success");
            else
                Console.WriteLine("Bad Credential");
        }
    }
}
