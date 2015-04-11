using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using xEmilForms.Droid.Render;
using xEmilForms.Pages;
using XLabs.Forms.Mvvm;
using XLabs.Forms.Services;
using XLabs.Ioc;
using XLabs.Platform;
using XLabs.Platform.Mvvm;
using XLabs.Platform.Services;

[assembly: ExportRenderer(typeof(FBLoginPage), typeof(FBPageRenderer))]

namespace xEmilForms.Droid.Render
{
   
    class FBPageRenderer : PageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
             var auth = new OAuth2Authenticator(
                clientId: "428095124009332",
                scope: "email, user_friends",
                authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
                redirectUrl: new Uri("http://www.facebook.com/connect/login_success.html")
                );


            var intent = auth.GetUI(this.Context);
            var activity = this.Context as Activity;
            activity.StartActivity(intent);
            //LISTEN FOR AUTH
            auth.Completed += (s, ee) =>
            {
                if (!ee.IsAuthenticated)
                {
                    var builder = new AlertDialog.Builder(this.Context);
                    builder.SetMessage("Not Authenticated");
                    builder.SetPositiveButton("Ok", (o, p) => { });
                    builder.Create().Show();
                    return;
                }
                var prop = ee.Account.Properties;
                string fbToken = "";
                if (prop.TryGetValue("access_token", out fbToken))
                {
                    var secureStorage = Resolver.Resolve<ISecureStorage>();
                    byte[] bytes = new byte[fbToken.Length*sizeof (char)];
                    System.Buffer.BlockCopy(fbToken.ToCharArray(), 0, bytes, 0, bytes.Length);
                    secureStorage.Store("fbToken", bytes);
                }
                System.Diagnostics.Debug.WriteLine("STARTING SLEEP THREAD");
                System.Diagnostics.Debug.WriteLine("Completed SLEEP THREAD");
                
                App.GoToFBPage().Invoke();


            };
            
        }
    }
}