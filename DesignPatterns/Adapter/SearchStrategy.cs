using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// SearchStartegy.cs 현 회사에서 사용되고 있는 서치 기능
// 현 회사에서 B사의 무비 서치 기능도 추가로 서포트 (adapter 패턴 활용)
namespace LearningCSharp.DesignPatterns.Adapter
{
    interface SearchStrategy
    {
        public void Search();
    }

    class SearchStrategyNews : SearchStrategy
    {
        public void Search()
        {
            Console.WriteLine("Searching News...");
        }
    }

    class SearchStrategyImages : SearchStrategy
    {
        public void Search()
        {
            Console.WriteLine("Searching Images...");
        }
    }

    class SearchStrategyMaps : SearchStrategy
    {
        public void Search()
        {
            Console.WriteLine("Searching Maps...");
        }
    }

    // 어탑터 기능 구현
    class SearchFindAdapter : SearchStrategy
    {
        private FindAlgorithm findAlgorithm;

        public SearchFindAdapter(FindAlgorithm findAlgorithm)
        {
            this.findAlgorithm = findAlgorithm;
        }

        public void Search()
        {
            this.findAlgorithm.Find(true);
        }
    }
}
