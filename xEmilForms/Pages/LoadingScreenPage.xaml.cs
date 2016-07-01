using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using xEmilForms.ViewModel;

namespace xEmilForms.Pages
{
    public partial class LoadingScreenPage : ContentPage
    {
        public LoadingScreenPage()
        {
            BindingContext = new LoadingScreenViewModel();
            InitializeComponent();
        }
    }
}
