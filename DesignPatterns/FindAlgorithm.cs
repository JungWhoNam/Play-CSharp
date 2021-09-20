using System;

// B사에서 사용하는 서치 기능
namespace LearningCSharp.DesignPatterns.Adapter
{
    interface IFindAlgorithm
    {
        public void Find(Boolean global);
    }

    class FindMovieAlgorithm : IFindAlgorithm
    {
        public void Find(bool global)
        {
            Console.WriteLine("Finding movies... the scope is {0}.", global ? "global" : "local");
        }
    }
}