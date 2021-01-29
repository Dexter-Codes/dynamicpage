using System;
using Xamarin.Forms;

namespace dynamicpage.CustomControl
{
    public class CustomEditor:Editor
    {
        public static BindableProperty BorderWidthProperty
            = BindableProperty.Create(nameof(BorderWidth), typeof(int), typeof(CustomEditor), 2);

        public static BindableProperty BorderColorProperty
           = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CustomEditor), Color.LightGray);


        public static BindableProperty RoundedCornerRadiusProperty
           = BindableProperty.Create(nameof(RoundedCornerRadius), typeof(int), typeof(CustomEditor), 5);

        public static BindableProperty IsExpandableProperty
        = BindableProperty.Create(nameof(IsExpandable), typeof(bool), typeof(CustomEditor), false);

        public bool IsExpandable
        {
            get { return (bool)GetValue(IsExpandableProperty); }
            set { SetValue(IsExpandableProperty, value); }
        }

        public int RoundedCornerRadius
        {
            get { return (int)GetValue(RoundedCornerRadiusProperty); }
            set { SetValue(RoundedCornerRadiusProperty, value); }
        }

        public int BorderWidth
        {
            get { return (int)GetValue(BorderWidthProperty); }
            set { SetValue(BorderWidthProperty, value); }
        }

        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }
        public CustomEditor()
        {
            TextChanged += OnTextChanged;
        }
        ~CustomEditor()
        {
            TextChanged -= OnTextChanged;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (IsExpandable) InvalidateMeasure();
        }
    }
   
}
