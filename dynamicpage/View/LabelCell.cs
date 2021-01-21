using System;
using Xamarin.Forms;

namespace dynamicpage.View
{
    public class LabelCell:ViewCell
    {
        public LabelCell()
        {
            var layout = new StackLayout();
            layout.Orientation = StackOrientation.Horizontal;

            var keylabel = new Label();
            var vallabel = new Label();

            keylabel.SetBinding(Label.TextProperty,"Key");
            vallabel.SetBinding(Label.TextProperty, "Value");

            layout.Children.Add(keylabel);
            layout.Children.Add(vallabel);

           View  = layout;
        }
    }
}
