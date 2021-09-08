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
