using Lesson_24._09._22_Patterns_Structures.Proverka;
using System;
using System.Text;

namespace Lesson_24._09._22_Patterns_Structures
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pattern "Adapter" Адаптер

            User myUser = new User("Vladimir", "25");
            SaveUser saveOne = new SaveUser(myUser);
            saveOne.SaveMyUser("User.txt");

            Adapter newJson = new Adapter();
            string JSON = newJson.GetRequest("User.txt");
            Console.WriteLine(JSON);

            JSONToTXT Txt = new JSONToTXT();
            Console.WriteLine(Txt.GetRequest(JSON));
            Console.WriteLine();

            //Pattern "Chain of Command" Цепочка команд

            string pass = string.Empty;
            Console.WriteLine("CHECKING OF PASSWORD");
            Console.WriteLine("Input any password which contains more than 5 letters with upper-case letter, number and symbol (+, $, |, ^)");
            pass = Console.ReadLine();
            Password newPassword = new Password(pass);

            var upper = new CheckUpper();
            var numb = new CheckNumber();
            var symb = new CheckSymbol();
            var leng = new CheckLength();

            leng.SetNext(upper).SetNext(numb).SetNext(symb);
            Password.CheckPassword(leng);


        }
    }
}
