using static Halcyon.StoryMode.Logic.GameLogic;

namespace Halcyon.StoryMode.Logic
{
    internal interface IGameControl
    {
        void Move(Directions direction);
    }
}