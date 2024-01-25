namespace Scoreboards.Data.Baseball
{
    public class BaseballTeamStats
    {
        private int runs = 0;

        public int Runs
        {
            get { 
                if(Linescore.Count >= 9)
                {
                    return Linescore.Sum(x => x.Runs);
                }
                return runs; }
            set { runs = value; }
        }

        public int Hits { get; set; }
        public int Errors { get; set; }

        public List<Halfinning> Linescore { get; set; } = new List<Halfinning>();
    }
}
