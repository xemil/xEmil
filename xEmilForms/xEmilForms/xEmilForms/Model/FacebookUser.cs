using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XLabs.Data;

namespace xEmilForms.Model
{
    class FacebookUser : ObservableObject
    {
        private string _facebookId;

        public string FacebookId
        {
            get { return _facebookId ?? (_facebookId = "NOT SET"); }
            set { SetProperty(ref _facebookId, value); }

        }

        private string _name;

        public string Name
        {
            get { return _name ?? (_name = "NO NAME SET"); }
            set { SetProperty(ref _name, value); }
        }
        
        public string Token { get; set; }
        public string TokenSecret { get; set; }
        public bool IsAuthenticated
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Token);
            }
        }
    }
}
