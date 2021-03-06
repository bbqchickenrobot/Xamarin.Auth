﻿using Xamarin.Auth;
using Xamarin.Auth.Presenters;

namespace Xamarin.Auth.Presenters.Windows81Universal
{
    public static class AuthenticationConfiguration
    {
        public static void Init()
        {
            OAuthLoginPresenter.PlatformLogin = (authenticator) =>
            {
                var oauthLogin = new PlatformOAuthLoginPresenter();
                oauthLogin.Login(authenticator);
            };
        }
    }
}