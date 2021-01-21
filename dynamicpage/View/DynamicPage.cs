using System;
using System.Collections.Generic;
using dynamicpage.Model;
using Xamarin.Forms;

namespace dynamicpage.View
{
    public class DynamicPage:ContentPage
    {
        public DynamicPage(List<UIElementModel> uiElements)
        {
            var ElementStackLayout = new StackLayout();

            foreach (UIElementModel model in uiElements)
            {
                //if (model.Type == UIEntryModel)
                //{
                //    DynamicEntry entry = new DynamicEntry(model);
                //    this.ElementStackLayout.Children.Add(entry);
                //}
                if (model.Type == "UIButtonModel")
                {
                    DynamicButton button = new DynamicButton(model);
                    ElementStackLayout.Children.Add(button);
                }
            }
            Content = ElementStackLayout;
        }
    }
}
