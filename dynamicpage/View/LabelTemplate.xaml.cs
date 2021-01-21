using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using dynamicpage.Model;
using Xamarin.Forms;

namespace dynamicpage.View
{
    public partial class LabelTemplate : ContentView, INotifyPropertyChanged
    {
        public ObservableCollection<LabelModel> _dynamicLayoutValues { get; set; }
        public List<DataModel> data = new List<DataModel>();
     

        public ObservableCollection<LabelModel> DynamicLayoutValues
        {
            get { return _dynamicLayoutValues; }
            set
            {
                _dynamicLayoutValues = value;
                OnPropertyChanged("DynamicLayoutValues");
            }
        }
        public string Nodata => "nodata";

        public LabelTemplate()
        {
            InitializeComponent();
            this.Content.BindingContext = this;
            DynamicLayoutValues = new ObservableCollection<LabelModel>();
            GetData();
            SetValues();
        }
        public void SetValues()
        {
            for(int i=0;i<data.Count;i++)
            {

                if (data[i].fieldtype == "entry")
                {
                    DynamicLayoutValues.Add(new LabelModel
                    {                       
                        Key = data[i].fieldname,
                        Data = data[i].value,                       
                });
                }
            }
        }
        public void GetData()
        {
            data.Add(new DataModel
            {
                fieldname="CustomerName",
                fieldtype="entry",
                value="Haaris"                
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
