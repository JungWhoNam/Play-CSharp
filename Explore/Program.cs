using static System.Math;
using static System.Console;

// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-directive
// using directive
// static and global modifiers
// global modifier는 C# 10 부터 나온 기능
// using alias

// C# 투토리얼이 C# 8이상을 타겟으로 함
namespace LearningCSharp.Explore
{
    using s = System.String;

    public class Program
    {
        static void Main(string[] args)
        {
            //WriteLine(System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription);

            //WriteLine(System.Math.PI);

            //WriteLine(PI);

            //WriteLine(s.Format("Area: {0:N2}\n", PI));

            //ReadLine();

            // boxing and unboxing
            {
                // boxing a value type... converts the value type to the type object (creates an object and copies the value). 
                // This create an object reference "o" on the stack that references a value of the type int on the heap.
                // so in the below example, the references of "i" and "o" will be different (even with implicit boxing). 

                int i = 123; // on the stack
                object o1 = i; // implicit boxing
                object o2 = (object)i; // explicit boxing


                WriteLine(ReferenceEquals(i, o1));
                WriteLine(ReferenceEquals(i, o2));

                i = (int)o1; //unboxing
                WriteLine(ReferenceEquals(i, o1));
            }
        }
    }
}

// stack and heap
