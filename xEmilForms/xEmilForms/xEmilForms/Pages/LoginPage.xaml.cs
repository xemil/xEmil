using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using xEmilForms.ViewModel;
using XLabs.Forms.Mvvm;

namespace xEmilForms.Pages
{
    public partial class LoginPage : BaseView
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}
