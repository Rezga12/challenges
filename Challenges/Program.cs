namespace Challenges;

class Program
{
    static async Task Main(string[] args)
    {
        
    }
    
    public static void TestContainsFunction()
    {
        var sortedList = new List<int> { 1, 3, 5, 7, 9, 11, 13 };
        var  repetitiveElements = new List<int>() { 1,4, 4, 4, 4, 5, 6 ,6 ,6 ,6, 7, 7};
        
        Console.WriteLine("Running test cases...\n");

        RunTestCase(sortedList, 5, true, "Element is present in the list");
        RunTestCase(sortedList, 6, false, "Element is not in the list");
        RunTestCase([], 10, false, "Empty list test case");
        RunTestCase([4], 4, true, "Single element list (match)");
        RunTestCase([4], 2, false, "Single element list (no match)");
        RunTestCase(repetitiveElements, 6, true, "repetitive leements test");
        RunTestCase(repetitiveElements, 100, false, "repetitive elements test");
        RunTestCase([1, 2], 2, true, "two element list (match)");
        RunTestCase([1, 2], 0, false, "two element list (no match)");
        
        Console.WriteLine("\nAll test cases executed.");
    }
    
    public static void RunTestCase(List<int> list, int x, bool expected, string description)
    {
        bool result = BinarySearch.Contains(list, x);
        Console.WriteLine($"{description}: {(result == expected ? "PASSED" : "FAILED")}");
    }
}