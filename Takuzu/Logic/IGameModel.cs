namespace Halcyon.TakuzuGame.Logic
{
    public interface IGameModel
    {
        int Dimension { get; }
        State[,] Map { get; }
        State[,] Solution { get; }
    }
}