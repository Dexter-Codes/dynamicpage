using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dynamicpage.Model;
using dynamicpage.View;
using Xamarin.Forms;

namespace dynamicpage
{
    public partial class MainPage : ContentPage
    {

        public List<Dictionary<string, LabelModel>> _dynamicLayoutValues { get; set; }


        public List<Dictionary<string, LabelModel>> DynamicLayoutValues
        {
            get { return _dynamicLayoutValues; }
            set
            {
                _dynamicLayoutValues = value;
                OnPropertyChanged("DynamicLayoutValues");
            }
        }



        public MainPage()
        {
            InitializeComponent();
            DynamicLayoutValues = new List<Dictionary<string, LabelModel>>();
            SetValues();
            DynamicOrderList.GetValues(DynamicLayoutValues);
            AddChildLayouts();
           // AddChildViews();
            this.Content.BindingContext = this;
        }

        public void AddChildLayouts()
        {
            //plot.ItemsSource = DynamicLayoutValues;
            // plot.RowHeight = 120;
            // Parent.Children.Add(new CustomTemplate());
            Content = new StackLayout
            {
                Margin = new Thickness(5),
                Children = {
                new ListView { ItemTemplate = new DataTemplate(typeof(DynamicOrderList)), ItemsSource = DynamicLayoutValues, Margin = new Thickness(0, 0, 0, 0),RowHeight=150 }
            }
            };
        }
        public void SetValues()
        {

            DynamicLayoutValues.Add(new Dictionary<string, LabelModel>());
            DynamicLayoutValues.Add(new Dictionary<string, LabelModel>());
            DynamicLayoutValues[0].Add("Entry1", new LabelModel { Key = "Entry", Data = "12952", row = 0, col = 0,ID="1" });
            DynamicLayoutValues[0].Add("Entry2", new LabelModel { Key = "Image", Data = "verify.png", row = 0, col = 1,ID="2" });
            DynamicLayoutValues[0].Add("Entry3", new LabelModel { Key = "Entry", Data = "Client Name1", row = 1, col = 0, ID = "3" });
            DynamicLayoutValues[0].Add("Entry4", new LabelModel { Key = "Entry", Data = "09/12/2020", row = 1, col = 1, ID = "4" });
            DynamicLayoutValues[0].Add("Entry5", new LabelModel { Key = "ImageBtn", Data = "next.png", row = 1, col = 2 , ID = "5" });
            DynamicLayoutValues[0].Add("Entry6", new LabelModel { Key = "Entry", Data = "PropertyId-1", row = 2, col = 0, ID = "6" });
            DynamicLayoutValues[0].Add("Entry7", new LabelModel { Key = "Entry", Data = "7999", row = 2, col = 1 , ID = "7" });


            DynamicLayoutValues[1].Add("Entr1", new LabelModel { Key = "Entry", Data = "9999", row = 0, col = 0, ID = "8" });
            DynamicLayoutValues[1].Add("Entr2", new LabelModel { Key = "Image", Data = "verify.png", row = 0, col = 1 , ID = "9" });
            DynamicLayoutValues[1].Add("Entr3", new LabelModel { Key = "Entry", Data = "Client Name2", row = 1, col = 0 , ID = "20" });
            DynamicLayoutValues[1].Add("Entr4", new LabelModel { Key = "Entry", Data = "19/12/2020", row = 1, col = 1, ID = "21" });
            DynamicLayoutValues[1].Add("Entr5", new LabelModel { Key = "ImageBtn", Data = "next.png", row = 1, col = 2, ID = "22" });
            DynamicLayoutValues[1].Add("Entr6", new LabelModel { Key = "Entry", Data = "PropertyId-2", row = 2, col = 0, ID = "24" });
            DynamicLayoutValues[1].Add("Entr7", new LabelModel { Key = "Entry", Data = "899", row = 2, col = 1, ID = "23" });
        }
        }
    }
