using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace dynamicpage.Model
{
    public class LabelModel:INotifyPropertyChanged
    {
        public string Key { get; set; }

    //    public string Data { get; set; }

        public int row { get; set; }
        public int col { get; set; }
        public string ID { get; set; }


        private string _data;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Data
        {
            get { return _data; }
            set
            {
                _data = value;
                OnPropertyChanged("Data");
            }
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        //public string Data { get; set; }

        //private static BindableProperty titleTextProperty = BindableProperty.Create(
        //                                                 propertyName: "Data",
        //                                                 returnType: typeof(string),
        //                                                 declaringType: typeof(LabelModel),
        //                                                 defaultValue: "",
        //                                                 defaultBindingMode: BindingMode.TwoWay,
        //                                                 propertyChanged: titleTextPropertyChanged);


        //private static void titleTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    var control = (LabelModel)bindable;
        //    control.label.Text = newValue.ToString();
        //}
    }
}
