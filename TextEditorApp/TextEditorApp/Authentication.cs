using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorApp
{
    class Authentication
    {
        private Hashtable user = new Hashtable();
        private string username, password;
        public Hashtable User { get => user; set => user = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public Authentication(string username, string password)
        {
            Username = username;
            Password = password;

            try
            {
                StreamReader userPool = new StreamReader("../../User Pool Data/login.txt");
                String data = userPool.ReadLine();
                while (data != null)
                {
                    string[] dataRow = data.Split(',');
                    User.Add(dataRow[0], new User(dataRow[0], dataRow[1], dataRow[3], dataRow[4], dataRow[2], DateTime.ParseExact(dataRow[5], "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture)));
                    data = userPool.ReadLine();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public bool Login()
        {
            bool isMatch = false;
            foreach(string key in User.Keys)
            {
                if(key == username)
                {
                    User user = (User)User[key];
                    if (password == user.Password)
                    {
                        isMatch = true;
                    }
                }
            }
            return isMatch;
        }
    }
}
