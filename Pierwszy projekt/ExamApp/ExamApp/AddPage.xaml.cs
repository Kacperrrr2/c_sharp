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
        public ObservableCollection<string> item = new ObservableCollection<string>();
        public AddPage ()
		{   
            InitializeComponent();  
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            item.Add(value.Text);
            Navigation.PushAsync(new ListPage(item));
        }
    }
}