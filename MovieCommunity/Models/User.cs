

namespace MovieCommunity.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    public class User
    {
        string Name { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Birthday { get; set; }
        string User { get; set; }
        string Password { get; set; }

        public User(string Name, String LastName, string Email, string Birthday, string User, string Password)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Email = Email;
            this.Birthday = Birthday;
            this.User = User;
            this.Password = Password;
        }
    }
}