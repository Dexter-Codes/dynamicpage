using System;
using Xamarin.Forms;

namespace dynamicpage.CustomControl
{
    public class CustomFrame:Frame
    {

        public static BindableProperty BorderWidthProperty
          = BindableProperty.Create(nameof(BorderWidth), typeof(float), typeof(CustomFrame), (float)0);

        public float BorderWidth
        {
            get { return (float)GetValue(BorderWidthProperty); }
            set { SetValue(BorderWidthProperty, value); }
        }

        public static BindableProperty ShadowColorProperty
           = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CustomFrame), Color.Gray);
    
        public Color ShadowColor
        {
            get { return (Color)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }
    }
}
