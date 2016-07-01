using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xEmilForms.ViewModel
{
    class LoginViewModel : XLabs.Forms.Mvvm.ViewModel
    {
        private Button _loginButton;

        public Button LoginButton
        {
            get
            {
                return _loginButton ?? (_loginButton = new Button()
                {
                    Text = "Login",
                });
            }
            set { SetProperty(ref _loginButton, value); }
        }

        private Image _logoImage;
        public Image LogoImage
        {
            get
            {
                return _logoImage ?? (_logoImage = new Image()
                {
                    Source = "xEmilImage850x718.png"
                });
            }
            set { SetProperty(ref _logoImage, value); }
        }
    }

}
