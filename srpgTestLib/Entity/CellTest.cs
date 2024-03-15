using Entity;
using EntityImp;

namespace Test
{
    public class CellTest : BaseTest
    {
        public override bool Test()
        {
            int id = 1;
            string name = "Adam";
            var expectedUnit = new Unit(id, name);
            IUnit? resultUnit;

            var origin = new Position(0, 0);
            var cell = new Cell(origin);

            cell.AddUnit(expectedUnit);
            resultUnit = cell.GetUnit();

            bool correctUnit = Assert.AreEqualRef<IUnit>
            (
                expectedUnit,
                resultUnit!,
                ErrorMessage + " at correct unit!"
            );

            cell.RemoveUnit();

            resultUnit = cell.GetUnit();

            bool unitRemoved = Assert.AreEqualRef<IUnit>
            (
                null!,
                resultUnit!,
                ErrorMessage + " at unit removed!"
            );

            return correctUnit &&
                unitRemoved;
        }
    }
}