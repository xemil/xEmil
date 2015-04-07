using System;
using System.Json;
using System.Threading.Tasks;
using Android.App;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using xEmilForms.Droid.Render;
using xEmilForms.Pages;

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
                scope: "",
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
                var prop = ee.Account.Properties.Values;

                var tee = 1;

            };
        }
    }
}