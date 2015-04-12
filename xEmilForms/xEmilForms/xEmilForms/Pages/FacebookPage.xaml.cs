using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using xEmilForms.ViewModel;

namespace xEmilForms.Pages
{
    public partial class FacebookPage : XLabs.Forms.Mvvm.BaseView
    {
        public FacebookPage()
        {
            BindingContext = new FacebookViewModel();
            InitializeComponent();
        }
    }
}
