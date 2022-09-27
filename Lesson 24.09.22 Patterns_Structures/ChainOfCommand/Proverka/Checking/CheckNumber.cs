using System.Linq;

namespace Lesson_24._09._22_Patterns_Structures.Proverka
{
    class CheckNumber : AbstractHandler
    {
        public bool SomeCheck(string txt) => txt.Any(char.IsNumber);

        private ICheck _nextHandler;

        public override object Handle(object request)
        {
            if (!SomeCheck(request.ToString()))
            {
                return "Password don`t exist any number!";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
