using System;
using dynamicpage.Converters;
using dynamicpage.CustomControl;
using Xamarin.Forms;

namespace dynamicpage.View
{
    //public class StatusView:ViewCell
    //{
    //    public StatusView()
    //    {
    //        var gridLayout = new Grid { RowSpacing = 10, Padding = new Thickness(0, 0, 0, 0), Margin = new Thickness(10, 0), BackgroundColor = Color.Transparent };

    //        gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
    //        gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });

    //        gridLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(30, GridUnitType.Absolute) });
    //        var outerlayout = new StackLayout { Margin = 0, HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.Start };
    //        var layout = new StackLayout { Orientation = StackOrientation.Horizontal, Margin = 10, HorizontalOptions = LayoutOptions.FillAndExpand };
    //        var label1 = new CustomLabel { HorizontalOptions = LayoutOptions.StartAndExpand, WidthRequest = 130 };
    //        var label2 = new CustomLabel { HorizontalOptions = LayoutOptions.CenterAndExpand, WidthRequest = 130};
    //        label2.SetBinding(CustomLabel.BindingKeyProperty, new Binding(".", BindingMode.TwoWay,
    //                                            new DictionaryConverter(), 0, null,
    //                                            this.BindingContext));
    //        gridLayout.Children.Add(label1, 0, 0);
    //        gridLayout.Children.Add(label2, 1, 0);
    //        layout.Children.Add(label1);
    //        layout.Children.Add(label2);
    //        outerlayout.Children.Add(layout);
    //        Grid.SetColumnSpan(outerlayout, 2);
    //        gridLayout.Children.Add(outerlayout);
    //        View = gridLayout;
    //        this.Height = 30;
    //    }
    //}
    //public class LabelView : ViewCell
    //{
    //    public LabelView()
    //    {
    //        var gridLayout = new Grid { RowSpacing = 10, Padding = new Thickness(0, 0, 0, 0), Margin = new Thickness(10, 0), BackgroundColor = Color.Transparent };

    //        gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
    //        gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });

    //        gridLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
    //        var outerlayout = new StackLayout { Margin = 10 };
    //        var layout = new StackLayout
    //        { Orientation = StackOrientation.Horizontal, Margin = 0 };
    //        var label1 = new CustomLabel { HorizontalOptions = LayoutOptions.StartAndExpand, WidthRequest = 130 };
    //        label1.SetBinding(CustomLabel.BindingKeyProperty, new Binding(".", BindingMode.TwoWay,
    //                                            new DictionaryConverter(), 0, null,
    //                                            this.BindingContext));
    //        var label2 = new CustomLabel { HorizontalOptions = LayoutOptions.CenterAndExpand, WidthRequest = 130 };
    //        label2.SetBinding(CustomLabel.BindingKeyProperty, new Binding(".", BindingMode.TwoWay,
    //                                            new DictionaryConverter(), 1, null,
    //                                            this.BindingContext));
    //        gridLayout.Children.Add(label1, 0, 0);
    //        gridLayout.Children.Add(label2, 1, 0);
    //        layout.Children.Add(label1);
    //        layout.Children.Add(label2);
    //        outerlayout.Children.Add(layout);
    //        Grid.SetColumnSpan(outerlayout, 2);
    //        gridLayout.Children.Add(outerlayout);
    //        View = gridLayout;
    //        this.Height = 40;
    //    }
    //}
    //public class EditorView : ViewCell
    //{
    //    public EditorView()
    //    {
    //        var gridLayout = new Grid { RowSpacing = 10, Padding = new Thickness(0, 0, 0, 0), Margin = new Thickness(10, 0), BackgroundColor = Color.Transparent };

    //        gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
    //        gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });

    //        gridLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
    //        var outerlayout = new StackLayout { Margin = 0 };
    //        var layout = new StackLayout { Orientation = StackOrientation.Vertical, Margin = 10 };
    //        var label = new CustomLabel { HorizontalOptions = LayoutOptions.StartAndExpand };
    //        label.SetBinding(CustomLabel.BindingKeyProperty, new Binding(".", BindingMode.TwoWay,
    //                                           new DictionaryConverter(), 0, null,
    //                                           this.BindingContext));
    //        var entry = new CustomEditor
    //        {
    //            HorizontalOptions = LayoutOptions.FillAndExpand,
    //            VerticalOptions = LayoutOptions.StartAndExpand,
    //            HeightRequest = 100,
    //            IsEnabled = true,
    //            BackgroundColor = Color.Transparent,
    //            RoundedCornerRadius = 20,
    //            BorderWidth = 1,
    //            BorderColor = Color.Transparent
    //        };
    //        entry.SetBinding(Entry.TextProperty, new Binding(".", BindingMode.TwoWay,
    //                                           new DictionaryConverter(), 1, null,
    //                                           this.BindingContext));
    //        var frame = new CustomFrame { CornerRadius = 20, Content = entry, Padding = 0, HasShadow = true };
    //        gridLayout.Children.Add(label, 0, 0);
    //        gridLayout.Children.Add(frame, 0, 0);
    //        Grid.SetColumnSpan(frame, 2);
    //        layout.Children.Add(label);
    //        layout.Children.Add(frame);
    //        outerlayout.Children.Add(layout);
    //        Grid.SetColumnSpan(layout, 2);
    //        Grid.SetColumnSpan(outerlayout, 2);
    //        gridLayout.Children.Add(outerlayout);
    //        View = gridLayout;
    //        Height = 150;
    //    }
    //}
    //public class ButtonView : ViewCell
    //{
    //    public ButtonView()
    //    {
    //        var gridLayout = new Grid { RowSpacing = 0, Padding = new Thickness(0, 0, 0, 0), Margin = new Thickness(10, 0), BackgroundColor = Color.Transparent };

    //        gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
    //        gridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });

    //        gridLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
    //        var outerlayout = new StackLayout { Margin = new Thickness(0) };
    //        var layout = new StackLayout { Orientation = StackOrientation.Horizontal, Margin = 10 };
    //        var btn1 = new RoundedButtonLeft
    //        {
    //            HorizontalOptions = LayoutOptions.FillAndExpand,
    //            VerticalOptions = LayoutOptions.StartAndExpand,
    //            BackgroundColor = Color.Green,
    //            CornerRadius = 0,
    //            TextColor = Color.White
    //        };
    //        btn1.SetBinding(Button.TextProperty, new Binding(".", BindingMode.TwoWay,
    //                                           new DictionaryConverter(), 0, null,
    //                                           this.BindingContext));
    //        var btn2 = new RoundedButtonRight
    //        {
    //            HorizontalOptions = LayoutOptions.FillAndExpand,
    //            VerticalOptions = LayoutOptions.StartAndExpand,
    //            Text = "right",
    //            BackgroundColor = Color.Green,
    //            CornerRadius = 0,
    //            TextColor = Color.White
    //        };
    //        btn2.SetBinding(Button.TextProperty, new Binding(".", BindingMode.TwoWay,
    //                                           new DictionaryConverter(), 1, null,
    //                                           this.BindingContext));
    //        gridLayout.Children.Add(btn1, 0, 0);
    //        gridLayout.Children.Add(btn2, 1, 0);
    //        layout.Children.Add(btn1);
    //        layout.Children.Add(btn2);
    //        outerlayout.Children.Add(layout);
    //        Grid.SetColumnSpan(outerlayout, 2);
    //        gridLayout.Children.Add(outerlayout);
    //        View = gridLayout;

    //        if (Device.RuntimePlatform == Device.Android)
    //            Height = 60;
    //        else
    //            Height = 40;
    //    }
    //}
}
