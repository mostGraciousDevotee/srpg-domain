using Entity;
using MovementImp;

namespace Test
{
    public class MoveCellProviderTest : ValidCellProviderTest
    {   
        protected override List<Vector2Int> GetValidCells()
        {
            var moveable = _adam!.GetComponent<IMoveable>();
            var range = moveable.CurrentMoveRange;
            var pos = moveable.Position;
            
            var cellProvider = new ValidMoveProvider(_squareCells!);

            return cellProvider.GetValidCells(pos, range);
        }

        protected override bool IsValid()
        {
            bool notContainingAdam = AssertNotContainingAdam();
            bool notContainingBruce = AssertNotContainingBruce();

            var adamRange = _adam!.GetComponent<IMoveable>().CurrentMoveRange;
            var insideMoveRangeCell = new Vector2Int(0, adamRange);
            var outsideMoveRangeCell = new Vector2Int(0, adamRange + 1);
            
            bool insideMoveMoveRange = AssertInsideMoveRange(insideMoveRangeCell);
            bool notOutsideMoveRange = AssertNotOutsideMoveRange(outsideMoveRangeCell);

            return notContainingAdam &&
                notContainingBruce &&
                insideMoveMoveRange &&
                notOutsideMoveRange;
        }

        bool AssertNotContainingAdam()
        {
            return Assert.AreEqual<bool>
            (
                false,
                _validCells.Contains(_adam!.GetComponent<IMoveable>().Position),
                ErrorMessage + " at Adam position!"
            );
        }

        bool AssertNotContainingBruce()
        {
            return Assert.AreEqual<bool>
            (
                false,
                _validCells.Contains(_bruce!.GetComponent<IMoveable>().Position),
                ErrorMessage + " at Bruce position!"
            );
        }

        bool AssertInsideMoveRange(Vector2Int insideMoveRangeCell)
        {
            return Assert.AreEqual<bool>
            (
                true,
                _validCells.Contains(insideMoveRangeCell),
                ErrorMessage + " at inside move range"
            );
        }

        bool AssertNotOutsideMoveRange(Vector2Int outsideMoveRangeCell)
        {
            return Assert.AreEqual<bool>
            (
                false,
                _validCells.Contains(outsideMoveRangeCell),
                ErrorMessage + " at outside move range"
            );
        }
    }
}