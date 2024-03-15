using EntityImp;

namespace Test
{
    public class UnitTest : BaseTest
    {
        public override bool Test()
        {
            int id = 1;
            string name = "Adam";
            
            var adam = new Unit(id, name);

            bool correctID = Assert.AreEqual<int>(id, adam.ID, ErrorMessage + " at id check");
            bool correctName = Assert.AreEqual<string>(name, adam.Name, ErrorMessage + " at name check");

            return correctID && correctName;
        }
    }
}