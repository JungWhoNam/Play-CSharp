

// 현 회사에서 B사의 무비 서치 기능도 추가로 서포트 (adapter 패턴 활용)
namespace LearningCSharp.DesignPatterns.Adapter
{
    class SearchFindAdapter : ISearchStrategy
    {
        private IFindAlgorithm findAlgorithm;

        public SearchFindAdapter(IFindAlgorithm findAlgorithm)
        {
            this.findAlgorithm = findAlgorithm;
        }

        public void Search()
        {
            this.findAlgorithm.Find(true);
        }
    }
}
