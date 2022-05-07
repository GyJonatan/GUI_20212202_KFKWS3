using static Metin2D.Logic.GameLogic;

namespace Metin2D.Logic
{
    public interface IGameLogic
    {

        public MapItems[,] GameMatrix { get; set; }
    }
}