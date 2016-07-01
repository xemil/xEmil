using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
.Controls;

namespace xEmilForms.Cell
{

    class FacebookUserCell : ViewCell
    {

        /// <summary>
        /// Bind prop = ImageUri, NameText, TimeText, PlaceText
        /// </summary>
        public FacebookUserCell()
        {
            var image = new Image()
            {
                MinimumHeightRequest = 50,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Start
            };
            image.SetBinding(Image.SourceProperty, "ProfileImage.Source");

            var nextImage = new Image()
            {
                Source = "ic_action_next_item.png",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.End
            };


            StackLayout descriptionLayout = GetHeaderLayout();

            View = new StackLayout()
            {

                Children =
                {
                    image,
                    descriptionLayout,
                    nextImage
                },
                Orientation = StackOrientation.Horizontal,
                MinimumHeightRequest = 100,
                Spacing = 3,
                Padding = new Thickness(10, 5, 10, 5)
            };


        }

        private static StackLayout GetHeaderLayout()
        {
            var nameLabel = new Label()
            {
                FontSize = 16,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            nameLabel.SetBinding(Label.TextProperty, "Name");

            var lastSeenLabel = new Label()
            {
                Text = "Last Seen:"
            };

            var time = new Label()
            {
                Text = "13:00"
            };

            //time.SetBinding(Label.TextProperty, "Name");

            var place = new Label()
            {
                Text = "Lund"
            };
            //place.SetBinding(Label.TextProperty, "PlaceText");


            var textLayout = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Children = { lastSeenLabel, place, time },
                Spacing = 3,
                HorizontalOptions = LayoutOptions.End
            };


            var layout = new StackLayout()
            {
                Children = { nameLabel, textLayout },
                MinimumHeightRequest = 50,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Padding = new Thickness(10, 0, 0, 0)
            };


            return layout;

        }
    }

}
