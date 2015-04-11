using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xEmilForms.Helpers;
using xEmilForms.Helpers.JSON;
using XLabs.Forms.Controls;
using XLabs.Serialization.JsonNET;
using XLabs.Web;

namespace xEmilForms.Services
{
    class FacebookRestService : IFacebookService
    {
        JsonRestClient _jsonRestClient = new JsonRestClient(new JsonSerializer());
        private string _token;

        public FacebookRestService(string authToken)
        {
            _token = authToken;
        }
        public Task SetLoggedInFacebookUserTask(FacebookUser fbUser)
        {
            var query = "https://graph.facebook.com/me?access_token=" + _token;
            System.Diagnostics.Debug.WriteLine("STARTING REST CALL1");
            var getMeUser = _jsonRestClient.GetAsync<FacebookMeResponse>(query);
            System.Diagnostics.Debug.WriteLine("Out Of first rest");
            System.Diagnostics.Debug.WriteLine("LOADLOGGEDINFBUSER RETURNING");
            getMeUser.ContinueWith(task =>
            {
                if (!task.IsFaulted)
                {
                    fbUser.Id = task.Result.id;
                    fbUser.LastName = task.Result.last_name;
                    fbUser.FirstName = task.Result.first_name;
                    fbUser.Gender = task.Result.gender;
                    fbUser.Link = task.Result.link;
                    fbUser.Locale = task.Result.last_name;
                    fbUser.Name = task.Result.name;
                }
            });
            return getMeUser;
        }

        public Task SetProfilePictureTask(FacebookUser fbUser)
        {
            //ÁCCESSTOKEN NOT WORKING 2 time
            var query2 = "https://graph.facebook.com/786311666/picture?width=200";
            //var query = "https://graph.facebook.com/me/picture?width=200&?access_token=" + _token;

            //ROOTOBJECT NOT WORKING
            var getProfilePic = _jsonRestClient.GetAsync<RootObject>(query2);
            getProfilePic.ContinueWith(task =>
            {

                if (!task.IsFaulted)
                {
                    fbUser.ProfileImage = new WebImage()
                    {
                        ImageUrl = task.Result.data.FirstOrDefault().url
                    };
                }
            });
            return getProfilePic;
        }
    }
}
