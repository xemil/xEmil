using xEmilForms.ViewCells;
using Xamarin.Forms;
using xEmilForms.ViewModels;


namespace xEmilForms
{
    class DataTemplateSelector : Xamarin.Forms.DataTemplateSelector
    {
        public DataTemplateSelector()
        {
            // Retain instances!
            this.incomingDataTemplate = new DataTemplate(typeof(XImageCell));
            this.outgoingDataTemplate = new DataTemplate(typeof(OtherCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return outgoingDataTemplate;
        }

        private readonly DataTemplate incomingDataTemplate;
        private readonly DataTemplate outgoingDataTemplate;
    }
}