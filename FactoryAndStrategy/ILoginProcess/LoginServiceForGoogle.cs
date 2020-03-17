using System;

namespace FactoryAndStrategy.ILoginProcess
{
    public class LoginServiceForGoogle : ILoginService
    {
        public bool Login(string username, string password)
        {
            Console.WriteLine("LoginServiceForGoogle");
            return true;
        }
    }
}
