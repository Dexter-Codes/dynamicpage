using System;
using System.ComponentModel;
using System.Drawing;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using dynamicpage.CustomControl;
using dynamicpage.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Xamarin.Forms.Color;

[assembly: ExportRenderer(typeof(CustomEditor), typeof(CustomEditorRenderer))]
namespace dynamicpage.Droid.Renderers
{
    public class CustomEditorRenderer : EditorRenderer
    {
        bool initial = true;
        Drawable originalBackground;
        CustomEditor customControl;

        public CustomEditorRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Editor> e)
        {
            base.OnElementChanged(e);
            customControl = (CustomEditor)Element;
            //if (Control != null)
            //{
            //    if (initial)
            //    {
            //        originalBackground = Control.Background;
            //        initial = false;
            //    }

            //}

            if (e.NewElement != null)
            {
               // var customControl = (CustomEditor)Element;

                //   Control.SetBackgroundResource(Resource.Drawable.shadow);
                //     this.Elevation = 2.0f;
                //     this.TranslationZ = 0.0f;
                //     SetZ(10.0f);

                    ApplyBorder(customControl.BorderWidth, customControl.BorderColor, customControl.RoundedCornerRadius);
              //  Control.Background = AddPickerStyles();
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            var customControl = (CustomEditor)Element;

            if (CustomEditor.BorderWidthProperty.PropertyName == e.PropertyName)
            {
                ApplyBorder(customControl.BorderWidth, customControl.BorderColor, customControl.RoundedCornerRadius);
             //   Control.Background = AddPickerStyles();
            }
            else if (CustomEditor.BorderColorProperty.PropertyName == e.PropertyName)
            {
               // Control.Background = AddPickerStyles();
                  ApplyBorder(customControl.BorderWidth, customControl.BorderColor, customControl.RoundedCornerRadius);

            }

        }

        void ApplyBorder(int width, Color color, int cornerRadius)
        {
            GradientDrawable gd = new GradientDrawable();
            gd.SetCornerRadius(cornerRadius);
            gd.SetStroke(width, color.ToAndroid());
            this.Control.Background = gd;
        }


        //protected override void DispatchDraw(global::Android.Graphics.Canvas canvas)
        //{
        //    try
        //    {
        //        var nativeCtrl = Control;
        //        var formsElement = Element;
        //        if (nativeCtrl == null || formsElement == null)
        //        {
        //            base.DispatchDraw(canvas);
        //            return;
        //        }

        //        //convert from logical to native metrics if need be
        //        var shadowDistanceX = 10f;
        //        var shadowDistanceY = 10f;
        //        var shadowRadius = 5f;
        //        var shadowOpacity = .5f;
        //        var shadowColor = Color.Black;
        //        var cornerRadius = 2.0f;

        //        var bounds = formsElement.Bounds;

        //        var left = shadowDistanceX;
        //        var top = shadowDistanceY;
        //        var right = Width + shadowDistanceX;
        //        var bottom = Height + shadowDistanceY;

        //        var rect = new Android.Graphics.RectF(left, top, right, bottom);

        //        canvas.Save();
        //        using (var paint = new Android.Graphics.Paint { AntiAlias = true })
        //        {
        //            paint.SetStyle(Android.Graphics.Paint.Style.Fill);

        //            var nativeShadowColor = shadowColor.MultiplyAlpha(shadowOpacity * 0.75f).ToAndroid();
        //            paint.Color = nativeShadowColor;

        //            var gradient = new Android.Graphics.RadialGradient(
        //                0.5f, 0.5f,
        //                shadowRadius,
        //                shadowColor.ToAndroid(),
        //                nativeShadowColor,
        //                Android.Graphics.Shader.TileMode.Clamp
        //            );
        //            paint.SetShader(gradient);

        //            //convert from logical to native metrics if need be
        //            var nativeRadius = cornerRadius;
        //            canvas.DrawRoundRect(rect, nativeRadius, nativeRadius, paint);

        //            var clipPath = new Android.Graphics.Path();
        //            clipPath.AddRoundRect(new Android.Graphics.RectF(0f, 0f, Width, Height), nativeRadius, nativeRadius, Android.Graphics.Path.Direction.Cw);
        //            canvas.ClipPath(clipPath);
        //        }
        //        canvas.Restore();
        //    }
        //    catch (Exception ex)
        //    {
        //        //log exception
        //    }

        //    base.DispatchDraw(canvas);
        //}



        //public LayerDrawable AddPickerStyles()
        //{

        //    var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RectShape());
        //    shape.Paint.Color = Android.Graphics.Color.Transparent;
        //    shape.Paint.SetStyle(Paint.Style.Stroke);
        //    shape.SetPadding(30, 10, 20, 10);
        //    shape.Paint.StrokeWidth = 0;

        //    var gdBorderColor = GetBorderDrawable(customControl.BorderWidth, customControl.BorderColor, customControl.RoundedCornerRadius);
        //    var gdBackgroundColor = GetBackgroundColorDrawable(customControl.RoundedCornerRadius, customControl.BackgroundColor);
        //    Drawable[] layers = { gdBackgroundColor, gdBorderColor, shape };
        //    LayerDrawable layerDrawable = new LayerDrawable(layers);
        //    layerDrawable.SetLayerInset(0, 0, 0, 0, 0);

        //    return layerDrawable;
        //}

        GradientDrawable GetBorderDrawable(int width, Color borderColor, int cornerRadius)
        {
            GradientDrawable gd = new GradientDrawable();
            gd.SetCornerRadius(cornerRadius);
            gd.SetStroke(width, borderColor.ToAndroid());
            return gd;

        }
        GradientDrawable GetBackgroundColorDrawable(int cornerRadius, Color backgroundColor)
        {
            GradientDrawable gd = new GradientDrawable();
            gd.SetCornerRadius(cornerRadius);
            gd.SetColorFilter(backgroundColor.ToAndroid(), PorterDuff.Mode.SrcAtop);
            return gd;

        }

    }
}
