using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XLabs.Data;
using XLabs.Forms.Controls;

namespace xEmilForms.Helpers
{
    public class FacebookUser : ObservableObject
    {
        private string _id;
        public string Id
        {
            get { return _id ?? (_id = "notSet"); }
            set { SetProperty(ref _id, value); }
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName ?? (_firstName = "notSet"); }
            set { SetProperty(ref _firstName, value); }
        }

        private string _gender;
        public string Gender
        {
            get { return _gender ?? (_gender = "notSet"); }
            set { SetProperty(ref _gender, value); }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName ?? (_lastName = "notSet"); }
            set { SetProperty(ref _lastName, value); }
        }

        private Uri _link;
        public Uri Link
        {
            get { return _link; }
            set { SetProperty(ref _link, value); }
        }

        private string _locale;
        public string Locale
        {
            get { return _locale ?? (_locale = "notSet"); }
            set { SetProperty(ref _locale, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name ?? (_name = "notSet"); }
            set { SetProperty(ref _name, value); }
        }

        private WebImage _profileImage;
        public WebImage ProfileImage
        {
            get { return _profileImage; }
            set { SetProperty(ref _profileImage, value); }
        }

        private List<FacebookUser> _friendList;
        public List<FacebookUser> FriendList
        {
            get { return _friendList ?? (_friendList = new List<FacebookUser>());}
            set { SetProperty(ref _friendList, value); }
        }

    }
}
