namespace Entity
{
    public interface IMoveable : IComponent
    {
        int MoveRange {get; }
        int CurrentMoveRange {get; }
        Position Position {get; }

        void Move(Position position, int moveRange);
        void Reset();
    }
}