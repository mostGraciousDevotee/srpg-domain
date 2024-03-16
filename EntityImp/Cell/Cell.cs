using Entity;

namespace EntityImp
{
    public class Cell : ICell
    {
        readonly Vector2Int _position;
        IUnit? _unit;

        public Cell(Vector2Int position)
        {
            _position = position;
        }
        
        public Vector2Int Position => _position;
        public bool IsOccupied => _unit != null;
        
        public void AddUnit(IUnit unit)
        {
            _unit = unit;
        }

        public IUnit? GetUnit()
        {
            return _unit;
        }

        public void RemoveUnit()
        {
            _unit = null;
        }
    }
}