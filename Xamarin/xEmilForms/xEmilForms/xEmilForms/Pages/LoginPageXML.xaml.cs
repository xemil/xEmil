using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace xEmilForms.Pages
{
    public partial class LoginPageExtraXML : ContentPage
    {
        public LoginPageExtraXML()
        {
            InitializeComponent();

            xEmilButton.Clicked += ButtonClick;
			//Showing custom font in image button
		}

		private void ButtonClick(object sender, EventArgs e)
		{
			var button = sender as ImageButton;
			this.DisplayAlert("Button Pressed", string.Format("The {0} button was pressed.", button.Text), "OK",
				"Cancel");
		}
        }
    
}
