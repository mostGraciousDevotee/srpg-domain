using Entity;
using EntityImp;

namespace Test
{
    public abstract class ValidCellProviderTest : BaseTest
    {   
        protected ISquareCells? _squareCells;
        protected IUnit? _adam;
        protected IUnit? _bruce;
        protected List<Vector2Int> _validCells = new List<Vector2Int>();
        
        public override bool Test()
        {
            CreateUnits();
            CreateSquareCells();

            _validCells = GetValidCells();
            
            bool notContainingNegativeCells = AssertNegativeCells();
            bool notContainingOutsideRange = AssertOutsideRangeCells();

            return notContainingNegativeCells &&
                notContainingOutsideRange &&
                IsValid();
        }

        private bool AssertOutsideRangeCells()
        {
            var outsideRangeVector = CreateOutsideRangeCell(_squareCells!.Width);
            
            return Assert.AreEqual<bool>
            (
                false,
                _validCells.Contains(outsideRangeVector),
                ErrorMessage + " at outside range cell"
            );
        }

        private void CreateUnits()
        {
            var unitRepo = new UnitRepo();
            _adam = unitRepo.GetUnit(1);
            _bruce = unitRepo.GetUnit(2);
        }
        
        void CreateSquareCells()
        {
            _squareCells = new SquareCells(32, 32, 2);
            _squareCells.AddUnit(_adam!);
            _squareCells.AddUnit(_bruce!);
        }

        bool AssertNegativeCells()
        {
            return Assert.AreEqual<bool>
            (
                false,
                _validCells.Contains(Vector2Int.down),
                ErrorMessage + " at not containing negative cells"
            );
        }

        protected abstract List<Vector2Int> GetValidCells();

        Vector2Int CreateOutsideRangeCell(int range)
        {
            var rangeVector = new Vector2Int(range, range);

            return rangeVector;
        }

        protected abstract bool IsValid();
    }
}