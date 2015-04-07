using System.Diagnostics;
using Xamarin.Forms;
using xEmilForms.Pages;
using xEmilForms.ViewModel;
using XLabs.Forms.Mvvm;
using XLabs.Ioc;
using XLabs.Platform.Mvvm;

namespace xEmilForms
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            Init();
            RegisterAllVm();
            var mainPage = GetMainPage();
            var navPage = new NavigationPage(mainPage);
            MainPage = navPage;
        }

        public static void Init()
        {
            var app = Resolver.Resolve<IXFormsApp>();
            if (app == null)
            {
                return;
            }
            app.Closing += (o, e) => Debug.WriteLine("Application Closing");
            app.Error += (o, e) => Debug.WriteLine("Application Error");
            app.Initialize += (o, e) => Debug.WriteLine("Application Initialized");
            app.Resumed += (o, e) => Debug.WriteLine("Application Resumed");
            app.Rotation += (o, e) => Debug.WriteLine("Application Rotated");
            app.Startup += (o, e) => Debug.WriteLine("Application Startup");
            app.Suspended += (o, e) => Debug.WriteLine("Application Suspended");
        }

        private Page GetMainPage()
        {
            //var loginPage = ViewFactory.CreatePage<LoginViewModel, Page>() as Page;
            var facebookpage = new FBLoginPage();
            return facebookpage;
        }

        private void RegisterAllVm()
        {
            //ViewFactory.Register<RedditPostPage, RedditPostViewModel>();
            //ViewFactory.Register<ButtonPage, ButtonPageViewModel>();
            ViewFactory.Register<LoginPage, LoginViewModel>();
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}