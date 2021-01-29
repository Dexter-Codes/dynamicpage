using System;
using Android.Content;
using Android.Graphics;
using dynamicpage.CustomControl;
using dynamicpage.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomFrame), typeof(CustomFrameRenderer))]
namespace dynamicpage.Droid.Renderers
{
    public class CustomFrameRenderer:FrameRenderer
    {
        public CustomFrameRenderer(Context context) : base(context) { }

        //protected override void OnDraw(Canvas canvas)
        //{

        //    var frame = Element as CustomFrame;

        //    var my1stPaint = new Paint();
        //    var my2ndPaint = new Paint();
        //    var backgroundPaint = new Paint();

        //    my1stPaint.AntiAlias = true;
        //    my1stPaint.SetStyle(Paint.Style.Stroke);
        //    my1stPaint.StrokeWidth = frame.BorderWidth + 2;
        //    my1stPaint.Color = frame.BorderColor.ToAndroid();

        //    my2ndPaint.AntiAlias = true;
        //    my2ndPaint.SetStyle(Paint.Style.Stroke);
        //    my2ndPaint.StrokeWidth = frame.BorderWidth;
        //    my2ndPaint.Color = frame.BackgroundColor.ToAndroid();

        //    backgroundPaint.SetStyle(Paint.Style.Stroke);
        //    backgroundPaint.StrokeWidth = 4;
        //    backgroundPaint.Color = frame.BackgroundColor.ToAndroid();

        //    Android.Graphics.Rect oldBounds = new Android.Graphics.Rect();
        //    canvas.GetClipBounds(oldBounds);

        //    RectF oldOutlineBounds = new RectF();
        //    oldOutlineBounds.Set(oldBounds);

        //    RectF myOutlineBounds = new RectF();
        //    myOutlineBounds.Set(oldBounds);
        //    myOutlineBounds.Top += (int)my2ndPaint.StrokeWidth + 3;
        //    myOutlineBounds.Bottom -= (int)my2ndPaint.StrokeWidth + 3;
        //    myOutlineBounds.Left += (int)my2ndPaint.StrokeWidth + 3;
        //    myOutlineBounds.Right -= (int)my2ndPaint.StrokeWidth + 3;

        //    canvas.DrawRoundRect(oldOutlineBounds, 10, 10, backgroundPaint); //to "hide" old outline
        //    canvas.DrawRoundRect(myOutlineBounds, frame.CornerRadius, frame.CornerRadius, my1stPaint);
        //    canvas.DrawRoundRect(myOutlineBounds, frame.CornerRadius, frame.CornerRadius, my2ndPaint);

        //    base.OnDraw(canvas);
        //}

        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement is CustomFrame element)
            {
                if (element == null) return;

                if (element.HasShadow)
                {
                    // Elevation = 10.0f;
                    Elevation = 5.0f;
                        TranslationZ = 5.0f;
                         SetZ(10.0f);
                    this.SetBackgroundResource(Resource.Drawable.shadow);
                }
            }
        }
    }
}
