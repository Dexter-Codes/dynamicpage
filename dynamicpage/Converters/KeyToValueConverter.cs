using System;
using System.Collections.Generic;
using System.Globalization;
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

             //   Dictionary<string, string> param = new Dictionary<string, string>();
          //      param = (Dictionary<string, string>)test;

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
                    // foreach (var list in item)
                    // {
                    //if(item.IndexOf(list).Equals(test))
                    //{
                    //    foreach(var s in list)
                    //    {
                    //        var x = s.Value;
                    //        if (x != "Label")
                    //            text = x;
                    //    }
                    //}



                    //  foreach(var s in list)
                    //  {
                    //foreach (var k in param)
                    //{
                    //    var x = k.Value.Contains(s.Value);

                    //    if (x)
                    //    {
                    //        if (!s.Value.Equals("Label"))
                    //        {
                    //            text = s.Value;
                    //            goto here;
                    //        }
                    //    }
                    //}
                    //  }

                    //   }
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
