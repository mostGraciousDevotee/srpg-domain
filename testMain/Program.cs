using Test;
using EntityImp;

class Program
{
    List<BaseTest> _tests = new List<BaseTest>();
    
    static void Main()
    {
        var testRunner = new TestRunner();
        var unitTest = new UnitTest();

        testRunner.AddTest(unitTest);

        testRunner.Run();
    }
}