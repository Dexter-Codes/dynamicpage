using System;
using Xamarin.Forms;

namespace dynamicpage.View
{
    public class DTrst:ViewCell
    {
        public DTrst(int x)
        {
            SetView(x);
           
        }
        public DTrst()
        {
            SetView(1);
        }
        public void SetView(int x)
        {
            var label = new Label { Text = "bdfhe" + x.ToString() };
            var frame = new Frame { Content = label };
            View = frame;
            this.BindingContext = this;
        }
    }
}
