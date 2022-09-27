using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson_24._09._22_Patterns_Structures
{
    class AdapterToJSON
    {
        public User newUser { get; set; }

        public AdapterToJSON()
        {
            newUser = new User();
        }

        public AdapterToJSON(User user)
        {
            newUser = user;
        }

        public void ReadFile(string fileName)
        {
            string newStr;
            if (File.Exists(fileName))
            {
                newStr = File.ReadAllText(fileName);
                string[] tmpStr = newStr.Split('/');
                User myUser = new User(tmpStr[1], tmpStr[3]);
                newUser = myUser;
            }
        }

        public string ConvertToJSON()
        {
            string tmp = JsonSerializer.Serialize(newUser);
            return tmp;
        } 
    }
}
