namespace Entity
{
    public interface ISquareCells
    {
        int Width {get; }
        int Length {get; }
        int CellSize {get; }

        void AddUnit(IUnit unit);
        IUnit? GetUnit(Vector2Int position);
        void RemoveUnit(IUnit unit);

        bool IsInside(Vector2Int position);
        bool IsOccupied(Vector2Int position);
    }
}