using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// FindAlgorithm.cs B사에서 사용되고 있는 무비 서치 기능
namespace LearningCSharp.DesignPatterns.Adapter
{
    interface FindAlgorithm
    {
        public void Find(Boolean global);
    }

    class FindMovieAlgorithms : FindAlgorithm
    {
        public void Find(bool global)
        {
            Console.WriteLine("Finding movies... the scope is {0}.", global ? "global" : "local");
        }
    }
}
