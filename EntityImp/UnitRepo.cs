using Entity;

namespace EntityImp
{
    public class UnitRepo
    {
        Dictionary<int, IUnit> _unitRepo = new Dictionary<int, IUnit>();

        public UnitRepo()
        {
            CreateAdam();
            CreateBruce();
        }
        
        public IUnit GetUnit(int unitID)
        {
            return _unitRepo[unitID];
        }

        void CreateAdam()
        {
            var adam = new Unit(1, "Adam");
            var moveable = new Moveable(2, Vector2Int.zero);

            adam.AddComponent<IMoveable>(moveable);

            _unitRepo.Add(adam.ID, adam);
        }

        void CreateBruce()
        {
            var bruce = new Unit(2, "Bruce");
            var moveable = new Moveable(4, new Vector2Int(1, 0));

            bruce.AddComponent<IMoveable>(moveable);

            _unitRepo.Add(bruce.ID, bruce);
        }
    }
}