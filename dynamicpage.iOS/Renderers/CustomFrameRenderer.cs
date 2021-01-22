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

            this.Layer.Bounds.Inset(0, 0);



            UIRectCorner uIRectCorner = UIRectCorner.TopLeft | UIRectCorner.TopRight | UIRectCorner.BottomLeft | UIRectCorner.BottomRight;

            UIBezierPath mPath = UIBezierPath.FromRoundedRect(Layer.Bounds, (UIKit.UIRectCorner)uIRectCorner, new CGSize(width: 5, height: 5));
            CAShapeLayer maskLayer = new CAShapeLayer();
            maskLayer.Frame = Layer.Bounds;
            maskLayer.Path = mPath.CGPath;


            Layer.ShadowRadius = 5;
            Layer.ShadowColor = customControl.ShadowColor.ToCGColor();
            Layer.BorderColor = customControl.ShadowColor.ToCGColor();
            Layer.BorderWidth = 1;
            Layer.ShadowOpacity = 0.5f;
            Layer.ShadowOffset = new CGSize(width:2, height: 2);
            Layer.ShadowPath = maskLayer.ShadowPath;
  //          Layer.ShouldRasterize = true;
  //          Layer.RasterizationScale = 1;
            Layer.MasksToBounds = false;
           // Layer.RasterizationScale=UI
        }
    }
}
