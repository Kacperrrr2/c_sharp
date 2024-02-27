using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Cena(object sender, RoutedEventArgs e)
        {
            
            if((bool)Pocztowka.IsChecked==true)
            {
                ListZdj.Visibility = Visibility.Collapsed;
                PocztowkaZdj.Visibility = Visibility.Visible;
                PaczkaZdj.Visibility = Visibility.Collapsed;
                Cena.Text = "Cena: 10 zł";
               
            }
            if ((bool)List.IsChecked == true)
            {
                ListZdj.Visibility = Visibility.Visible;
                PocztowkaZdj.Visibility = Visibility.Collapsed;
                PaczkaZdj.Visibility= Visibility.Collapsed;
                Cena.Text = "Cena: 15 zł";
            }
            if ((bool)Paczka.IsChecked == true)
            {
                ListZdj.Visibility = Visibility.Collapsed;
                PocztowkaZdj.Visibility = Visibility.Collapsed;
                PaczkaZdj.Visibility = Visibility.Visible;
                    
                Cena.Text = "Cena: 20 zł";
            }
        }


        private void buttonZatwierdzanie_Click(object sender, EventArgs e)
        {
            string cos = textBoxKodPocztowy.Text;
            if (cos.Length != 5)
            {
                
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
            else if (Int32.TryParse(cos, out _) == false)
            {
                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr");
            }
            else
            {
                MessageBox.Show("Dane zostaly wprowadzone prawidłowo");
            }
        }


    }
}