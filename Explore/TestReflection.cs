using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Explore
{
    class TestReflection
    {
        static void Main(string[] args)
        {
            int a = 0;
            Type type = a.GetType();

            {
                FieldInfo[] fields = type.GetFields();

                foreach (FieldInfo field in fields)
                {
                    Console.WriteLine("Type:{0}, Name:{1}", field.FieldType.Name, field.Name);
                }
            }
            Console.WriteLine();

            {
                MethodInfo[] infos = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
                foreach (MethodInfo info in infos)
                {
                    Console.WriteLine("Type:{0}, Name:{1}", info.ReturnType.Name, info.Name);
                }
            }
        }

    }
}