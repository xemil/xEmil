using xEmilForms.ViewModel;


namespace xEmilForms.Pages
{
    /// <summary>
	/// Class MvvmSamplePage.
	/// </summary>
	public partial class MvvmSamplePage : ContentPage
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

