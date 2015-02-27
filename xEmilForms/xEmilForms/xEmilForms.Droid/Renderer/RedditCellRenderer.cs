using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using xEmilForms.Droid.Renderer;
using xEmilForms.Cell;
using xEmilForms.Exception;
using xEmilForms.ViewModel;
using XLabs.Platform;
using Color = Xamarin.Forms.Color;
using ListView = Android.Widget.ListView;
using View = Android.Views.View;

[assembly: ExportCell(typeof(RedditCellNew), typeof(RedditCellRenderer))]

namespace xEmilForms.Droid.Renderer
{
    public class RedditCellRenderer : ViewCellRenderer
    {
        public RedditCellRenderer()
        {
            
        }

        protected override View GetCellCore(Xamarin.Forms.Cell item, View convertView, ViewGroup parent, Context context)
        {
            var inflatorservice =
                (LayoutInflater) Forms.Context.GetSystemService(Android.Content.Context.LayoutInflaterService);
            var redditCell = (RedditCellNew) item;
            var view = convertView;

            var redditVm = redditCell.BindingContext as RedditPostViewModel;
            if (redditVm != null)
            {
                var redditPost = redditVm.RedditPosts.FirstOrDefault();
                var template = inflatorservice.Inflate(Resource.Layout.redditCell, null);
                template.FindViewById<ImageView>(Resource.Id.imageView1).SetImageURI(redditPost.ImageUri.ToAndroidUri());
                template.FindViewById<TextView>(Resource.Id.textView1).Text = redditPost.Header;
                template.FindViewById<TextView>(Resource.Id.textView2).Text = redditPost.Description;
                return template;
            }


            if (view == null)
            {
                throw new NoViewException("ANDROID REDDIT CELL RENDERER NO VIEW");
            }

            return base.GetCellCore(item, convertView, parent, context);
        }
    }
}