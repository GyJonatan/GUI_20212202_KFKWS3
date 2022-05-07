using static Halcyon.Logic.GameLogic;

namespace Halcyon.Logic
{
    public interface IGameLogic
    {

        public MapItems[,] GameMatrix { get; set; }
    }
}