using EntityImp;
using Entity;

namespace Test
{
    public class SquareCellTest : BaseTest
    {
        IUnit _expectedUnit = new Unit(1, "Adam");

        IUnit? _eventUnit;
        IUnit? _originUnit;
        IUnit? _oneZeroUnit;

        Vector2Int _origin = new Vector2Int(0, 0);
        Vector2Int _oneZero = new Vector2Int(1, 0);
        Vector2Int _limit = new Vector2Int(32, 32);
        Vector2Int _negative = new Vector2Int(-1, 0);

        ISquareCells _squareCells = new SquareCells(32, 32, 2);

        
        public override bool Test()
        {            
            Build();

            bool cellValidatedCorrectly = AssertCellValidatedCorrectly();

            AddUnit();
            bool unitAddedAtOriginCorrectyly = AssertUnitAddedAtOriginCorrectly();

            RemoveUnit();
            bool unitRemovedCorrectly = AssertUnitRemovedCorrectly();


            return unitAddedAtOriginCorrectyly &&
                unitRemovedCorrectly &&
                cellValidatedCorrectly;
        }

        void Build()
        {
            var expectedMoveable = new Moveable(2, _origin);
            _expectedUnit.AddComponent<IMoveable>(expectedMoveable);
        }

        #region Operation
            void AddUnit()
            {
                _squareCells.UnitAdded += OnUnitAdded;
                _squareCells.AddUnit(_expectedUnit);
    
                _originUnit = _squareCells.GetUnit(_origin);
                _oneZeroUnit = _squareCells.GetUnit(_oneZero);
            }
    
            void OnUnitAdded(IUnit unit)
            {
                _eventUnit = unit;
            }
    
            private void RemoveUnit()
            {
                _squareCells.RemoveUnit(_expectedUnit);
                _originUnit = _squareCells.GetUnit(_origin);
            }
        #endregion

        #region UnitAdditionTest
            bool AssertUnitAddedAtOriginCorrectly()
            {
                bool eventUnitAdded = AssertEventUnitAdded();
                bool unitAddedAtOrigin = AssertUnitAddedAtOrigin();
                bool originIsOccupied = AssertOriginIsOccupied();
                bool getNullAtOneZero = AssertOneZeroNull();
    
                return eventUnitAdded &&
                    unitAddedAtOrigin &&
                    originIsOccupied &&
                    getNullAtOneZero;
            }
            
            bool AssertEventUnitAdded()
            {
                return Assert.AreEqualRef<IUnit?>
                (
                    _expectedUnit,
                    _eventUnit,
                    ErrorMessage + " at unit added event!"
                );
            }
    
            bool AssertUnitAddedAtOrigin()
            {
                return Assert.AreEqualRef<IUnit>
                (
                    _expectedUnit,
                    _originUnit!,
                    ErrorMessage + " at adding unit to square cells!"
                );
            }
    
            bool AssertOriginIsOccupied()
            {
                return Assert.AreEqual<bool>
                (
                    true,
                    _squareCells.IsOccupied(_origin),
                    ErrorMessage + " at origin is occupied!"
                );
            }
    
            bool AssertOneZeroNull()
            {
                return Assert.AreEqualRef<IUnit>
                (
                    null!,
                    _oneZeroUnit!,
                    ErrorMessage + " at getting unit in one zero"
                );
            }
        #endregion

        #region UnitRemovalTest
            bool AssertUnitRemovedCorrectly()
            {
                bool getNullAtOrigin = AssertNullAtOrigin();
                bool originNotOccupied = AssertOriginNotOccupied();
    
                return getNullAtOrigin &&
                    originNotOccupied;
            }
    
            bool AssertNullAtOrigin()
            {
                return Assert.AreEqualRef<IUnit>
                (
                    null!,
                    _originUnit!,
                    ErrorMessage + " at getting unit after removal!"
                );
            }
    
            bool AssertOriginNotOccupied()
            {
                return Assert.AreEqual<bool>
                (
                    false,
                    _squareCells.IsOccupied(_origin),
                    ErrorMessage + " at origin is not occupied!"
                );
            }
        #endregion

        #region CellValidationTest
            bool AssertCellValidatedCorrectly()
            {
                bool isOriginInside = AssertOriginIsInside();
                bool isLimitInside = AssertLimitIsInside();
                bool isNegativeInside = AssertNegativeNotInside();
    
                return isOriginInside &&
                    isLimitInside &&
                    isNegativeInside;
            }
    
            bool AssertOriginIsInside()
            {
                return Assert.AreEqual<bool>
                (
                    true,
                    _squareCells.IsInside(_origin),
                    ErrorMessage + " at origin is inside"
                );
            }
    
            bool AssertLimitIsInside()
            {
                return Assert.AreEqual<bool>
                (
                    false,
                    _squareCells.IsInside(_limit),
                    ErrorMessage + " at limit is inside"
                );
            }
    
            bool AssertNegativeNotInside()
            {
                return Assert.AreEqual<bool>
                (
                    false,
                    _squareCells.IsInside(_negative),
                    ErrorMessage + " at negative is inside"
                );
            }
        #endregion
    }
}