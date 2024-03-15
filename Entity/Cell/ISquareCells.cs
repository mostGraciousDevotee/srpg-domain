namespace Entity
{
    public interface ISquareCells
    {
        int Width {get; }
        int Length {get; }
        int CellSize {get; }

        void AddUnit(IUnit unit);
        IUnit? GetUnit(Position position);
        void RemoveUnit(IUnit unit);

        bool IsInside(Position position);
        bool IsOccupied(Position position);
    }
}