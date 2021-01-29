using System;
using System.Collections.Generic;
using dynamicpage.Converters;
using dynamicpage.CustomControl;
using Xamarin.Forms;

namespace dynamicpage.View
{
    public class DynamicForm:ContentPage
    {
        static List<Dictionary<string, string>> list;
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
        public DynamicForm()
        {
            Test = new List<Dictionary<string, string>>();
            FormData();
            SetView();
        }      
        void FormData()
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
        public void CreateView()
        {
           
            var test = Test;
            StackLayout innerlayout = null;
            int colmCounter = 0;

            var gridLayout = new Grid { RowSpacing = 10, Padding = new Thickness(0, 10, 0, 10), Margin = 10,BackgroundColor=Color.Transparent };

            gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });

            gridLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            var outerlayout = new StackLayout { Margin=10};

            for(int i=0;i<test.Count;i++)
            {
                if (colmCounter == 0 )
                {
                    innerlayout = new StackLayout { Orientation = StackOrientation.Horizontal };
                    outerlayout.Children.Add(innerlayout);
                    colmCounter = 0; 
                }
                object jj = null;
                if (test[i].ContainsValue("Label"))
                {
                    var x = test[i];

                    foreach (var item in x)
                    {
                        if (!item.Value.Equals("Label"))
                        {
                            jj = item.Value;
                        }
                    }
                }

                    if (test[i].ContainsValue("Label"))
                    {
                        var label = new CustomLabel
                        {
                            //Text = "dummy" + i.ToString(),
                            FontSize = 15,
                            VerticalOptions = LayoutOptions.Start,
                            Index = i.ToString(),
                            BindingKey = (string)jj,
                            WidthRequest = 100,
                            Margin = new Thickness(10, 0, 0, 0)
                        };

                            if (i == 0)
                            { label.HorizontalOptions = LayoutOptions.CenterAndExpand; colmCounter = 0; }
                            else
                            {
                                if (colmCounter % 2 == 0)
                                {
                                    label.HorizontalOptions = LayoutOptions.StartAndExpand;

                                }
                                else
                                {
                                    label.HorizontalOptions = LayoutOptions.CenterAndExpand;
                                }
                            }



                            object t1 = new object();
                            t1 = i;


                            //label.SetBinding(CustomLabel.BindingKeyProperty, new Binding(".", BindingMode.TwoWay,
                            //                           new KeyToValueConverter(), t1, null,
                            //                           test));
                           int col;
                            if (i == 0)
                                col = 1;
                            else
                                col = colmCounter;

                            gridLayout.Children.Add(label, col, 0);
                            innerlayout.Children.Add(label);
                            Grid.SetColumnSpan(outerlayout, 2);

                    if (test[i + 1].ContainsValue("Entry"))
                        colmCounter = 0;
                    else if (i == 0)
                        colmCounter = 0;
                    else if (test[i + 1].ContainsValue("Label"))
                        if (colmCounter == 0)
                            colmCounter++;
                        else if (colmCounter >= 1)
                            colmCounter = 0;

                    }

                    if(test[i].ContainsValue("Entry"))
                    {
                        var editor = new Editor
                        {
                            Placeholder="new text",
                            HorizontalOptions=LayoutOptions.FillAndExpand,
                            VerticalOptions=LayoutOptions.FillAndExpand

                        };
                        gridLayout.Children.Add(editor, colmCounter, 0);
                        innerlayout.Children.Add(editor);
                        Grid.SetColumnSpan(editor, 2);
                        Grid.SetColumnSpan(outerlayout, 2);
                        colmCounter=0;
                    }

            }
            gridLayout.Children.Add(outerlayout);
        
        }
        void SetView()
        {
            var test = Test;

            var gridLayout = new Grid { RowSpacing = 10, Padding = new Thickness(0, 10, 0, 10), Margin = 10, BackgroundColor = Color.Transparent };

            gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });

            gridLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            var outerlayout = new StackLayout { Margin = 10 };
            for (int i = 0; i < test.Count; i++)
            {
                var data = test[i];
                List<string> yui = new List<string>();
                int l = 0;
                foreach (string item in data.Values)
                {
                    var k = item;
                    yui.Add(k);
                    l++;
                }
                if (test[i].ContainsValue("Status_Label"))
                {
                  
                    var layout = new StackLayout { Orientation = StackOrientation.Horizontal, Margin = 10 };
                    var label1 = new CustomLabel { HorizontalOptions = LayoutOptions.StartAndExpand ,WidthRequest=130  };
                    var label2 = new CustomLabel { HorizontalOptions = LayoutOptions.CenterAndExpand,WidthRequest=130,  BindingKey = yui[1] };
                    gridLayout.Children.Add(label1, 0, 0);
                    gridLayout.Children.Add(label2,1,0);
                    layout.Children.Add(label1);
                    layout.Children.Add(label2);
                    outerlayout.Children.Add(layout);
                }
                else if (test[i].ContainsValue("Title_Label"))
                {                    
                    var layout = new StackLayout
                    { Orientation = StackOrientation.Horizontal, Margin = 10 };
                    var label1 = new CustomLabel { HorizontalOptions = LayoutOptions.StartAndExpand, WidthRequest = 130,  BindingKey = yui[1] };
                    var label2 = new CustomLabel { HorizontalOptions = LayoutOptions.CenterAndExpand, WidthRequest = 130,  BindingKey = yui[2] };
                    gridLayout.Children.Add(label1, 0, 0);
                    gridLayout.Children.Add(label2, 1, 0);
                    layout.Children.Add(label1);
                    layout.Children.Add(label2);
                    outerlayout.Children.Add(layout);
                }
                else if(test[i].ContainsValue("Title_Entry"))
                {
                    var layout = new StackLayout { Orientation = StackOrientation.Vertical, Margin = 10 };
                    var label = new CustomLabel { HorizontalOptions = LayoutOptions.StartAndExpand, BindingKey=yui[1] };
                    var entry = new CustomEditor { HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.StartAndExpand,
                        HeightRequest = 100,IsEnabled=true, Text=yui[2],BackgroundColor=Color.Transparent,RoundedCornerRadius=20,BorderWidth=1,BorderColor=Color.Transparent };
                    var frame = new CustomFrame { CornerRadius = 20, Content = entry,Padding=0,HasShadow=true };
                    gridLayout.Children.Add(label, 0, 0);
                    gridLayout.Children.Add(frame, 0, 0);
                    Grid.SetColumnSpan(frame, 2);
                    layout.Children.Add(label);
                    layout.Children.Add(frame);
                    outerlayout.Children.Add(layout);
                    Grid.SetColumnSpan(layout, 2);
                }
                else if(test[i].ContainsValue("Title_Button"))
                {
                    var layout = new StackLayout { Orientation = StackOrientation.Horizontal, Margin = 10 };
                    var btn1 = new RoundedButtonLeft { HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions=LayoutOptions.StartAndExpand,
                        Text = yui[1],BackgroundColor=Color.Green,CornerRadius=0,TextColor=Color.White };
                    var btn2 = new RoundedButtonRight { HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.StartAndExpand,
                        Text = yui[2],BackgroundColor=Color.Green,CornerRadius=0,TextColor=Color.White };
                    gridLayout.Children.Add(btn1, 0, 0);
                    gridLayout.Children.Add(btn2, 1, 0);
                    layout.Children.Add(btn1);
                    layout.Children.Add(btn2);
                    outerlayout.Children.Add(layout);
                }
            }
            Grid.SetColumnSpan(outerlayout, 2);
            gridLayout.Children.Add(outerlayout);
            Content = new StackLayout { Children = { gridLayout } };

        }
    }      
}
