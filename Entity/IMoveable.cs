namespace Entity
{
    public interface IMoveable : IComponent
    {
        int MoveRange {get; }
        int CurrentMoveRange {get; }
        Vector2Int Position {get; }

        void Move(Vector2Int position, int moveRange);
        void Reset();
    }
}