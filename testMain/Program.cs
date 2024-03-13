using Test;

class Program
{
    List<BaseTest> _tests = new List<BaseTest>();
    
    static void Main()
    {
        var testRunner = new TestRunner();

        var unitTest = new UnitTest();
        var readinessTest = new ReadinessTest();

        var turnSysTest = new TurnSysTest();

        testRunner.AddTest(unitTest);
        testRunner.AddTest(readinessTest);

        testRunner.AddTest(turnSysTest);
        
        testRunner.Run();
    }
}