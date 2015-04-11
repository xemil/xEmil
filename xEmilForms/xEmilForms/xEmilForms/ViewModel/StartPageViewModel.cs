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


   

		

    }

}
