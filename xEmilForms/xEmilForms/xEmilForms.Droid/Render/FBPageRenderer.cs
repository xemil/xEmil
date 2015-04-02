using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using xEmilForms.Droid.Render;
using xEmilForms.Pages;

[assembly: ExportRenderer(typeof(FBLoginPage), typeof(FBPageRenderer))]

namespace xEmilForms.Droid.Render
{
   
    class FBPageRenderer : PageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);


        
        }
            
        
        
    }
}