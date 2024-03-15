namespace Entity
{
    public interface ICell
    {
        Position Position {get; }
        bool IsOccupied {get; }

        void AddUnit(IUnit unit);
        IUnit? GetUnit();
        void RemoveUnit();
    }
}