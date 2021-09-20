using LearningCSharp.DesignPatterns.Adapter;
using System;


// https://nowonbun.tistory.com/430?category=838281
// https://www.youtube.com/watch?v=lJES5TQTTWE&ab_channel=%EC%96%84%ED%8C%8D%ED%95%9C%EC%BD%94%EB%94%A9%EC%82%AC%EC%A0%84
namespace LearningCSharp.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ISearchStrategy[] searches = {
                new SearchStrategyNews(),
                new SearchStrategyImages(),
                new SearchStrategyMaps(),
                new SearchFindAdapter(new FindMovieAlgorithm()), // adapter 패턴을 사용해 B사의 서치 기능을 ISearchStrategy 처럼 사용
            };

            do
            {
                Console.WriteLine("Select the search mode:");
                Console.WriteLine("0: News, 1: Images, 2: Maps, 3: Movies");

                string str = Console.ReadLine();
                if (int.TryParse(str, out int mode) && (mode >= 0 && mode < searches.Length))
                {
                    searches[mode].Search();
                }

                Console.WriteLine("Press ENTER to continue or Press ESC to exit");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
