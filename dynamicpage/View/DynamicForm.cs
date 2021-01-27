using System;
using System.Collections.Generic;
using dynamicpage.Converters;
using dynamicpage.CustomControl;
using Xamarin.Forms;

namespace dynamicpage.View
{
    public class DynamicForm:ViewCell
    {
        static List<List<Dictionary<string, string>>> list;
        public DynamicForm()
        {
            CreateView();
        }
        public static void GetValues(List<List<Dictionary<string, string>>> _list)
        {
            list = new List<List<Dictionary<string, string>>>(_list);
        }
        public void CreateView()
        {
           
            var amp = list;
            var test = amp[0];
            StackLayout innerlayout = null;
            int colmCounter = 0;

            var gridLayout = new Grid { RowSpacing = 10, Padding = new Thickness(0, 10, 0, 10), Margin = 10 };

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
                            Placeholder="new text"
                        };
                        gridLayout.Children.Add(editor, colmCounter, 0);
                        innerlayout.Children.Add(editor);
                        Grid.SetColumnSpan(outerlayout, 2);
                        colmCounter=0;
                    }

            }
            gridLayout.Children.Add(outerlayout);
            View = gridLayout;
            //View = new Frame
            //{
            //    Content = gridLayout
            //};
            //View.Margin = 5;
        }
    }
}
