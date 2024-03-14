namespace Entity
{
    public interface ISquareCells
    {
        int Width {get; }
        int Length {get; }
        int CellSize {get; }

        void AddUnit(IUnit unit);

        bool IsInside(Position position);
        bool IsOccupied(Position position);
    }
}