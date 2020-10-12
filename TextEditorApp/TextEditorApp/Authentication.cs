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
        public Hashtable User { get => user; set => user = value; }

        public Authentication()
        {
            ReadFile();
        }
        public void ReadFile()
        {
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
                userPool.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string[] Login(string username, string password)
        {
            string isMatch = "FALSE";
            string userType = "";
            foreach (string key in User.Keys)
            {
                if (key == username)
                {
                    User user = (User)User[key];
                    
                    if (password == user.Password)
                    {
                        userType = user.UserType;
                        isMatch = "TRUE";
                    }
                }
            }
            string[] result = {isMatch.ToString(), userType, username};
            return result;
        }
        public string createNewUser(User user)
        {
            bool isValid = true;
            string message = "";
            foreach(string key in User.Keys)
            {
                if(key == user.Username)
                {
                    isValid = false;
                    message = "1";
                }
            }
            if(isValid)
            {
                User.Add(user.Username, user);
                try
                {
                    string userPoolDataTemp = "";
                    foreach (string key in User.Keys)
                    {
                        User eachUser = (User)User[key];
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
