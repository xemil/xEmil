using System;

using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using xEmilForms.ViewModel;
using XLabs.Caching;
using XLabs.Forms;
using XLabs.Ioc;
using XLabs.Platform.Device;
using XLabs.Platform.Mvvm;
using XLabs.Platform.Services;
using XLabs.Serialization;
using xEmilForms.Services;

namespace xEmilForms.Droid
{
    [Activity(Label = "xEmilForms", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
     public class MainActivity : XFormsApplicationDroid
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            if (!Resolver.IsSet)
            {
                this.SetIoc();
            }
            else
            {
                var app = Resolver.Resolve<IXFormsApp>() as IXFormsApp<XFormsApplicationDroid>;
                app.AppContext = this;
            }


            global::Xamarin.Forms.Forms.Init(this, bundle);
            
            LoadApplication(new App());
        }

        /// <summary>
        /// Sets the IoC.
        /// </summary>
        private void SetIoc()
        {
            var resolverContainer = new SimpleContainer();

            var app = new XFormsAppDroid();

            resolverContainer.Register<IDevice>(t => AndroidDevice.CurrentDevice)
                .Register<IDisplay>(t => t.Resolve<IDevice>().Display)
                //.Register<IJsonSerializer, Services.Serialization.JsonNET.JsonSerializer>()
                .Register<IDependencyContainer>(resolverContainer)
                .Register<ISecureStorage>(t => new KeyVaultStorage(t.Resolve<IDevice>().Id.ToCharArray()))
                .Register<IRedditService>(t => new RedditServiceMocked())
                .Register<IXFormsApp>(app);

            //TODO ADD  IOC for interfaces 
            //.Register<IJsonSerializer, XLabs.Serialization.ServiceStack.JsonSerializer>()    
            //.Register<ISimpleCache>(
            //        t => new SQLiteSimpleCache(new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid(),
            //            new SQLite.Net.SQLiteConnectionString(pathToDatabase, true), t.Resolve<IJsonSerializer>()));



            Resolver.SetResolver(resolverContainer.GetResolver());
        }
    }
}

