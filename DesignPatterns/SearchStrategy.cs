using System;

// 현 회사에서 사용되고 있는 서치 기능
namespace LearningCSharp.DesignPatterns.Adapter
{
    interface ISearchStrategy
    {
        public void Search();
    }

    class SearchStrategyNews : ISearchStrategy
    {
        public void Search()
        {
            Console.WriteLine("Searching News...");
        }
    }

    class SearchStrategyImages : ISearchStrategy
    {
        public void Search()
        {
            Console.WriteLine("Searching Images...");
        }
    }

    class SearchStrategyMaps : ISearchStrategy
    {
        public void Search()
        {
            Console.WriteLine("Searching Maps...");
        }
    }
}
