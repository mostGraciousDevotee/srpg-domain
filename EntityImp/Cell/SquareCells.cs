using Entity;

namespace EntityImp
{
    public class SquareCells : ISquareCells
    {
        int _width;
        int _length;
        int _cellSize;

        ICell[,] _cells;

        public SquareCells(int width, int length, int cellSize)
        {
            _width = width;
            _length = length;
            _cellSize = cellSize;

            _cells = new Cell[width, length];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < length; y++)
                {
                    _cells[x, y] = new Cell(new Vector2Int(x, y));
                }
            }
        }

        public event Action<IUnit>? UnitAdded;
        
        public int Width => _width;

        public int Length => _length;

        public int CellSize => _cellSize;

        public void AddUnit(IUnit unit)
        {
            var pos = unit.GetComponent<IMoveable>().Position;
            _cells[pos.x, pos.y].AddUnit(unit);

            UnitAdded?.Invoke(unit);
        }

        public IUnit? GetUnit(Vector2Int pos)
        {
            return _cells[pos.x, pos.y].GetUnit();
        }

        public void RemoveUnit(IUnit unit)
        {
            var pos = unit.GetComponent<IMoveable>().Position;
            _cells[pos.x, pos.y].RemoveUnit();
        }

        public bool IsInside(Vector2Int pos)
        {
            bool insideHorizontally = pos.x >= 0 && pos.x < _width;
            bool insideVertically = pos.y >= 0 && pos.y < _length;

            return insideHorizontally && insideVertically;
        }

        public bool IsOccupied(Vector2Int pos)
        {
            return _cells[pos.x, pos.y].IsOccupied;
        }
    }
}