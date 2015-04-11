using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xEmilForms.ViewModel;
using XLabs.Forms.Mvvm;
using Xamarin.Forms;

namespace xEmilForms.Pages
{
    public partial class StartPage : XLabs.Forms.Mvvm.BaseView
    {
        public StartPage()
        {
            BindingContext = new StartPageViewModel();
            InitializeComponent();
        }
    }
}
