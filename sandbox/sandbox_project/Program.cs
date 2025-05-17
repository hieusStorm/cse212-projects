using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.


        List<int> testList = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            testList.Add(i);
        }

        var removeValue = testList[0];
        testList.RemoveAt(0);
        Console.WriteLine(removeValue);
    }
}