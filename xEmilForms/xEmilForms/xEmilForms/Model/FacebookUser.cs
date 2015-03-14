using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XLabs.Data;

namespace xEmilForms.Model
{
    class FacebookUser : ObservableObject
    {
        private string _Name;
        private Image _ProfileImage;

        public string Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value); }
        }

        public Image ProfileImage
        {
            get { return _ProfileImage; }
            set { SetProperty(ref _ProfileImage, value); }
        }
    }
}
