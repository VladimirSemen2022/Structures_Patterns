using Lesson_24._09._22_Patterns_Structures.Proverka;
using System;

namespace Lesson_24._09._22_Patterns_Structures
{
    class Password
    {
        private static object MyPassword { get; set; } = "Rtew";

        public Password()
        {
            MyPassword = string.Empty;
        }

        public Password(string pass)
        {
            MyPassword = pass;
        }

        public static void CheckPassword(AbstractHandler handler)
        {
            var result = handler.Handle(MyPassword);

            if (result != null)
            {
                Console.Write($"{result.ToString()}");
            }
            else
            {
                Console.WriteLine($"Passwor is Ok");
            }
        }
    }

}
