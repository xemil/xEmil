using xEmilForms.ViewModel;
using XLabs.Forms.Mvvm;

namespace xEmilForms.Pages
{
    public partial class StudentPage : XLabs.Forms.Mvvm.BaseView
    {
        public StudentPage()
        {
            InitializeComponent();
            BindingContext = new ButtonPageViewModel();
        }
    }
}
