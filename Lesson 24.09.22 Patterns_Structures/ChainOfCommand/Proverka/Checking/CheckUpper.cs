using System.Linq;

namespace Lesson_24._09._22_Patterns_Structures.Proverka
{
    class CheckUpper : AbstractHandler
    {
        public bool SomeCheck(string txt) => txt.Any(char.IsUpper);

        public override object Handle(object request)
        {
            if (!SomeCheck(request.ToString()))
            {
                return "Password don`t exist upper word!";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
