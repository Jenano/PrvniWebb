using treninkovyDenik.Model;

namespace treninkovyDenik.Logic.Cvik
{
    public class Cvik : ICvik
    {

        private ICvikService cvikService;
        public Cvik(ICvikService cvikService)
        {
            this.cvikService = cvikService;
        }

        public IEnumerable<Cvik> GetActivities()
        {
            return cvikService.GetActivities();
        }
    }
}
