using System;
using dynamicpage.Model;
using Xamarin.Forms;

namespace dynamicpage.View
{
    public class CustomView
    {
        public CustomView()
        {
        }
    }

    public class DynamicButton:Button
    {
        public DynamicButton(UIElementModel model)
        {
            this.BindingContext = model;
            SetValues(model);
        }
        public void SetValues(UIElementModel model)
        {
            this.Text = model.Text;
         //   this.Command = model.ClickAction;
        }
    }

}
