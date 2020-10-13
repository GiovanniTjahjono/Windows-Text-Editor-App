using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorApp
{
    class Users
    {
        private IDictionary userPool = new Dictionary<string, User>();

        public IDictionary UserPool { get => userPool; set => userPool = value; }

        public Users()
        {
            ReadFile();
        }

        public void ReadFile()
        {
            try
            {
                StreamReader loginFile = new StreamReader("../../User Pool Data/login.txt");
                string data = loginFile.ReadLine();
                while (data != null)
                {
                    string[] dataRow = data.Split(',');
                    UserPool.Add(dataRow[0], new User(dataRow[0], dataRow[1], dataRow[3], dataRow[4], dataRow[2], DateTime.ParseExact(dataRow[5], "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture)));
                    data = loginFile.ReadLine();
                }
                loginFile.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public User Login(string username, string password)
        {
            User validUser = new User();
            foreach (string key in UserPool.Keys)
            {
                if (key == username)
                {
                    User user = (User)UserPool[key];

                    if (password == user.Password)
                    {
                        validUser = user;
                    }
                }
            }
            return validUser; 
        }
        public string createNewUser(User user)
        {
            bool isValid = true;
            string message = "";
            foreach (string key in UserPool.Keys)
            {
                if (key == user.Username)
                {
                    isValid = false;
                    message = "1";
                }
            }
            if (isValid)
            {
                UserPool.Add(user.Username, user);
                try
                {
                    string userPoolDataTemp = "";
                    foreach (string key in UserPool.Keys)
                    {
                        User eachUser = (User)UserPool[key];
                        userPoolDataTemp += eachUser.Username + "," +
                                            eachUser.Password + "," +
                                            eachUser.UserType + "," +
                                            eachUser.Firstname + "," +
                                            eachUser.Lastname + "," +
                                            eachUser.DateOfBirth.ToString("dd-MM-yyyy") + "\n";
                    }
                    File.WriteAllText("../../User Pool Data/login.txt", userPoolDataTemp);
                    message = "0";
                }
                catch (IOException e)
                {
                    message = e.Message;
                }
            }

            return message;
        }
    }
}
