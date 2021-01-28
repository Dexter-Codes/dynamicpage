using System;
using CoreAnimation;
using CoreGraphics;
using dynamicpage.CustomControl;
using dynamicpage.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RoundedButtonLeft), typeof(RoundedButtonRendererLeft))]
[assembly: ExportRenderer(typeof(RoundedButtonRight), typeof(RoundedButtonRendererRight))]
namespace dynamicpage.iOS.Renderers
{
    public class RoundedButtonRendererLeft : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
            }
        }
        public override void LayoutSubviews()
        {
            var maskingShapeLayer = new CAShapeLayer()
            {
                Path = UIBezierPath.FromRoundedRect(Bounds, UIRectCorner.BottomLeft | UIRectCorner.TopLeft, new CGSize(20, 20)).CGPath
            };
            Layer.Mask = maskingShapeLayer;
            Layer.CornerRadius = 0;
            base.LayoutSubviews();
        }

    }
    public class RoundedButtonRendererRight : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
            }
        }
        public override void LayoutSubviews()
        {
            var maskingShapeLayer = new CAShapeLayer()
            {
                Path = UIBezierPath.FromRoundedRect(Bounds, UIRectCorner.BottomRight | UIRectCorner.TopRight, new CGSize(20, 20)).CGPath
            };
            Layer.Mask = maskingShapeLayer;
            Layer.CornerRadius = 0;
            base.LayoutSubviews();
        }
    }
}
