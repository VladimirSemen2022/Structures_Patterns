using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_24._09._22_Patterns_Structures
{
    class User
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public User()
        {
            Name = string.Empty;
            Age = string.Empty;
        }

        public User(string name, string age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name:{Name} Age:{Age}";
        }
    }
}
