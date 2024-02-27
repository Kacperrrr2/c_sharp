using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Kółko_i_krzyżyk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            loscRuchow.Text = "ilosc ruchów " + iloscRuchow;
        }
        
        int iloscRuchow = 0;
        
        private void Button_Click_Zaznacz(object sender, RoutedEventArgs e)
        {
            Button b= (Button)sender;
            if (b.Tag.ToString()!="O"&& b.Tag.ToString() != "X")
            {
                if (iloscRuchow % 2 == 0)
                {
                    b.Content = "O";
                    b.Tag = "O";
                    iloscRuchow++;
                }
                else
                {
                    b.Content = "X";
                    b.Tag = "X";
                    iloscRuchow++;
                }
            }
            loscRuchow.Text = "ilość ruchów: " + iloscRuchow;
            SprawdzanieWygraniej(b);

            
        }



        private void SprawdzanieWygraniej(Button b)
        {
       
            if(bt1.Tag==bt2.Tag&& bt2.Tag ==bt3.Tag ||
                bt4.Tag == bt5.Tag && bt5.Tag == bt6.Tag ||
                bt7.Tag == bt8.Tag && bt8.Tag == bt9.Tag ||

                bt1.Tag ==bt4.Tag && bt4.Tag ==bt7.Tag ||
                bt2.Tag ==bt5.Tag &&  bt5.Tag ==bt8.Tag ||
                bt1.Tag ==bt5.Tag && bt5.Tag ==bt9.Tag ||

                bt3.Tag ==bt5.Tag && bt5.Tag ==bt7.Tag||
                bt3.Tag ==bt6.Tag && bt6.Tag==bt9.Tag
                )
            {
                
                MessageBox.Show("GRA ZAKONCZONA WYGRANA "+b.Content);
                return;
            }
            if (iloscRuchow == 9)
            {
                MessageBox.Show("GRA ZAKONCZONA REMISEM");
                return;
            }

        }

        private void Button_Click_Reset(object sender, RoutedEventArgs e)
        {
            bt1.Tag = 1;
            bt2.Tag = 2;
            bt3.Tag = 3;
            bt4.Tag = 4;
            bt5.Tag = 5;
            bt6.Tag = 6;
            bt7.Tag= 7;
            bt8.Tag = 8;
            bt9.Tag = 9;

            bt1.Content = null;
            bt2.Content = null;
            bt3.Content = null;
            bt4.Content = null;
            bt5.Content = null;
            bt6.Content = null;
            bt7.Content = null;
            bt8.Content=null;
            bt9.Content = null;
            iloscRuchow = 0;
            loscRuchow.Text = "ilosc ruchów " + iloscRuchow;

        }
    }
}
