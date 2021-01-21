using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using dynamicpage.Model;
using Xamarin.Forms;

namespace dynamicpage.View
{
    public class DynamicOrderList : ViewCell
    {
        //Label label;
       // Grid gridLayout;
        static List<Dictionary<string, LabelModel>> list;
        public DynamicOrderList()
        {
            SetViews();
        }
        public static void GetValues(List<Dictionary<string, LabelModel>> _list)
        {
            list = new List<Dictionary<string, LabelModel>>(_list);
        }


        public void SetViews()
        {

            var gridLayout = new Grid { RowSpacing = 10, Padding = new Thickness(0, 10, 0, 10) };

            gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });


            for (int i = 0; i < 3; i++)
            {
                gridLayout.RowDefinitions.Add(new RowDefinition
                {
                    Height = new GridLength(1, GridUnitType.Auto)
                });
            }
            //   gridLayout.SetBinding(Grid.BindingContextProperty, "Source");

            //    var productIndex = 0;
            //for(int i=0;i<3;i++)
            //{
            //    for(int j=0;j<3;j++)
            //    {
            //if (productIndex >= list.Count)
            //{
            //    break;
            //}

            var x = list.Count;

          //  for (int k = 0; k < x; k++)
          //  {
                var product = list[0];



                // foreach(var prod in list)


                foreach (var item in product)
                {
                    switch (item.Value.Key)
                    {
                        case "Entry":
                            var label = new Label
                            {
                                Text = item.Value.Data,
                                FontSize = 15,
                                VerticalOptions = LayoutOptions.Center,
                                HorizontalOptions = LayoutOptions.Center,
                                AutomationId = item.Value.ID,
                            };

                            //  label.SetBinding(Label.TextProperty,"Key");
                              label.SetBinding(Label.TextProperty,"Data");
                            gridLayout.Children.Add(label, item.Value.col, item.Value.row);
                            break;

                        case "Image":
                            var image = new Image
                            {
                                Source = "verify.png",
                                Margin = 0,
                                HeightRequest = 20,
                                WidthRequest = 30

                            };
                            //     image.SetBinding(Image.SourceProperty, "Value");
                            gridLayout.Children.Add(image, item.Value.col, item.Value.row);
                            break;

                        case "ImageBtn":
                            var imagebtn = new ImageButton
                            {
                                Source = "next.png",
                                Margin = 0,
                                HeightRequest = 20,
                                WidthRequest = 30,
                                BackgroundColor = Color.Transparent
                            };

                            //         imagebtn.SetBinding(ImageButton.SourceProperty, "Value");

                            gridLayout.Children.Add(imagebtn, item.Value.col, item.Value.row);
                            var tapGestureRecognizer = new TapGestureRecognizer();
                            tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, "TapCommand");
                            imagebtn.GestureRecognizers.Add(tapGestureRecognizer);
                            break;

                    }
                }

                View = new Frame
                {
                    Content = gridLayout,
                    CornerRadius = 10,
                    HasShadow = true,
                    VerticalOptions = LayoutOptions.StartAndExpand,
                    HorizontalOptions = LayoutOptions.Fill,
                    Margin = new Thickness(10, 5, 10, 0),
                    Padding = 0
                };
                View.BindingContext = this;

//            }
        }

        public string EventName
        {
            get { return (string)GetValue(EventNameProperty); }
            set { SetValue(EventNameProperty, value); }
        }

        public static readonly BindableProperty EventNameProperty = BindableProperty.Create("EventName", typeof(string),
            typeof(DynamicOrderList), "Name");


        private static void titleTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (DynamicOrderList)bindable;
           // var child=control.gridLayout.Children;
            //control..Text = newValue.ToString();
        }




        protected override void OnBindingContextChanged()
        {
          //  var child = this.gridLayout.Children;
            var x = GetValue(EventNameProperty);
           // Data = "missing";
            //  var x = label.BindingContext;
            base.OnBindingContextChanged();
        }
        protected override void OnParentSet()
        {
            foreach(var prod in list)
            {
                foreach(var item in prod)
                {
                  // foreach(var get in gridLayout.Children.)
                }
            }
            base.OnParentSet();
        }



    }
}
