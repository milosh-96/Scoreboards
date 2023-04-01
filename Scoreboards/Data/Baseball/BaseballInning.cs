namespace Scoreboards.Data.Baseball
{
    public class BaseballInning
    {
        public int InningNumber { get; set; } = 1;
        public int Outs { get; set; } = 0;
        public BaseballInningStateEnum State { get; set; } = BaseballInningStateEnum.Top;
   
    }
}
