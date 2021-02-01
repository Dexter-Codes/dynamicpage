using System;
using System.Collections.Generic;
using dynamicpage.CustomControl;
using Xamarin.Forms;

namespace dynamicpage.View
{
    public class DynamicOrderDetail:ContentPage
    {
        public List<Dictionary<string, string>> _test { get; set; }

        public List<Dictionary<string, string>> Test
        {
            get { return _test; }
            set
            {
                _test = value;
                OnPropertyChanged("Test");
            }
        }
        public DynamicOrderDetail()
        {
            Test = new List<Dictionary<string, string>>();
            SetData();
            CreateView();
        }
        void SetData()
        {
            var itemDict1 = new List<Dictionary<string, string>>();
            var item0 = new Dictionary<string, string>();
            item0["Type"] = "Status_Label";
            item0["value"] = "Complete";
            var item1 = new Dictionary<string, string>();
            item1["Type"] = "Title_Label";
            item1["Title"] = "OrderNo";
            item1["value"] = "123456";
            var item2 = new Dictionary<string, string>();
            item2["Type"] = "Title_Label";
            item2["Title"] = "Client Name";
            item2["value"] = "Client 1";
            var item3 = new Dictionary<string, string>();
            item3["Type"] = "Title_Label";
            item3["Title"] = "Property Name";
            item3["value"] = "7700";
            var item4 = new Dictionary<string, string>();
            item4["Type"] = "Title_Entry";
            item4["Title"] = "Address";
            item4["value"] = "13/a New Orleans";
            var item5 = new Dictionary<string, string>();
            item5["Type"] = "Title_Entry";
            item5["Title"] = "Notes";
            item5["value"] = "N/A";
            var item6 = new Dictionary<string, string>();
            item6["Type"] = "Title_Button";
            item6["value1"] = "Before Images";
            item6["value2"] = "After Images";
            itemDict1.Add(item0);
            itemDict1.Add(item1);
            itemDict1.Add(item2);
            itemDict1.Add(item3);
            itemDict1.Add(item4);
            itemDict1.Add(item5);
            itemDict1.Add(item6);

            Test = itemDict1;

        }
        void CreateView()
        {

            var statusDataTemplate = new DataTemplate(() =>
            {
                var gridLayout = new Grid { RowSpacing = 10, Padding = new Thickness(0, 10, 0, 10), Margin = 10, BackgroundColor = Color.Transparent };

                gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
                gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });

                gridLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                var outerlayout = new StackLayout { Margin = 10 };
                var layout = new StackLayout { Orientation = StackOrientation.Horizontal, Margin = 10 };
                var label1 = new CustomLabel { HorizontalOptions = LayoutOptions.StartAndExpand, WidthRequest = 130 };
                var label2 = new CustomLabel { HorizontalOptions = LayoutOptions.CenterAndExpand, WidthRequest = 130,Text="Compkletd" };
                gridLayout.Children.Add(label1, 0, 0);
                gridLayout.Children.Add(label2, 1, 0);
                layout.Children.Add(label1);
                layout.Children.Add(label2);
                outerlayout.Children.Add(layout);

                return new ViewCell { View = gridLayout };
            });

            var titleDataTemplate = new DataTemplate(() =>
            {
                var gridLayout = new Grid { RowSpacing = 10, Padding = new Thickness(0, 10, 0, 10), Margin = 10, BackgroundColor = Color.Transparent };

                gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
                gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });

                gridLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                var outerlayout = new StackLayout { Margin = 10 };
                var layout = new StackLayout
                { Orientation = StackOrientation.Horizontal, Margin = 10 };
                var label1 = new CustomLabel { HorizontalOptions = LayoutOptions.StartAndExpand, WidthRequest = 130, Text="5565rt" };
                var label2 = new CustomLabel { HorizontalOptions = LayoutOptions.CenterAndExpand, WidthRequest = 130, BindingKey = "656nh" };
                gridLayout.Children.Add(label1, 0, 0);
                gridLayout.Children.Add(label2, 1, 0);
                layout.Children.Add(label1);
                layout.Children.Add(label2);
                outerlayout.Children.Add(layout);
                return new ViewCell { View = gridLayout };
            });

            var entryDataTemplate = new DataTemplate(()=>
            {
                var gridLayout = new Grid { RowSpacing = 10, Padding = new Thickness(0, 10, 0, 10), Margin = 10, BackgroundColor = Color.Transparent };

                gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
                gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });

                gridLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                var outerlayout = new StackLayout { Margin = 10 };
                var layout = new StackLayout { Orientation = StackOrientation.Vertical, Margin = 10 };
                var label = new CustomLabel { HorizontalOptions = LayoutOptions.StartAndExpand, BindingKey = "Note" };
                var entry = new CustomEditor
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.StartAndExpand,
                    HeightRequest = 100,
                    IsEnabled = true,
                    Text = "nothing",
                    BackgroundColor = Color.Transparent,
                    RoundedCornerRadius = 20,
                    BorderWidth = 1,
                    BorderColor = Color.Transparent
                };
                var frame = new CustomFrame { CornerRadius = 20, Content = entry, Padding = 0, HasShadow = true };
                gridLayout.Children.Add(label, 0, 0);
                gridLayout.Children.Add(frame, 0, 0);
                Grid.SetColumnSpan(frame, 2);
                layout.Children.Add(label);
                layout.Children.Add(frame);
                outerlayout.Children.Add(layout);
                Grid.SetColumnSpan(layout, 2);

                return new ViewCell { View = gridLayout };
            });
            var btntemplate = new DataTemplate(()=>
            {
                var gridLayout = new Grid { RowSpacing = 10, Padding = new Thickness(0, 10, 0, 10), Margin = 10, BackgroundColor = Color.Transparent };

                gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
                gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });

                gridLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                var outerlayout = new StackLayout { Margin = 10 };
                var layout = new StackLayout { Orientation = StackOrientation.Horizontal, Margin = 10 };
                var btn1 = new RoundedButtonLeft
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.StartAndExpand,
                    Text = "left",
                    BackgroundColor = Color.Green,
                    CornerRadius = 0,
                    TextColor = Color.White
                };
                var btn2 = new RoundedButtonRight
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.StartAndExpand,
                    Text = "right",
                    BackgroundColor = Color.Green,
                    CornerRadius = 0,
                    TextColor = Color.White
                };
                gridLayout.Children.Add(btn1, 0, 0);
                gridLayout.Children.Add(btn2, 1, 0);
                layout.Children.Add(btn1);
                layout.Children.Add(btn2);
                outerlayout.Children.Add(layout);
                return new ViewCell { View = gridLayout };
            });

            Content = new StackLayout
            {
                Margin = new Thickness(5),
                Children = {
                    new ListView { ItemTemplate = new PersonDataTemplateSelector{ StatusLabelTemplate = statusDataTemplate, TitleTemplate=titleDataTemplate, EntryTemplate=entryDataTemplate,ButtonTemplate= btntemplate},
                        ItemsSource = Test, Margin = new Thickness(0, 10, 0, 10), HasUnevenRows = true, SeparatorVisibility=SeparatorVisibility.None}
                }

            };

            this.BindingContext = Test;
        }

    }
    public class PersonDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate StatusLabelTemplate { get; set; }
        public DataTemplate TitleTemplate { get; set; }
        public DataTemplate EntryTemplate { get; set; }
        public DataTemplate ButtonTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Dictionary<string,string> test = (Dictionary<string, string>)item;
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
