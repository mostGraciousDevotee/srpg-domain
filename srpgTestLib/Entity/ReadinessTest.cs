using EntityImp;

namespace Test
{
    public class ReadinessTest : BaseTest
    {
        public override bool Test()
        {
            int id = 1;
            string name = "Adam";
            
            var adam = new Unit(id, name);
            var expectedReadiness = new ReadinessComponent(10);

            adam.AddComponent<ReadinessComponent>(expectedReadiness);

            var resultReadiness = adam.GetComponent<ReadinessComponent>();
            bool readinessAdded = Assert.AreEqualRef(expectedReadiness, resultReadiness, ErrorMessage + " at adding readiness!");

            int expectedReadinessVal = 10;

            resultReadiness.UpdateReadiness();

            bool correctReadiness = Assert.AreEqual<int>(expectedReadinessVal, resultReadiness.Readiness, ErrorMessage + " at readiness value check");

            resultReadiness.Reset();

            expectedReadinessVal = 0;

            bool correctValAfterReset = Assert.AreEqual<int>(expectedReadinessVal, resultReadiness.Readiness, ErrorMessage + " at readiness val after reset");
            
            return readinessAdded &&
                correctReadiness &&
                correctValAfterReset;
        }
    }
}