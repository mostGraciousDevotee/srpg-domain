using Entity;

namespace EntityImp
{
    public class Moveable : IMoveable
    {
        int _moveRange;
        int _currentMoveRange;
        Position _position;

        public Moveable(int moveRange, Position position)
        {
            _moveRange = moveRange;
            _currentMoveRange = moveRange;
            _position = position;
        }
        
        public int MoveRange => _moveRange;
        public int CurrentMoveRange => _currentMoveRange;
        public Position Position => _position;

        public void Move(Position position, int moveRange)
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