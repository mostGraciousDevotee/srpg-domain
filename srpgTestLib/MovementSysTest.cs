using EntityImp;
using MovementImp;
using TurnSystemImp;

namespace Test
{
    public class MovementSysTest : BaseTest
    {
        public override bool Test()
        {
            var turnSys = new TurnSys();
            var squareCells = new SquareCells(32, 32, 2);
            var validMoveProvider = new ValidMoveProvider(squareCells);
            var movementSys = new MovementSys(turnSys, validMoveProvider);

            

            return false;
        }
    }
}