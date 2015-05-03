using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using xEmilForms.Helpers;
using xEmilForms.ViewModel;

namespace xEmilForms.Pages
{
    public partial class SelectedUserPage : XLabs.Forms.Mvvm.BaseView
    {
        public SelectedUserPage()
        {
            BindingContext = new SelectedUserViewModel();   
            InitializeComponent();
        }
    }
}
