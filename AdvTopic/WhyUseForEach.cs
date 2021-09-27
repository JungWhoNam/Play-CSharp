using System;
using System.Collections.Generic;

namespace LearningCSharp.AdvTopic
{
    class WhyUseForEach
    {
        // the below approach can be simplified using functional programming (better readability)
        static void Main(string[] args)
        {
            new List<string> { "Han", "John", "Harry" }.ForEach(name => Console.WriteLine(name));

            int[,] doubleArray = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            foreach (int i in doubleArray)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();

            new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 3, 4 }, new List<int> { 5, 6 } }.ForEach(item => item.ForEach(innerItem => Console.Write(innerItem + " ")));
            Console.WriteLine();
        }

        //static void Main(string[] args)
        //{
        //    List<string> names = new List<string>();
        //    names.Add("Han");
        //    names.Add("John");
        //    names.Add("Harry");

        //    foreach (var name in names)
        //    {
        //        Console.WriteLine(name);
        //    }

        //    DisplayNames(names);
        //}

        //static void DisplayNames(List<string> names)
        //{
        //    foreach (var name in names)
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
    }
}
