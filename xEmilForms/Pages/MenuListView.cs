using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xEmilForms.Cell;
using xEmilForms.Model;

namespace xEmilForms.Pages
{
    using System;
    using Xamarin.Forms;
    using System.Collections.Generic;


    public class MenuListView : ListView
    {
        public MenuListView()
        {
            List<ListMenuItem> data = new MenuListData();
            ItemsSource = data;
            VerticalOptions = LayoutOptions.FillAndExpand;
            BackgroundColor = Color.Transparent;
            SeparatorVisibility = SeparatorVisibility.Default;
            var cell = new DataTemplate(typeof(MenuCell));
            cell.SetBinding(MenuCell.TextProperty, "Title");
            cell.SetBinding(MenuCell.ImageSourceProperty, "IconSource");
            ItemTemplate = cell;
        }
    }

}
