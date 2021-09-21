using System;
using System.Collections.Generic;


// https://jdm.kr/blog/228
// 단일 객채이든 객체들의 집합이든 같은 방법으로 취급
// 일부 또는 그룹을 표현하는 객체들을 트리 구조로 구성

// TODO
// for uniformity vs for type safety
// https://mygumi.tistory.com/343 
// another example
// https://dailyheumsi.tistory.com/193
// https://beomseok95.tistory.com/258
namespace LearningCSharp.DesignPatterns.Composite
{
    // Component: 모든 표현할 요소들의 추상적인 인터페이스
    interface INode
    {
        string Name { get; set; }

        void Print();
    }

    // Leaf: Component로 지정된 인터페이스를 구현
    class File : INode
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public File(string name)
        {
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine("File: " + _name);
        }
    }

    // Composite: Component 요소를 자식으로 가짐
    class Directory : INode
    {
        private string _name;
        private readonly List<INode> _children = new();

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Directory(string name)
        {
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine("Dir: " + _name);
            _children.ForEach(child => child.Print());
        }

        public void Add(INode node)
        {
            _children.Add(node);
        }
    }


    class FileAndDirectory
    {
        static void Main(string[] args)
        {
            Directory dir = new Directory("Dir");
            dir.Add(new File("File"));
            dir.Add(new Directory("SubDir"));
            dir.Print();
            Console.WriteLine();

            Directory secondDir = new Directory("Dir2");
            secondDir.Add(dir);
            secondDir.Print();
            Console.WriteLine();
        }
    }
}
