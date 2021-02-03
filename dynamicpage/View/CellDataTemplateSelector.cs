using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace dynamicpage.View
{
    public class CellDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate StatusLabelTemplate { get; set; }
        public DataTemplate TitleTemplate { get; set; }
        public DataTemplate EntryTemplate { get; set; }
        public DataTemplate ButtonTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Dictionary<string, string> test = (Dictionary<string, string>)item;

            if (test.ContainsValue("Status_Label"))
                return StatusLabelTemplate;

            else if (test.ContainsValue("Title_Label"))
                return TitleTemplate;

            else if (test.ContainsValue("Title_Entry"))
                return EntryTemplate;
            else
                return ButtonTemplate;
        }
    }
}
