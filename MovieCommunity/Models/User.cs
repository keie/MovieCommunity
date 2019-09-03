

namespace MovieCommunity.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    public class User
    {
        string Name;
        string LastName;
        string Email;
        DateTime Birthday;
        string Username;
        string Password;

        public void setName(string name)
        {
            this.Name=name;
        }

        public string getName()
        {
            return Name;
        }

        public void setLastName(string lastName)
        {
            this.LastName = LastName;
        }

        public string getLastName()
        {
            return LastName;
        }

        public void setEmail(string email)
        {
            this.Email = email;
        }

        public string getEmail()
        {
            return Email;
        }

        public void setBirthday(DateTime birthday)
        {
            this.Birthday = birthday;
        }

        public DateTime getBirthday()
        {
            return Birthday;
        }

        public void setUsername(string username)
        {
            this.Username = username;
        }

        public string getUsername()
        {
            return Username;
        }

        public void setPassword(string password)
        {
            this.Password = password;
        }

        public string getPassword()
        {
            return Password;
        }
        public User(string Name, String LastName, string Email, DateTime Birthday, string Username, string Password)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Email = Email;
            this.Birthday = Birthday;
            this.Username = Username;
            this.Password = Password;
        }
    }
}