using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using xEmilForms.Cell;
using xEmilForms.Droid.Render;
using View = Android.Views.View;

[assembly: ExportCell(typeof (RedditCellNew), typeof (RedditCellRenderer))]

namespace xEmilForms.Droid.Render
{
    public class RedditCellRenderer : ViewCellRenderer
    {
    }
}