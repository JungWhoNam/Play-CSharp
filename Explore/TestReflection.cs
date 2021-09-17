using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Explore
{
    // https://qzqz.tistory.com/242?category=752329
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

                object profile = Activator.CreateInstance(type, "김나다", "123-4321");
                methodInfo.Invoke(profile, null);

                profile = Activator.CreateInstance(type);
                nameProperty.SetValue(profile, "가나다", null);
                phoneProperty.SetValue(profile, "123-4567", null);
                methodInfo.Invoke(profile, null);

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