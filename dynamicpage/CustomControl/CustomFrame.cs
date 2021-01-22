using System;
using Xamarin.Forms;

namespace dynamicpage.CustomControl
{
    public class CustomFrame:Frame
    {
        public static BindableProperty CornerRadiusProperty
          = BindableProperty.Create(nameof(CornerRadius), typeof(int), typeof(CustomFrame), 10);

        public static BindableProperty ShadowColorProperty
           = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CustomFrame), Color.Gray);

        public int CornerRadius
        {
            get { return (int)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
        public Color ShadowColor
        {
            get { return (Color)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }
    }
}
