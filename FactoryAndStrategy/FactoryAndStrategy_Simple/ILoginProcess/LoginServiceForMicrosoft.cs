using System;

namespace FactoryAndStrategy.ILoginProcess
{
    public class LoginServiceForMicrosoft : ILoginService
    {
        public bool Login(string username, string password)
        {
            Console.WriteLine("LoginServiceForMicrosoft");
            return true;
        }
    }
}
