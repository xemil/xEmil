using xEmilForms.ViewModel;
using XLabs.Forms.Mvvm;
using xEmilTest

namespace xEmilForms.Pages
{
    public partial class ButtonPage : XLabs.Forms.Mvvm.BaseView
    {
        public ButtonPage()
        {
            InitializeComponent();
            BindingContext = new ButtonPageViewModel();
        }
    }
}
