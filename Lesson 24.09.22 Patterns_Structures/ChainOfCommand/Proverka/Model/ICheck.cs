
namespace Lesson_24._09._22_Patterns_Structures
{
    interface ICheck
    {
        ICheck SetNext(ICheck handler);

        object Handle(object request);
    }
}
