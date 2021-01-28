using System;
using System.ComponentModel;
using CoreGraphics;
using dynamicpage.CustomControl;
using dynamicpage.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEditor), typeof(CustomEditorRenderer))]
namespace dynamicpage.iOS.Renderers
{
    public class CustomEditorRenderer: EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Editor> e)
        {
            base.OnElementChanged(e);

            if (Control==null)
                return;

            if (e.NewElement != null)
            {
                var customControl = (CustomEditor)e.NewElement;

                if (customControl.IsExpandable)
                    Control.ScrollEnabled = false;
                else
                    Control.ScrollEnabled = true;

                Control.Layer.CornerRadius = customControl.RoundedCornerRadius;

                Control.Layer.BorderWidth = customControl.BorderWidth;
                Control.Layer.BorderColor = customControl.BorderColor.ToUIColor().CGColor;
                SetupLayer();
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (Control == null)
                return;

            var customControl = (CustomEditor)Element;

            if (customControl == null)
                return;

           
             if (CustomEditor.BorderWidthProperty.PropertyName == e.PropertyName)
            {

                Control.Layer.BorderWidth = customControl.BorderWidth;
                Control.Layer.CornerRadius = customControl.RoundedCornerRadius;
                SetupLayer();
            }
            else if (CustomEditor.BorderColorProperty.PropertyName == e.PropertyName)
            {
                Control.Layer.BorderColor = customControl.BorderColor.ToUIColor().CGColor;
                SetupLayer();
            }

            else if (CustomEditor.IsExpandableProperty.PropertyName == e.PropertyName)
            {
                if (customControl.IsExpandable)
                    Control.ScrollEnabled = false;
                else
                    Control.ScrollEnabled = true;

                SetupLayer();
            }
        }
        void SetupLayer()
        {
            Layer.BorderColor = UIColor.White.CGColor;
            Layer.CornerRadius = 10;
            Layer.MasksToBounds = false;
            Layer.ShadowOffset = new CGSize(-2, 2);
            Layer.ShadowRadius = 5;
            Layer.ShadowOpacity = 0.4f;
        }
    }
}
