using System;

namespace FactoryAndStrategy.ILoginProcess
{
    public class LoginServiceForFacebook : ILoginService
    {
        public bool Login(string username, string password)
        {
            Console.WriteLine("LoginServiceForFacebook");
            return true;
        }
    }
}
