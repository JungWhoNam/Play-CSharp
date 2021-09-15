using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

// https://qzqz.tistory.com/231
// https://qzqz.tistory.com/234
namespace LearningCSharp.Explore
{
    delegate int Calc(int a, int b); // 람디식(무명 함수)을 담기 위한 목적
    delegate void DoSomething();
    delegate string Concat(string[] args);

    class TestLambda
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Rambda Expression (식 형식) ===");
            { // 람다식
                Calc calc = (int a, int b) => a + b;
                Console.WriteLine($"{calc(4, 3)}\n");
            }

            { // 매개 변수 형식 유추 람다식
                Calc calc = (a, b) => a + b;
                Console.WriteLine($"{calc(4, 3)}\n");
            }

            { // 익명 메서드
                Calc calc = delegate (int a, int b)
                {
                    return a + b;
                };
                Console.WriteLine($"{calc(4, 3)}\n");
            }

            Console.WriteLine("=== Rambda Expression (문 형식 = statement lambda expression) ===");
            { // 반환 형식이 없는 람다식 (식 형식은 반환 형식이 꼭 있음)
                DoSomething doIt = () =>
                {
                    Console.WriteLine("Hello");
                    Console.WriteLine("World");
                    Console.WriteLine();
                };
                doIt();
            }

            {  // 반환 형식이 있는 람다식
                Concat concat = (args) =>
                {
                    string result = "";
                    foreach (var arg in args)
                        result += arg;
                    return result;
                };
                string[] strs = new string[] { "Hello ", "World", "!" };
                Console.WriteLine($"{concat(strs)}\n");
            }

            Console.WriteLine("=== Func, Action ===");
            // Func, Action을 사용하면 delegate을 선언하는 사전 잡업 불필요
            // Func... 반환 형식이 있음
            // Action... 박환 형식이 없음
            {
                Func<int> func0 = () => 10;
                Func<int, int> func1 = (a) => a + a;
                Func<int, int, int> func2 = (a, b) => a + b;

                Console.WriteLine(func0());
                Console.WriteLine(func1(4));
                Console.WriteLine(func2(4, 3));
                Console.WriteLine();
            }
            {
                Action func0 = () => Console.WriteLine("Hello World!");

                int result = 0;
                Action<int> func1 = (a) => result = a + a; // 람다식 밖에 선언된 변수에 결과 저장

                Action<int, int> func2 = (a, b) => Console.WriteLine(a + b);

                func0();
                func1(4);
                Console.WriteLine(result);
                func2(3, 4);
                Console.WriteLine();
            }

            Console.WriteLine("=== 식 트리 (Expression 클래스) ===");
            // 식 트리는 코드를 데이터로 보관 가능 (파일 저장 및 네트워크을 통해 전송)
            // 또한 DB로 보내 실행 가능
            {
                // 1 * 2 + (x - y)
                Expression<Func<int, int, int>> expression = (a, b) => 1 * 2 + (a - b);
                Func<int, int, int> func = expression.Compile();

                Console.WriteLine("1 * 2 + ({0} - {1}) = {2}", 7, 8, func(7, 8));
                Console.WriteLine();
            }
        }
    }
}
