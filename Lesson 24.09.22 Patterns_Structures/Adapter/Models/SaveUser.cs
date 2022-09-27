using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson_24._09._22_Patterns_Structures
{
    class SaveUser
    {
        private User Persone { get; set; }

        public SaveUser()
        {
            this.Persone = new User();
        }

        public SaveUser (User user)
        {
            this.Persone = user;
        }

        public void SaveMyUser(string fileName)
        {
            File.WriteAllText(fileName, JsonSerializer.Serialize<string>(this.Persone.ToString()));
        }
    }
}
