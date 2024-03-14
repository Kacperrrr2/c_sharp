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
		
       
        public ListPage()
        {

            InitializeComponent();
        }

        public ListPage(ObservableCollection<string> item)
        {
            InitializeComponent();
            List.ItemsSource = item;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new AddPage());
        }
    }
}