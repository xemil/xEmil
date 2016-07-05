using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

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
