using Entity;

namespace EntityImp
{
    public class Cell : ICell
    {
        readonly Position _position;
        IUnit? _unit;

        public Cell(Position position)
        {
            _position = position;
        }
        
        public Position Position => _position;
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