using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dynamicpage.Model;
using dynamicpage.View;
using PanCardView;
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

        public List<List<Dictionary<string,string>>> _test { get; set; }

        public List<List<Dictionary<string, string>>> Test
        {
            get { return _test; }
            set
            {
                _test = value;
                OnPropertyChanged("Test");
            }
        }

        public int rowHeight { get; set; } 


        public MainPage()
        {
            InitializeComponent();
            DynamicLayoutValues = new List<Dictionary<string, LabelModel>>();
            Test = new List<List<Dictionary<string, string>>>();
            // dummyMethod();
            FormData();
            DynamicForm.GetValues(Test);
            AddChildLayouts();
            this.Content.BindingContext = this;
        }

        public void AddChildLayouts()
        {
        
            if (Device.RuntimePlatform == Device.Android)
                rowHeight = rowHeight + 10;


            rowHeight = 200;

            Content = new StackLayout
            {
                Margin = new Thickness(5),
                Children = {
                    new ListView { ItemTemplate = new DataTemplate(typeof(DynamicForm)), ItemsSource = Test, Margin = new Thickness(0, 10, 0, 10), RowHeight = rowHeight, HasUnevenRows = false, SeparatorVisibility=SeparatorVisibility.None,InputTransparent=true,}
                }
                
            };

            this.BindingContext = Test;

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


        void dummyMethod()
        {
            var listItems = new List<List<Dictionary<string, string>>>();
            for (int index = 0; index < 6; index++)
            {
                var itemDict1 = new List<Dictionary<string, string>>();
                var item1 = new Dictionary<string, string>();
                item1["Type"] = "Label";
                item1["value"] = "12952";
                var item2 = new Dictionary<string, string>();
                item2["Type"] = "Label";
                item2["value"] = "Pending" + index.ToString();
                var item3 = new Dictionary<string, string>();
                item3["Type"] = "Label";
                item3["value"] = "ClientName" + index.ToString();
                var item4 = new Dictionary<string, string>();
                item4["Type"] = "Label";
                item4["value"] = "09/12/20" + index.ToString();
                var item5 = new Dictionary<string, string>();
                item5["Type"] = "Label";
                item5["value"] = "PropertyID -" + index.ToString();
                var item6 = new Dictionary<string, string>();
                item6["Type"] = "Label";
                item6["value"] = "770" + index;
                itemDict1.Add(item1);
                itemDict1.Add(item2);
                itemDict1.Add(item3);
                itemDict1.Add(item4);
                itemDict1.Add(item5);
                itemDict1.Add(item6);
                listItems.Add(itemDict1);
            }
            Test = listItems;


            foreach(var item in Test)
            {
                for(int j=0;j<item.Count;j++)
                {                    
                    if(j%2 == 0)
                    {
                        rowHeight = rowHeight + 35;
                    }
                }
                break;
            }
        }

        void FormData()
        {
            var listItems = new List<List<Dictionary<string, string>>>();
            for (int index = 0; index < 1; index++)
            {
                var itemDict1 = new List<Dictionary<string, string>>();
                var item0 = new Dictionary<string, string>();
                item0["Type"] = "Label";
                item0["value"] = "Complete";
                var item1 = new Dictionary<string, string>();
                item1["Type"] = "Label";
                item1["value"] = "OrderNo";
                var item2 = new Dictionary<string, string>();
                item2["Type"] = "Label";
                item2["value"] = "12355";
                var item3 = new Dictionary<string, string>();
                item3["Type"] = "Label";
                item3["value"] = "ClientName";
                var item4 = new Dictionary<string, string>();
                item4["Type"] = "Label";
                item4["value"] = "ClientName1" ;
                var item5 = new Dictionary<string, string>();
                item5["Type"] = "Label";
                item5["value"] = "PropertyName" ;
                var item6 = new Dictionary<string, string>();
                item6["Type"] = "Label";
                item6["value"] = "770" + index;
                var item7 = new Dictionary<string, string>();
                item7["Type"] = "Label";
                item7["value"] = "Address";
                var item8 = new Dictionary<string, string>();
                item8["Type"] = "Entry";
                item8["value"] = "Property13/Newark";
                var item9 = new Dictionary<string, string>();
                item9["Type"] = "Label";
                item9["value"] = "Notes";
                var item10 = new Dictionary<string, string>();
                item10["Type"] = "Entry";
                item10["value"] = "n/a";
                itemDict1.Add(item0);
                itemDict1.Add(item1);
                itemDict1.Add(item2);
                itemDict1.Add(item3);
                itemDict1.Add(item4);
                itemDict1.Add(item5);
                itemDict1.Add(item6);
                itemDict1.Add(item7);
                itemDict1.Add(item8);
                itemDict1.Add(item9);
                itemDict1.Add(item10);
                listItems.Add(itemDict1);
            }
            Test = listItems;
        }





    }
    }
