using FactoryAndStrategyAutofac.ILoginProcess;
using System.Collections.Generic;
using System.Linq;

namespace FactoryAndStrategyAutofac
{
    public class LoginProcessFactory : ILoginProcessFactory
    {
        private IEnumerable<ILoginService> _loginProcess;

        public LoginProcessFactory(IEnumerable<ILoginService> loginProcess)
        {
            _loginProcess = loginProcess;
        }

        public ILoginService GetLoginProvider(LoginProvidersEnum providerRequired)
        {
            return _loginProcess.First(x => x.GetProviderType() == providerRequired);
        }
    }
}
