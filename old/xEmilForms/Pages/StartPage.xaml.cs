using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xEmilForms.ViewModel;

using Xamarin.Forms;

namespace xEmilForms.Pages
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            BindingContext = new StartPageViewModel();
            InitializeComponent();
        }
    }
}
