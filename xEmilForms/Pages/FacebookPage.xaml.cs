using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using xEmilForms.ViewModel;

namespace xEmilForms.Pages
{
    public partial class FacebookPage : ContentPage
    {
        public FacebookPage()
        {
            BindingContext = new FacebookViewModel();
            InitializeComponent();
        }
    }
}
