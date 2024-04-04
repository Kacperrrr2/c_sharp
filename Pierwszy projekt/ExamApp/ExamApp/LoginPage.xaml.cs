using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExamApp
{
    public partial class LoginPage : ContentPage
    {
        private List<User> PersonData;

        public LoginPage()
        {
            InitializeComponent();
            PersonData = new List<User>();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            foreach (var user in PersonData)
            {
                if (login.Text == user.Login && password.Text == user.Password)
                {
                    Navigation.PushAsync(new HomePage(login.Text));

                }


            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register(PersonData));
        }

       
    }
}
