using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using xEmilForms.Helpers;
using xEmilForms.Helpers.JSON;
using xEmilForms.Model;
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

        private JsonRestClient _jsonRestClient;

        public FacebookViewModel()
        {
            _jsonRestClient = new JsonRestClient(new JsonSerializer());
            var secureStorage = Resolver.Resolve<ISecureStorage>();
            _token = ByteArrayConverter.GetString(secureStorage.Retrieve("fbToken"));
            System.Diagnostics.Debug.WriteLine("VIEWMODEL INITIATED");
        }

        private FacebookUser _loggedinFacebookUser;
        public FacebookUser LoggedinFacebookUser
        {
            get { return _loggedinFacebookUser ?? (_loggedinFacebookUser = GetLoggedInFbUser().Result); }
            set { SetProperty(ref _loggedinFacebookUser, value); }
        }

        private Task LoadLoggedInFbUser()
        {
            var query = "https://graph.facebook.com/me?access_token=" + _token;
            System.Diagnostics.Debug.WriteLine("STARTING REST CALL1");
            var getMeUser = _jsonRestClient.GetAsync<FacebookMeResponse>(query);
            System.Diagnostics.Debug.WriteLine("Out Of first rest");
            System.Diagnostics.Debug.WriteLine("LOADLOGGEDINFBUSER RETURNING");
            getMeUser.ContinueWith(task =>
            {
                LoggedinFacebookUser.FirstName = task.Result.first_name;
                LoggedinFacebookUser.LastName = task.Result.last_name;
                LoggedinFacebookUser.Gender = task.Result.gender;
                LoggedinFacebookUser.Id = task.Result.id;
                LoggedinFacebookUser.Link = task.Result.link;
                LoggedinFacebookUser.Name = task.Result.name;
            });
            return getMeUser;
        }
        private Task LoadProfilePicture()
        {
        https://graph.facebook.com/786311666
            //ÁCCESSTOKEN NOT WORKING 2 time
            var query2 = "https://graph.facebook.com/786311666/picture?width=200";
            //var query = "https://graph.facebook.com/me/picture?width=200&?access_token=" + _token;
            var getProfilePic = _jsonRestClient.GetAsync<RootObject>(query2);
            getProfilePic.ContinueWith(task =>
            {

                if (!task.IsFaulted)
                {
                    LoggedinFacebookUser.ProfileImage = new WebImage()
                    {
                        ImageUrl = task.Result.data.FirstOrDefault().url
                    };
                }
            });
            return getProfilePic;
        }
        private async Task<FacebookUser> GetLoggedInFbUser()
        {
            IsLoading = true;
            var fbUser = LoadLoggedInFbUser();
            var profilePic = LoadProfilePicture();
            IsLoading = false;
            return new FacebookUser();
        }
        
    }
}
