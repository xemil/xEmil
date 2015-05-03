using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using xEmilForms.Pages;
using xEmilForms.ViewModel;
using XLabs.Forms.Mvvm;
using XLabs.Forms.Services;
using XLabs.Ioc;
using XLabs.Platform.Mvvm;
using XLabs.Platform.Services;

namespace xEmilForms
{
    public class App : Application
    {
        static NavigationPage _navigationPage;
        public App()
        {
            Init();
            RegisterAllVm();
            //FIX NAVIGATIONPAGE
            var mainPage = GetMainPage();
            _navigationPage = new NavigationPage(mainPage);
            Resolver.Resolve<IDependencyContainer>()
            .Register<INavigationService>(t => new NavigationService(mainPage.Navigation));
            NavigationPage.SetHasNavigationBar(mainPage, false);
            MainPage = _navigationPage;

            //SKIP INITIAL FACE
            //GoToFBPage();

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
            var buttonPage = ViewFactory.CreatePage<ButtonPageViewModel, Page>() as Page;
            var startPage = ViewFactory.CreatePage<StartPageViewModel, Page>() as Page;
            var fbPage = ViewFactory.CreatePage<FacebookViewModel, Page>() as Page;
            var rootPage = new RootPage();

            return startPage;
        }

        private void RegisterAllVm()
        {
            //ViewFactory.Register<RedditPostPage, RedditPostViewModel>();
            ViewFactory.Register<ButtonPage, ButtonPageViewModel>();
            ViewFactory.Register<LoginPage, LoginViewModel>();
            ViewFactory.Register<FacebookPage, FacebookViewModel>();
            ViewFactory.Register<StartPage, StartPageViewModel>();
            ViewFactory.Register<FBLoginPage, FBLoginPageViewModel>();
            ViewFactory.Register<LoadingScreenPage, LoadingScreenViewModel>();
            ViewFactory.Register<SelectedUserPage, SelectedUserViewModel>();

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

        public static Action GoToLoadingScreen()
        {

            var newPage = ViewFactory.CreatePage<LoadingScreenViewModel, Page>() as Page;
            return () => _navigationPage.PushAsync(newPage);

        }

        public static Action GoToAuthAction()
        {

            var authPage = new FBLoginPage();
            NavigationPage.SetHasNavigationBar(authPage, false);
            return () => _navigationPage.PushAsync(authPage);

        }

        public static void GoToFBPage()
        {
            var newPage = new RootPage();
            Resolver.Resolve<IDependencyContainer>()
            .Register<INavigationService>(t => new NavigationService(newPage.Navigation));
            Current.MainPage = newPage;
        }
    }

}
