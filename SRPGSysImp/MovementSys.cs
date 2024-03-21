using Entity;
using MovementSystem;
using CellSystem;
using TurnSystemImp;

namespace MovementImp
{
    public class MovementSys : IMovementSys
    {
        ITurnSys _turnSys;
        IValidCellProvider _moveCellProvider;
        List<Vector2Int> _currentValidCells = new List<Vector2Int>();
        
        public MovementSys(ITurnSys turnSys, IValidCellProvider moveCellProvider)
        {
            if (_turnSys == null)
            {
                throw new Exception("Turn sys is null at MovementSys!");
            }
            _turnSys = turnSys;

            if (_moveCellProvider == null)
            {
                throw new Exception("MoveCellProvider is null at MovementSys!");
            }
            _moveCellProvider = moveCellProvider;
        }

        public event Action<List<Vector2Int>>? MovementDisplayed;
        
        // TODO : TurnSys should pass moveable
        public void DisplayMovement()
        {
            var moveable = _turnSys.Current!.GetComponent<IMoveable>();
            _currentValidCells = _moveCellProvider.GetValidCells(moveable.Position, moveable.CurrentMoveRange);

            MovementDisplayed?.Invoke(_currentValidCells);
        }
    }
}