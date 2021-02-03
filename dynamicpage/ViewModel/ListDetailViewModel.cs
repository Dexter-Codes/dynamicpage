using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace dynamicpage.ViewModel
{
    public class ListDetailViewModel: INotifyPropertyChanged
    {
        public List<Dictionary<string, string>> _orderDetail { get; set; }

        public List<Dictionary<string, string>> OrderDetail
        {
            get { return _orderDetail; }
            set
            {
                _orderDetail = value;
                OnPropertyChanged("OrderDetail");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public ListDetailViewModel()
        {
            OrderDetail = new List<Dictionary<string, string>>();
            SetData();
        }
        void SetData()
        {
            var itemDict = new List<Dictionary<string, string>>();
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
            itemDict.Add(item0);
            itemDict.Add(item1);
            itemDict.Add(item2);
            itemDict.Add(item3);
            itemDict.Add(item4);
            itemDict.Add(item5);
            itemDict.Add(item6);

            OrderDetail = itemDict;

        }
    }
}
