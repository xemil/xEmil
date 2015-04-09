using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        private Boolean _isLoading;
        public Boolean IsLoading
        {
            get { return _isLoading; }
            set { SetProperty(ref _isLoading, value); }
        }
    
        private JsonRestClient _jsonRestClient;
        public FacebookViewModel()
        {
            IsLoading = true;
            _jsonRestClient = new JsonRestClient(new JsonSerializer());
            var fbUser = LoadLoggedInFbUser();
        }

        private FacebookUser _loggedinFacebookUser;
        public FacebookUser LoggedinFacebookUser
        {
            get
            {
                return _loggedinFacebookUser ?? (_loggedinFacebookUser =

                    new FacebookUser()
                    {
                        FirstName = "Loading",
                        Gender = "null",
                        Id = null,
                        LastName = "Loading",
                        Link = null,
                        Locale = "noLocale",
                        Name = "Loading"

                    }
                    );

            }
            set { SetProperty(ref _loggedinFacebookUser, value); }
        }
        
        private Task<FacebookMeResponse> LoadLoggedInFbUser()
        {
            var secureStorage = Resolver.Resolve<ISecureStorage>();
            var token = ByteArrayConverter.GetString(secureStorage.Retrieve("fbToken"));
            var query = "https://graph.facebook.com/me?access_token=" + token;

            var getMeUser = _jsonRestClient.GetAsync<FacebookMeResponse>(query).ContinueWith(
                task =>
                {
                    if (!task.IsFaulted)
                    {
                        LoggedinFacebookUser = new FacebookUser()
                        {
                            FirstName = task.Result.first_name,
                            LastName = task.Result.last_name,
                            Gender = task.Result.gender,
                            Id = task.Result.id,
                            Link = task.Result.link,
                            Name = task.Result.name,
                            Locale = task.Result.name
                        };
                        return task.Result;
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("REST ERROR LOAD LoggedInFbUser");
                    }
                    return task.Result;
                });
        }

        private FacebookPictureResponse LoadProfilePic(string userId)
        {
                var secureStorage = Resolver.Resolve<ISecureStorage>();
                var token = ByteArrayConverter.GetString(secureStorage.Retrieve("fbToken"));      
                var query = "https://graph.facebook.com/" + userId + "/picture?width=200&access_token=" + token;
                var getProfilePic = _jsonRestClient.GetAsync<FacebookPictureResponse>(query).ContinueWith(task =>
                {
                    if (!task.IsFaulted)
                    {
                        LoggedinFacebookUser.ProfileImage.ImageUrl = task.Result.url;
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("ERROR ON WEB IMAGE");
                    }
                    return task.Result;
                });
            return getProfilePic.Result;
        }





























    }
}
