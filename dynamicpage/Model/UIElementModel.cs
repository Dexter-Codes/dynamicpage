using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace dynamicpage.Model
{
    public class UIElementModel
    {
        public object ElementValue { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
    }

    public class UIButtonModel : UIElementModel
    {
        public Command ClickAction { get; set; }
    }

    public class UIEntryModel : UIElementModel
    {
        public string Placeholder { get; set; }
    }

    public class UIPickerModel : UIElementModel
    {
        public List<string> Items { get; set; }
    }
}
