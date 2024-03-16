using Entity;

namespace EntityImp
{
    public class Moveable : IMoveable
    {
        int _moveRange;
        int _currentMoveRange;
        Vector2Int _position;

        public Moveable(int moveRange, Vector2Int position)
        {
            _moveRange = moveRange;
            _currentMoveRange = moveRange;
            _position = position;
        }
        
        public int MoveRange => _moveRange;
        public int CurrentMoveRange => _currentMoveRange;
        public Vector2Int Position => _position;

        public void Move(Vector2Int position, int moveRange)
        {
            _position = position;
            _currentMoveRange -= moveRange;
        }

        public void Reset()
        {
            _currentMoveRange = _moveRange;
        }
    }
}