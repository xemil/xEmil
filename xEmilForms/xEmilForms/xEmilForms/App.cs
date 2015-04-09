using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using xEmilForms.Pages;
using xEmilForms.ViewModel;
using XLabs.Forms.Mvvm;
using XLabs.Forms.Services;
using XLabs.Ioc;
using XLabs.Platform.Mvvm;

namespace xEmilForms
{
    public class App : Application
    {

        static NavigationPage _navigationPage;
        
        public App()
        {
            // The root page of your application
            Init();
            RegisterAllVm();
            var mainPage = GetMainPage();
            _navigationPage = new NavigationPage(mainPage);
            MainPage = _navigationPage;
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
            var loginPage = ViewFactory.CreatePage<LoginViewModel, Page>() as Page;
            return new FBLoginPage();
        }

        private void RegisterAllVm()
        {
            //ViewFactory.Register<RedditPostPage, RedditPostViewModel>();
            ViewFactory.Register<ButtonPage, ButtonPageViewModel>();
            ViewFactory.Register<LoginPage, LoginViewModel>();
            ViewFactory.Register<FacebookPage, FacebookViewModel>();
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

        public static Action GoToPageAfterAuthAction 
        {
            get
            {
                var newPage = ViewFactory.CreatePage<FacebookViewModel, Page>() as Page; 
                return new Action(() => _navigationPage.PushAsync(newPage));
            }
            
        }
    }
    
}
