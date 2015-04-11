using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using xEmilForms.Pages;
using XLabs.Forms.Controls;
using XLabs.Forms.Mvvm;
using XLabs.Forms.Services;

namespace xEmilForms.ViewModel
{
    class StartPageViewModel : XLabs.Forms.Mvvm.ViewModel
    {
        private TapGestureRecognizer _logoImageGestureRecognizer;

        public StartPageViewModel()
        {

            _logoImageGestureRecognizer = new TapGestureRecognizer();
            _logoImageGestureRecognizer.Tapped += (sender, args) =>
            {
                System.Diagnostics.Debug.WriteLine("TAPPED");
                var image = (Image) sender;
                image.RotateTo(200);
            };


        }

        private ExtendedButton _loginButton;

        public ExtendedButton LoginButton
        {

            get
            {
                return _loginButton ?? (_loginButton = new ExtendedButton()
                {
                        Text = "Logga på",
                        
                        Command = LoginCommand
                });
            }
            set { SetProperty(ref _loginButton, value); }
        }

        private Command _loginCommand;

        public Command LoginCommand
        {

            get
            {
                return _loginCommand ?? (_loginCommand = new Command(
                async () => App.GoToAuthAction().Invoke()));
            }
            set { SetProperty(ref _loginCommand, value); }  
        }

        private Image _logoImage;

        public Image LogoImage
        {

            get { return _logoImage ?? (_logoImage = GetLogoImage()); }
            set { SetProperty(ref _logoImage, value); }
        }

        private Image GetLogoImage()
        {
            var image = new Image()
                {
                    Source = "xEmilImage850x718.png",
                    Aspect = Aspect.AspectFit,
                };

            image.GestureRecognizers.Add(_logoImageGestureRecognizer);
            return image;
        }
    }

}
