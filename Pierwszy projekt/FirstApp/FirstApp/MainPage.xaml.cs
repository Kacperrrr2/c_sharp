using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            mail.Text = "";
            password1.Text = "";
            password2.Text = "";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
       

            if (!mail.Text.Contains("@"))
            {
                Wyswietl.Text = "Nieprawidłowy adres e-mail";
                return;
            }

            if(!password1.Text.Contains(password2.Text)) 
            {
                Wyswietl.Text = "Hasła się różnią";
                return;
            }
            
            if(password1.Text.Contains(password2.Text))
            {
                Wyswietl.Text = "Witaj " + mail.Text;
                return;
            }
        }
    }
}
