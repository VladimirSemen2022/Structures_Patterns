
namespace Lesson_24._09._22_Patterns_Structures.Proverka
{
    abstract class AbstractHandler : ICheck
    {
        private ICheck _nextHandler;

        public ICheck SetNext(ICheck handler)
        {
            this._nextHandler = handler;
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}
