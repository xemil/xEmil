using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using xEmilForms.ViewModels;
using xEmilForms.Views;
using Xamarin.Forms;
using XLabs.Ioc;

namespace xEmilForms.ViewCells
{
    public partial class ThirdDefaultCell : ViewCell
    {

        public ThirdDefaultCell()
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine(this.View.Width);

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            System.Diagnostics.Debug.WriteLine(this.View.Width);

        }
    }
}
