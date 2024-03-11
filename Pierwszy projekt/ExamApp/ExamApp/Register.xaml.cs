using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        private List<User> users;
        public Register(List<User> PersonalData)
        {
            users = PersonalData;
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           if(password.Text!=passwordreapet.Text) 
           {
                return;
           }
           if(users.Count > 0) 
           {
              foreach (var user in users) 
              {
                    if (login.Text == user.Login) 
                    {
                        return;
                    
                    }


              } 
           }
           if (true)
           {
               User person = new User(login.Text, password.Text);
               users.Add(person);
               Navigation.PopAsync(); 
                
           }
           
        }

    }
}