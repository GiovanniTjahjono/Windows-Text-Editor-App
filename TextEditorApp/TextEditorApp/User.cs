using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorApp
{
    class User
    {
        //initiate the properties
        string username, password, firstname, lastname, userType;
        DateTime dateOfBirth;

        //Setup Getter and Setter
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string UserType { get => userType; set => userType = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        //Initiate contructor for all properties
        public User(string username, string password, string firstname, string lastname, string userType, DateTime dateOfBirth)
        {
            Username = username;
            Password = password;
            Firstname = firstname;
            Lastname = lastname;
            UserType = userType;
            DateOfBirth = dateOfBirth;
        }

        //Initiate contructor for login
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool Login()
        {
            return true;
        }
    }
}
