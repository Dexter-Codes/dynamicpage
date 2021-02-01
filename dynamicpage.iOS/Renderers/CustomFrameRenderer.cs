using System;
using System.ComponentModel;
using CoreAnimation;
using CoreGraphics;
using dynamicpage.CustomControl;
using dynamicpage.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomFrame), typeof(CustomFrameRenderer))]
namespace dynamicpage.iOS.Renderers
{
    public class CustomFrameRenderer:VisualElementRenderer<Frame>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
                SetupLayer();
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
           
            if (CustomFrame.ShadowColorProperty.PropertyName == e.PropertyName)
                SetupLayer();
        }
        void SetupLayer()
        {
            var customControl = Element as CustomFrame;

            Layer.CornerRadius = customControl.CornerRadius;

            //this.Layer.Bounds.Inset(0, 0);




            //Layer.ShadowRadius = 5;
            //Layer.ShadowColor = customControl.ShadowColor.ToCGColor();
            //Layer.BorderColor = customControl.ShadowColor.ToCGColor();
            //Layer.BorderWidth = 1;
            //Layer.ShadowOpacity = 0.5f;
            //Layer.ShadowOffset = new CGSize(width:2, height: 2);



            Layer.BorderColor = UIColor.LightGray.CGColor;
            Layer.BorderWidth = 1;
            Layer.CornerRadius = 20;
            Layer.MasksToBounds = false;
            Layer.ShadowOffset = new CGSize(-2, 2);
            Layer.ShadowRadius = 5;
            Layer.ShadowOpacity = 0.4f;
            Layer.ShadowColor = UIColor.SystemGray2Color.CGColor;
        }
    }
}
