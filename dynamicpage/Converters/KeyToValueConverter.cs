﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;


namespace dynamicpage.Converters
{
    public class KeyToValueConverter:IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                string text = "";
                List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();

                data = (List<Dictionary<string, string>>)value;

                Object test = (object)parameter;

                foreach (var item in data)
                {
                    if(data.IndexOf(item).Equals(test))
                    {
                        foreach (var s in item)
                        {
                            var x = s.Value;
                            if (x != "Label")
                            {
                                text = x;
                                break;
                            }

                        }
                    }
                  
                }
                return text;
            }
            else
                return "";
        }

        

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class DictionaryConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                string text = "";

                Dictionary<string, string> data = new Dictionary<string, string>();
                data = (Dictionary<string, string>)value;
               
                int index= System.Convert.ToInt32(parameter);

                List<string> val = (from d in data.Values select d).ToList();


                //Setting values to the label or entry based on the index.

                if (index == 0)
                {
                    text = val[1];
                }

                else
                {
                    text = val[2];
                }

                return text;
            }
            else

                return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
