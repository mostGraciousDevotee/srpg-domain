using Test;

class TestRunner
{
    List<BaseTest> _tests = new List<BaseTest>();

    public void AddTest(BaseTest test)
    {
        _tests.Add(test);
    }

    public void Run()
    {
        foreach (BaseTest test in _tests)
        {
            test.Test();
        }
    }
}