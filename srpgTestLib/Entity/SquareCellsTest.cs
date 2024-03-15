using EntityImp;
using Entity;

namespace Test
{
    public class SquareCellTest : BaseTest
    {
        public override bool Test()
        {
            var origin = new Position(0, 0);
            var oneZero = new Position(1, 0);
            var limit = new Position(32, 32);
            var negative = new Position(-1, 0);
            
            var expectedUnit = new Unit(1, "Adam");
            
            var expectedMoveable = new Moveable(2, origin);
            expectedUnit.AddComponent<IMoveable>(expectedMoveable);

            var squareCells = new SquareCells(32, 32, 2);
            squareCells.AddUnit(expectedUnit);
            
            var resultUnit = squareCells.GetUnit(origin);

            bool unitAddedAtOrigin = Assert.AreEqualRef<IUnit>
            (
                expectedUnit,
                resultUnit!,
                ErrorMessage + " at adding unit to square cells!"
            );

            bool originIsOccupied = Assert.AreEqual<bool>
            (
                true,
                squareCells.IsOccupied(origin),
                ErrorMessage + " at origin is occupied!"
            );

            resultUnit = squareCells.GetUnit(oneZero);
            
            bool getNullAtOneZero = Assert.AreEqualRef<IUnit>
            (
                null!,
                resultUnit!,
                ErrorMessage + " at getting unit in one zero"
            );

            squareCells.RemoveUnit(expectedUnit);
            resultUnit = squareCells.GetUnit(origin);

            bool getNullAtOrigin = Assert.AreEqualRef<IUnit>
            (
                null!,
                resultUnit!,
                ErrorMessage + " at getting unit after removal!"
            );

            bool originNotOccupied = Assert.AreEqual<bool>
            (
                false,
                squareCells.IsOccupied(origin),
                ErrorMessage + " at origin is not occupied!"
            );

            bool isOriginInside = Assert.AreEqual<bool>
            (
                true,
                squareCells.IsInside(origin),
                ErrorMessage + " at origin is inside"
            );

            bool isLimitInside = Assert.AreEqual<bool>
            (
                false,
                squareCells.IsInside(limit),
                ErrorMessage + " at limit is inside"
            );

            bool isNegativeInside = Assert.AreEqual<bool>
            (
                false,
                squareCells.IsInside(negative),
                ErrorMessage + " at negative is inside"
            );

            return unitAddedAtOrigin &&
                originIsOccupied &&
                getNullAtOneZero &&
                getNullAtOrigin &&
                originNotOccupied &&
                isOriginInside &&
                isLimitInside &&
                isNegativeInside;
        }
    }
}