using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson_24._09._22_Patterns_Structures
{
    class JSONToTXT : ITarget
    {
        public string Txt { get; set; }

        public JSONToTXT()
        {
            Txt = string.Empty;
        }

        public JSONToTXT(string txt)
        {
            Txt = txt;
        }

        public string GetRequest(string JSONFormate)
        {
            User newUser = new User();
            newUser = JsonSerializer.Deserialize<User>(JSONFormate);
                return newUser.ToString();
        }
    }
}
