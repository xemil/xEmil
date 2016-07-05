using System;
using xEmilForms.ViewCells;
using xEmilForms.ViewModels;
using Xamarin.Forms;

namespace xEmilForms
{
    internal class DataTemplateSelector : Xamarin.Forms.DataTemplateSelector
    {
        private readonly DataTemplate griddCellTemplate;
        private readonly DataTemplate imagePostTemplate;
        private readonly DataTemplate thirdDefaultTemplate;

        public DataTemplateSelector()
        {
            // Retain instances!
            griddCellTemplate = new DataTemplate(typeof(GridCell));
            imagePostTemplate = new DataTemplate(typeof(ImagePostCell));
            thirdDefaultTemplate = new DataTemplate(typeof(ThirdDefaultCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var i = item as CellData;

            switch (i?.TypeId)
            {
                case 0:
                    return thirdDefaultTemplate;

                case 1:
                    return imagePostTemplate;

                case 3:
                    return thirdDefaultTemplate;
            }
            throw new Exception("No DataTemplate is Choosen");
        }
    }
}