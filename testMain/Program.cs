using Test;

class Program
{
    List<BaseTest> _tests = new List<BaseTest>();
    
    static void Main()
    {
        var testRunner = new TestRunner();
        var unitTest = new UnitTest();
        var readinessTest = new ReadinessTest();

        testRunner.AddTest(unitTest);
        testRunner.AddTest(readinessTest);
        
        testRunner.Run();
    }
}