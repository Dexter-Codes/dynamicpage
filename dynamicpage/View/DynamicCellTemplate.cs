using System;
using System.Collections.Generic;
using dynamicpage.Converters;
using dynamicpage.CustomControl;
using Xamarin.Forms;

namespace dynamicpage
{
    public class DynamicCellTemplate:ViewCell
    {
        static List<List<Dictionary<string, string>>> list;
        public DynamicCellTemplate()
        {
            CreateView();
        }
        //protected override void OnBindingContextChanged()
        //{
        //    CreateView();
        //}
       
        public static void GetValues(List<List<Dictionary<string, string>>> _list)
        {
            list = new List<List<Dictionary<string, string>>>(_list);
        }
       
        public void CreateView()
        {
            var gridLayout = new Grid { RowSpacing = 10, Padding = new Thickness(0, 10, 0, 10),Margin=10 };

            gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });

            gridLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            var outerlayout = new StackLayout { HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.Start };


            StackLayout innerlayout = null;
            int count = list.Count;
            var amp = list;
            int colmCounter = 0;
            KeyToValueConverter keyToValue = new KeyToValueConverter();

                var product = amp[0];
                for (int i = 0; i < product.Count; i++)
                {
                   

                    if (i % 2 == 0)
                    {
                        innerlayout = new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            HorizontalOptions = LayoutOptions.FillAndExpand
                        };
                        outerlayout.Children.Add(innerlayout);
                        colmCounter = 0;
                    }

                    object jj=null;
                    if (product[i].ContainsValue("Label"))
                    {
                        var x = product[i];

                    foreach(var item in x)
                    {
                        if(!item.Value.Equals("Label"))
                        {
                            jj = item.Value;
                        }
                    }
                   
                    var label = new CustomLabel
                    {
                        Text = "dummy" + i.ToString(),
                        FontSize = 15,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        Index = i.ToString(),
                        BindingKey = (string)jj,
                        WidthRequest=100,
                        Margin= new Thickness(10, 0, 0, 0)
                };

                    if (colmCounter % 2 == 0)
                    {
                        label.HorizontalOptions = LayoutOptions.Start;

                    }
                    else
                    {
                        label.HorizontalOptions = LayoutOptions.CenterAndExpand;
                       // label.Margin = new Thickness(10, 0, 0, 0);
                    }


                    //var test = label.BindingKey;
                    //object t1 = new object();
                    //t1 = test;
                    //  var test = x;
                    object t1 = new object();
                    t1 = i;
                   // t1 = test;

                    
                    label.SetBinding(CustomLabel.BindingKeyProperty, new Binding(".", BindingMode.TwoWay,
                                                new KeyToValueConverter(), t1, null,
                                                this.BindingContext));

                   // label.SetBinding(Label.TextProperty, ".",BindingMode.Default,null);


                    gridLayout.Children.Add(label, colmCounter, 1);
                    innerlayout.Children.Add(label);
                    Grid.SetColumnSpan(outerlayout, 2);
                    colmCounter++;
                    }
                }
           
            gridLayout.Children.Add(outerlayout);

                View = new CustomFrame
                {
                    Content = gridLayout,
                    CornerRadius = 10,
                    HasShadow = true,
                    VerticalOptions = LayoutOptions.StartAndExpand,
                    HorizontalOptions = LayoutOptions.Fill,
                    Margin = new Thickness(10, 5, 10, 5),
                    Padding = 0,
                    BorderColor=Color.Gray,
                    
                };
            this.View.Margin = 5;

        }

    }
}
