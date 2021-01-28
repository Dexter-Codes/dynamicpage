using System;
using Android.Content;
using dynamicpage.CustomControl;
using dynamicpage.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RoundedButtonLeft), typeof(RoundedButtonRendererLeft))]
[assembly: ExportRenderer(typeof(RoundedButtonRight), typeof(RoundedButtonRendererRight))]
namespace dynamicpage.Droid.Renderers
{
    public class RoundedButtonRendererLeft : ButtonRenderer
    {
        public RoundedButtonRendererLeft(Context context) : base(context)
        { }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetBackgroundResource(Resource.Drawable.roundedbuttonleft);
            }
        }
    }
    public class RoundedButtonRendererRight : ButtonRenderer
    {
        public RoundedButtonRendererRight(Context context) : base(context)
        { }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetBackgroundResource(Resource.Drawable.roundedbuttonright);
            }
        }
    }
}
