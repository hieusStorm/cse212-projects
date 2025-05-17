using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Ensure the priority is being taken into account by adding lowest priority of to the que first and increase it up as more are added bill (priority 1), bob (priority 2), sue (priority 3) 
    // Expected Result: sue, bob, bill
    // Defect(s) Found: doesn't properly count from the begining of the que and doesn't check the entire que when checking priority or the priority of the added string. Doesnt remove the person from the que
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        string[] expectedResult = ["sue", "bob", "bill"];

        priorityQueue.Enqueue("bill", 1);
        priorityQueue.Enqueue("bob", 2);
        priorityQueue.Enqueue("sue", 3);

        for (int i = 0; i < expectedResult.Length; i++)
        {
            string person = priorityQueue.Dequeue();

            Assert.AreEqual(expectedResult[i], person);
        }
    }

    [TestMethod]
    // Scenario: Make sure the que works as a normal que in the case that 2 people have the same priority
    // Expected Result: sue mary bob bill
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        string[] expectedResults = ["sue", "mary", "bob", "bill"];

        priorityQueue.Enqueue("bill", 1);
        priorityQueue.Enqueue("sue", 3);
        priorityQueue.Enqueue("bob", 2);
        priorityQueue.Enqueue("mary", 3);

        for (int i = 0; i < expectedResults.Length; i++)
        {
            string person = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResults[i], person);
        }

    }

    // Add more test cases as needed below.
    // Scenario: Make sure an error is thrown when the que is empty
    // Expected Result: error to be thrown
    // Defect(s) Found: 
    public void TestPriorityQueueEmpty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("An error should have been thrown");
        }
        catch (InvalidOperationException e)
        {

            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e) {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
}