using System.ComponentModel;
using System.Linq;
using Android.Content;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using xEmilForms.Cell;
using XLabs.Forms.Mvvm;
using Xamarin.Forms.Platform.Android;
using xEmilForms.Droid.Render;
using xEmilForms.Exception;
using xEmilForms.ViewModel;
using View = Android.Views.View;

[assembly: ExportCell(typeof(RedditCellNew), typeof(RedditCellRenderer))]

namespace xEmilForms.Droid.Render
{
    public class RedditCellRenderer : ViewCellRenderer
    {
        public RedditCellRenderer()
        {
 

       
        }
    }
}