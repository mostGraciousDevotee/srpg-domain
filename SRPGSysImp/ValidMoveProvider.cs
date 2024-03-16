using Entity;
using SRPGSysImp;

namespace MovementImp
{
    public class ValidMoveProvider : ValidCellProvider
    {
        public ValidMoveProvider(ISquareCells squareCells) : base(squareCells)
        {
        }

        protected override bool IsCellValid(Vector2Int pos)
        {
            return !_squareCells.IsOccupied(pos);
        }
    }
}