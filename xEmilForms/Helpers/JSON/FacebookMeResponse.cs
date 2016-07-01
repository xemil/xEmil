using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xEmilForms.Helpers.JSON
{
    class FacebookMeResponse
    {
        public string id { get; set; }
        public string first_name { get; set; }
        public string gender { get; set; }
        public string last_name { get; set; }
        public Uri link { get; set; }
        public string locale { get; set; }
        public string name { get; set; }

    }
}
