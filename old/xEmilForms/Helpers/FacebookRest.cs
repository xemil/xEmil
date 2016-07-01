using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XLabs.Ioc;
using XLabs.Platform.Services;
using XLabs.Serialization.JsonNET;
using XLabs.Web;

namespace xEmilForms.Helpers
{
    class FacebookRest
    {
        private JsonRestClient _restClient;
        private ISecureStorage _secureStorage;
        private string _token;

        public FacebookRest()
        {
            _restClient = new JsonRestClient(new JsonSerializer());
            _secureStorage = Resolver.Resolve<ISecureStorage>();
            _token = ByteArrayConverter.GetString(_secureStorage.Retrieve("fbToken"));
        }


        public async Task<FacebookUser> LoggedInUser()
        {
            const string stringQuery2 = "https://graph.facebook.com/btaylor";
                            return await _restClient.GetAsync<FacebookUser>(stringQuery2);

        }
    }
}
