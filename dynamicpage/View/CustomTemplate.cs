using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using dynamicpage.Model;
using Xamarin.Forms;

namespace dynamicpage.View
{
    public class CustomTemplate : ContentView, INotifyPropertyChanged
    {
        public List<Dictionary<string, LabelModel>> _dynamicLayoutValues { get; set; }
        public List<DataModel> data = new List<DataModel>();

        public List<Dictionary<string, LabelModel>> task{get;set;}

        public List<Dictionary<string, LabelModel>> DynamicLayoutValues
        {
            get { return _dynamicLayoutValues; }
            set
            {
                _dynamicLayoutValues = value;
                OnPropertyChanged("DynamicLayoutValues");
            }
        }
        public string Nodata => "nodata";

        public CustomTemplate()
        {
            DynamicLayoutValues = new List<Dictionary<string, LabelModel>>();
            SetValues();
            DynamicOrderList.GetValues(DynamicLayoutValues);
            AddChildViews();
            GetData();
        }
        public void AddChildViews()
        {
            BindingContext = this;
            Content = new StackLayout
            {
                Margin = new Thickness(5),
                Children = {
                new ListView { ItemTemplate = new DataTemplate(typeof(DynamicOrderList)), ItemsSource = DynamicLayoutValues, Margin = new Thickness(0, 0, 0, 0),RowHeight=150 }
            }
            };
        }


        //private List<KeyValuePair<string, LabelModel>> return_list_of_dictionary()
        //{

        //    List<KeyValuePair<string, LabelModel>> _list = new List<KeyValuePair<string, LabelModel>>();

        //    Dictionary<string, LabelModel> _dictonary = new Dictionary<string, LabelModel>()
        //{
        //    {"Entry1",new LabelModel{ Key = "Entry", Value = "12952", row = 0, col = 0 } },
        //    {"Image2",new LabelModel{Key = "Image", Value = "verify.png", row = 0, col = 1 } },
        //    {"Entry3",new LabelModel{Key = "Entry", Value = "Client Name1", row = 1, col = 0} },
        //    {"Entry4",new LabelModel{Key = "Entry", Value = "09/12/2020", row = 1, col = 1 } },
        //    {"ImageBtn5",new LabelModel{Key = "ImageBtn", Value = "next.png", row = 1, col = 2  } },
        //    {"Entry6",new LabelModel{Key = "Entry", Value = "PropertyId-1", row = 2, col = 0 } },
        //    {"Entry7",new LabelModel{Key = "Entry", Value = "7999", row = 2, col = 1 } },

        //};



        //    foreach (KeyValuePair<string, LabelModel> i in _dictonary)
        //    {
        //        _list.Add(i);
        //    }

        //    return _list;

        //}





        public void SetValues()
        {
           
            DynamicLayoutValues.Add(new Dictionary<string, LabelModel>());
            DynamicLayoutValues.Add(new Dictionary<string, LabelModel>());
            DynamicLayoutValues[0].Add("Entry1",new LabelModel { Key = "Entry", Data = "12952", row = 0, col = 0 });
            DynamicLayoutValues[0].Add("Entry2", new LabelModel { Key = "Image", Data = "verify.png", row = 0, col = 1 });
            DynamicLayoutValues[0].Add("Entry3", new LabelModel { Key = "Entry", Data = "Client Name1", row = 1, col = 0 });
            DynamicLayoutValues[0].Add("Entry4", new LabelModel { Key = "Entry", Data = "09/12/2020", row = 1, col = 1 });
            DynamicLayoutValues[0].Add("Entry5", new LabelModel { Key = "ImageBtn", Data = "next.png", row = 1, col = 2 });
            DynamicLayoutValues[0].Add("Entry6", new LabelModel { Key = "Entry", Data = "PropertyId-1", row = 2, col = 0 });
            DynamicLayoutValues[0].Add("Entry7", new LabelModel { Key = "Entry", Data = "7999", row = 2, col = 1 });


            DynamicLayoutValues[1].Add("Entr1", new LabelModel { Key = "Entry", Data = "9999", row = 0, col = 0 });
            DynamicLayoutValues[1].Add("Entr2", new LabelModel { Key = "Image", Data = "verify.png", row = 0, col = 1 });
            DynamicLayoutValues[1].Add("Entr3", new LabelModel { Key = "Entry", Data = "Client Name2", row = 1, col = 0 });
            DynamicLayoutValues[1].Add("Entr4", new LabelModel { Key = "Entry", Data = "19/12/2020", row = 1, col = 1 });
            DynamicLayoutValues[1].Add("Entr5", new LabelModel { Key = "ImageBtn", Data = "next.png", row = 1, col = 2 });
            DynamicLayoutValues[1].Add("Entr6", new LabelModel { Key = "Entry", Data = "PropertyId-2", row = 2, col = 0 });
            DynamicLayoutValues[1].Add("Entr7", new LabelModel { Key = "Entry", Data = "899", row = 2, col = 1 });


            //  DynamicLayoutValues = list;
            //for (int i = 0; i < data.Count; i++)
            //{

            //    if (data[i].fieldtype == "entry")
            //    {
            //        DynamicLayoutValues.Add(new LabelModel
            //        {
            //            Key = data[i].fieldname,
            //            Value = data[i].value,
            //        });
            //    }
            //}
        }
        public void GetData()
        {
            data.Add(new DataModel
            {
                fieldname = "CustomerName",
                fieldtype = "entry",
                value = "Haaris"
            });
            data.Add(new DataModel
            {
                fieldname = "OrderNumber",
                fieldtype = "entry",
                value = "23434"
            });
            data.Add(new DataModel
            {
                fieldname = "CustomerAddress",
                fieldtype = "entry",
                value = "Paris"
            });


         //   task.Add();


        }
        //public void AddValues()
        //{
        //    // Dictionary<string, string> keys = new Dictionary<string, string>();
        //    for(int i=0;i<5;i++)
        //    {
        //        test[i].Add("labelk","labelv");
        //    }

        //    //  test.Add(keys);

        //    foreach (var item in test)
        //    {

        //        labelModels.Add(new LabelModel
        //        {

        //        });
        //    }

        //}
    }
}
