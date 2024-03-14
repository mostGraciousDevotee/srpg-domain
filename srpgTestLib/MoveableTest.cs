using EntityImp;
using Entity;

namespace Test
{
    public class MoveableTest : BaseTest
    {
        public override bool Test()
        {
            int id = 1;
            string name = "Adam";
            
            var adam = new Unit(id, name);

            var moveRange = 2;
            var origin = new Position(0, 0);
            var adamMoveable = new Moveable(moveRange, origin);

            // TODO : Implement equality operatior for Position struct

            return false;
        }
    }
}