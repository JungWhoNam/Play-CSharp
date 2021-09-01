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
            WriteLine(System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription);

            WriteLine(System.Math.PI);

            WriteLine(PI);

            WriteLine(s.Format("Area: {0:N2}\n", PI));

            ReadLine();
        }
    }
}