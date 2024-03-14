using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPage : ContentPage
    {
        private ObservableCollection<string> items;

        public AddPage(ObservableCollection<string> existingItems)
        {
            items = existingItems;
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string newItem = value.Text;
            items.Add(newItem);
            Navigation.PopAsync();
        }
    }
}