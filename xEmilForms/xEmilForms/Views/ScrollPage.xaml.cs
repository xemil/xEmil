using Xamarin.Forms;

namespace xEmilForms.Views
{
    public partial class ScrollPage : ContentPage
    {
        public ScrollPage()
        {
            InitializeComponent();
        }
        
        private void MyListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        private void MyListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }
    }
}
