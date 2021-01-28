using System;
using System.Collections.Generic;
using dynamicpage.Model;
using dynamicpage.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dynamicpage
{
    public partial class App : Application
    {
        List<UIElementModel> uiElements { get; set; }
        public App()
        {
            InitializeComponent();
            PushValues();
            MainPage = new DynamicForm();
                //new DynamicPage(uiElements);
        }

        public void PushValues()
        {
            uiElements = new List<UIElementModel>();
            uiElements.Add(new UIElementModel {ElementValue="", Text="Trouble",Type= "UIButtonModel" });
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
