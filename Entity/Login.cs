

namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    public class Login
    {
        string Username;
        string Password;

        public Login(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        public void SetUsername(string username)
        {
            if (username.Length <= 10)
            {
                throw new Exception("This string is not enought to be an Username Account");
            }
            this.Username = username;
        }

        public string GetUsername()
        {
            return this.Username;
        }

        public void SetPassword(string password)
        {
            if (password.Length <= 10)
            {
                throw new Exception("This password is too short");
            }
            this.Password = password;
        }

        public string GetPassword()
        {
            return this.Password;
        }
    }
}
