using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xEmilForms.Renderer
{
    public class RedditCell : ViewCell
    {
        public RedditCell()
        {
            var image = new Image();
            image.SetBinding(Image.SourceProperty, new Binding("ImageUri"));
            var headerLayout = CreateHeaderLayout();
            View = new StackLayout()
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = {image, headerLayout}
            };

        }

        private StackLayout CreateHeaderLayout()
        {
            var headerLabel = new Label()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions =  LayoutOptions.Start,
                FontSize = 10
                
            };
            headerLabel.SetBinding(Label.TextProperty, "Header");
            
            
            var descriptionLabel = new Label()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Start
            };

            descriptionLabel.SetBinding(Label.TextProperty, "Description");

            var headerLayout = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Horizontal,
                Children = {headerLabel, descriptionLabel}
            };
            return headerLayout;

        }
    }
}
