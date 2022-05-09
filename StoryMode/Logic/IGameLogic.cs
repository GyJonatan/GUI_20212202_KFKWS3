using static Halcyon.StoryMode.Logic.GameLogic;

namespace Halcyon.StoryMode.Logic
{
    public interface IGameLogic
    {
        public MapItems[,] GameMatrix { get; set; }
    }
}