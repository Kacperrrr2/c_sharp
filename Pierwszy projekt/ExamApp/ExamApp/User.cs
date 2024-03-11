using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp
{
    public class User
    {
        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }


        public string Login   
        {
            get { return login; }  
            set { login = value; }  
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string login;
        private string password;
    }
}
