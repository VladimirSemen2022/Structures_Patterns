using System.IO;
using System.Text.Json;

namespace Lesson_24._09._22_Patterns_Structures
{
    class Adapter : ITarget
    {
        public  User newUser { get; set; }

        public Adapter()
        {
            newUser = new User();
        }

        public Adapter(User user)
        {
            newUser = user;
        }

        public string GetRequest(string fileName)
        {
            string newStr = string.Empty;
            if (File.Exists(fileName))
            {
                newStr = File.ReadAllText(fileName);
                newStr = newStr.Replace("\"", "");
                string[] tmpStr = newStr.Split(':', ' ');

                User myUser = new User(tmpStr[1], tmpStr[3]);
                newUser = myUser;
                //return JsonSerializer.Serialize(newUser, new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
                return JsonSerializer.Serialize(newUser);
            }
            else
            return newStr;
        }
    }
}
