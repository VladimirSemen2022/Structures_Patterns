
namespace Lesson_24._09._22_Patterns_Structures.Proverka
{
    class CheckLength : AbstractHandler
    {
        public bool SomeCheck(string txt) => txt.Length < 5 ? false : true;

        private ICheck _nextHandler;

        public override object Handle(object request)
        {
            if (!SomeCheck(request.ToString()))
            {
                return "Password length is less than 5 words!";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
