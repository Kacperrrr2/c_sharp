using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.Collections.ObjectModel;
>>>>>>> a65dda431107bb8458045d19c60a04619503de2f
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamApp
{
<<<<<<< HEAD
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
=======
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
>>>>>>> a65dda431107bb8458045d19c60a04619503de2f
        }
    }
}