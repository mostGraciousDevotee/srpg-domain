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
            if (test.Test() != true)
            {
                Console.WriteLine(test.ToString() + " run failed");
                return;
            }
        }

        Console.WriteLine("All test passed! Congratulations!");
    }
}