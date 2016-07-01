using System.Collections;
using System.Windows.Input;
using Xamarin.Forms;

namespace xEmilforms.Controls
{
	public class RedditScrollView : ListView 
    {

        public static readonly BindableProperty LoadMoreCommandProperty = BindableProperty.Create<RedditScrollView, ICommand>(ld => ld.LoadMoreCommand, default(ICommand));

	    public ICommand LoadMoreCommand
	    {
	        get { return (ICommand) GetValue(LoadMoreCommandProperty); }
            set { SetValue(LoadMoreCommandProperty, value);}
	    }

	    public RedditScrollView()
	    {
	        ItemAppearing += RedditScrollView_ItemAppering;
	    }

	    private void RedditScrollView_ItemAppering(object sender, ItemVisibilityEventArgs e)
	    {
	        var items = ItemsSource as IList;
	        if (items != null && e.Item == items[items.Count -1])
	        {
	            if (LoadMoreCommand != null && LoadMoreCommand.CanExecute(null))
	            {
	                LoadMoreCommand.Execute(null);
	            }
	        }
	    }
    }
}
