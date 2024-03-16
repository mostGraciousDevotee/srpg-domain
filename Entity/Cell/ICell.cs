namespace Entity
{
    public interface ICell
    {
        Vector2Int Position {get; }
        bool IsOccupied {get; }

        void AddUnit(IUnit unit);
        IUnit? GetUnit();
        void RemoveUnit();
    }
}