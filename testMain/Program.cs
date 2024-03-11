using Test;
using EntityImp;

class Program
{
    List<BaseTest> _tests = new List<BaseTest>();
    
    static void Main()
    {
        Console.WriteLine("Hello world!");

        var adam = new Unit(1, "Adam");

        if (adam != null)
        {
            Console.WriteLine("Succesfully created " + adam.Name + " #" + adam.ID);
        }

        // var testRunner = new TestRunner();

        // testRunner.Run();
    }
}