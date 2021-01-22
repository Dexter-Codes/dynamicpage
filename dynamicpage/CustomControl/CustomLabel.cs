using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace dynamicpage.CustomControl
{
    public class CustomLabel:Label
    {


        public string Index
        {
            get { return (string)GetValue(IndexProperty); }
            set { SetValue(IndexProperty, value); }
        }

        public static readonly BindableProperty IndexProperty =
         BindableProperty.Create(
          "Index", typeof(string), typeof(CustomLabel), null, propertyChanged: OnEventNameChanged);


        public string BindingKey
        {
            get { return (string)GetValue(BindingKeyProperty); }
            set { SetValue(BindingKeyProperty, value); }
        }

        public static readonly BindableProperty BindingKeyProperty =
         BindableProperty.Create(
          "BindingKey", typeof(string), typeof(CustomLabel), null, propertyChanged: OnEventNameChanged);

     
        private static void OnEventNameChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomLabel)bindable;
            if(control.BindingKey!=null)
            {
                control.Text = control.BindingKey;
            }
        }

    
    }
}
