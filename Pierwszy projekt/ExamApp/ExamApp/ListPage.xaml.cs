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
	public partial class ListPage : ContentPage
	{

        private ObservableCollection<string> items = new ObservableCollection<string>();
        public ListPage()
        {
           
            InitializeComponent();

            List.ItemsSource = items;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new AddPage(items));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (List.SelectedItem != null)
            {
                items.Remove(List.SelectedItem.ToString());
            }  
                
            
        }
    }
}