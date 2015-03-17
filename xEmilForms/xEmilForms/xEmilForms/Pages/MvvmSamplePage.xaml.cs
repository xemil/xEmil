using xEmilForms.ViewModel;
using XLabs.Forms.Mvvm;

namespace xEmilForms.Pages
{
    /// <summary>
	/// Class MvvmSamplePage.
	/// </summary>
	public partial class MvvmSamplePage : BaseView
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MvvmSamplePage"/> class.
		/// </summary>
		public MvvmSamplePage()
		{
			InitializeComponent ();
			BindingContext = new MvvmSampleViewModel ();
		}
	}
}

