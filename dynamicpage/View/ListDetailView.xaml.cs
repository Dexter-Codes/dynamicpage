using System;
using System.Collections.Generic;
using dynamicpage.ViewModel;
using Xamarin.Forms;

namespace dynamicpage.View
{
    public partial class ListDetailView : ContentPage
    {
        ListDetailViewModel listDetailView;
        public ListDetailView()
        {
            InitializeComponent();
            listDetailView = new ListDetailViewModel();
            this.BindingContext = listDetailView;
        }
    }
}
