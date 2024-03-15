using Entity;

namespace Test
{
    public class PositionTest : BaseTest
    {
        public override bool Test()
        {
            var origin = new Position(0, 0);
            var origin2 = new Position(0, 0);
            var oneZero = new Position(1, 0);

            bool trueEquality = Assert.AreEqual<bool>
            (
                true,
                origin == origin2,
                ErrorMessage + " at true equality test"
            );

            bool falseEquality = Assert.AreEqual<bool>
            (
                false,
                origin == oneZero,
                ErrorMessage + " at false equality test"
            );

            bool trueInequality = Assert.AreEqual<bool>
            (
                true,
                origin != oneZero,
                ErrorMessage + " at true inequality test"
            );

            bool falseInequality = Assert.AreEqual<bool>
            (
                false,
                origin != origin2,
                ErrorMessage + " at false inequality test"
            );

            return trueEquality &&
                falseEquality &&
                trueInequality &&
                falseInequality;
        }
    }
}