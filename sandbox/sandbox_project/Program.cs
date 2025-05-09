using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.
        

        List<int> testList = new List<int>();
        testList.Add(1);
        testList.Add(2);
        testList.Add(3);
        testList.Add(4);

        foreach (var item in testList)
        {
            Console.WriteLine(item);
        }

        List<int> smallerList = testList.GetRange(0,2);

        testList.RemoveRange(0,1);
        foreach (var item in testList)
        {
            Console.WriteLine(item);
        }

        foreach (var item in smallerList)
        {
            Console.WriteLine(item);
        }
    }
}