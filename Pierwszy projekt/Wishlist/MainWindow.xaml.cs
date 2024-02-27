using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wishlist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
        }
      
 

        #region informowanie bindowania

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion


        private string poleDoWpisywania;
        public string PoleDoWpisywania
        {
            get { return poleDoWpisywania; }
            set
            {
                poleDoWpisywania = value;
                OnPropertyChanged(nameof(PoleDoWpisywania));
            }
        }
        
        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add(PoleDoWpisywania);
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            listBox.Items.Remove(PoleDoWpisywania);
        }
    }
}
