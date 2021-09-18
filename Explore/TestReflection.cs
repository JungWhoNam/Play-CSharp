using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Explore
{
    // https://qzqz.tistory.com/242?category=752329
    // https://nowonbun.tistory.com/488
    class TestReflection
    {
        static void Main(string[] args)
        {
            {
                int a = 0;
                Type type = a.GetType();

                FieldInfo[] fields = type.GetFields();
                foreach (FieldInfo field in fields)
                {
                    Console.WriteLine("Type:{0}, Name:{1}", field.FieldType.Name, field.Name);
                }
            }
            Console.WriteLine();

            {
                int a = 0;
                Type type = a.GetType();

                MethodInfo[] infos = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
                foreach (MethodInfo info in infos)
                {
                    Console.WriteLine("Type:{0}, Name:{1}", info.ReturnType.Name, info.Name);
                }
            }
            Console.WriteLine();

            {
                Type type = Type.GetType("LearningCSharp.Explore.Profile");
                MethodInfo methodInfo = type.GetMethod("Print");
                PropertyInfo nameProperty = type.GetProperty("Name");
                PropertyInfo phoneProperty = type.GetProperty("Phone");

                // 특정 형식의 인스턴스를 동적으로 만듬
                object profile = Activator.CreateInstance(type, "김나다", "123-4321");
                // 동적으로 메소드 호출
                methodInfo.Invoke(profile, null);

                // 동적으로 프로퍼티 및 인덱서 정보 담기
                profile = Activator.CreateInstance(type);
                nameProperty.SetValue(profile, "가나다", null);
                phoneProperty.SetValue(profile, "123-4567", null);
                methodInfo.Invoke(profile, null);
            }

            {
                AssemblyName aName = new AssemblyName("DynamicAssemblyExample");
            }
        }
    }

    class Profile
    {
        private string name;
        private string phone;

        public Profile()
        {
            name = ""; phone = "";
        }

        public Profile(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public void Print()
        {
            Console.WriteLine("{0}, {1}", name, phone);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }

}