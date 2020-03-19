using FactoryAndStrategy.ILoginProcess;

namespace FactoryAndStrategy
{
    public class LoginProcessFactory
    {
        public ILoginService GetLoginProvider(LoginProvidersEnum provider)
        {
            if (provider == LoginProvidersEnum.Facebook)
                return (new LoginServiceForFacebook());
            else if (provider == LoginProvidersEnum.Google)
                return (new LoginServiceForGoogle());
            else if (provider == LoginProvidersEnum.Microsoft)
                return (new LoginServiceForMicrosoft());
            else
                throw new System.Exception("Provider not supported");
        }
    }
}
