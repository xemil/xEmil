using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using xEmilForms.Cell;
using xEmilForms.Helpers;
using xEmilForms.Helpers.JSON;
using xEmilForms.Model;
using xEmilForms.Services;
using XLabs.Forms.Controls;
using XLabs.Ioc;
using XLabs.Platform.Services;
using XLabs.Serialization;
using XLabs.Serialization.JsonNET;
using XLabs.Web;

namespace xEmilForms.ViewModel
{
    class FacebookViewModel : XLabs.Forms.Mvvm.ViewModel
    {
        private string _token;

        private Boolean _isLoading;
        public Boolean IsLoading
        {
            get { return _isLoading; }
            set { SetProperty(ref _isLoading, value); }
        }

        //private JsonRestClient _jsonRestClient;

        public FacebookViewModel()
        {
            //_jsonRestClient = new JsonRestClient(new JsonSerializer());
            //var secureStorage = Resolver.Resolve<ISecureStorage>();
            //_token = ByteArrayConverter.GetString(secureStorage.Retrieve("fbToken"));
            System.Diagnostics.Debug.WriteLine("VIEWMODEL INITIATED");
        }

        private FacebookUser _loggedinFacebookUser;
        public FacebookUser LoggedinFacebookUser
        {
            get { return _loggedinFacebookUser ?? (_loggedinFacebookUser = GetLoggedInFbUser().Result); }
            set { SetProperty(ref _loggedinFacebookUser, value); }
        }

        public SearchBar SearchBar = new SearchBar()
        {

        };

        private async Task<FacebookUser> GetLoggedInFbUser()
        {
            IsLoading = true;
            var fbUser = new FacebookUser()
            {
                ProfileImage = new Image()
                {
                    Source = "icon.png"
                }
            };
            var fbService = Resolver.Resolve<IFacebookService>();
            fbService.SetLoggedInFacebookUserTask(fbUser).Start();
            fbService.SetProfilePictureTask(fbUser).Start();
            fbService.SetFriendListTask(fbUser).Start();
            IsLoading = false;
            return fbUser;
        }

    }
}
