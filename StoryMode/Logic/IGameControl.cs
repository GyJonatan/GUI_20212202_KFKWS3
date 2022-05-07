using static Halcyon.Logic.GameLogic;

namespace Halcyon.Logic
{
    internal interface IGameControl
    {
        void Move(Directions direction);
    }
}