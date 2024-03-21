using TurnSystemImp;
using EntityImp;
using Entity;

namespace Test
{
    public class TurnSysTest : BaseTest
    {
        int _unitID;
        string? _unitName;
        
        public override bool Test()
        {
            var turnSys = new TurnSys();

            int adamID = 1;
            string adamName = "Adam";

            int bruceID = 2;
            string bruceName = "Bruce";

            var adam = new Unit(adamID, adamName);
            var bruce = new Unit(bruceID, bruceName);

            var adamReadiness = new ReadinessComponent(10);
            var bruceReadiness = new ReadinessComponent(12);

            adam.AddComponent<IReadiness>(adamReadiness);
            bruce.AddComponent<IReadiness>(bruceReadiness);

            turnSys.AddUnit(adam);
            turnSys.AddUnit(bruce);

            turnSys.UnitActive += OnUnitActive;

            turnSys.Start();
            
            bool firstTurn = Assert.AreEqual<int>
            (
                bruceID,
                _unitID,
                ErrorMessage + " at bruceID on start of turn"
            );

            turnSys.End();

            bool secondTurn = Assert.AreEqual<int>
            (
                adamID,
                _unitID,
                ErrorMessage + " at adamID on second turn"
            );
            
            return firstTurn &&
                secondTurn;
        }

        void OnUnitActive(int id, string unitName)
        {   
            _unitID = id;
            _unitName = unitName;
        }
    }
}
