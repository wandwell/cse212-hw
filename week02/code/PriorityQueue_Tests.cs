using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    private string expectedResult;

    [TestMethod]
    // Scenario: Create a queue with the following values and priorities. Run until the queue is empty.
    // Apple, 2; Banana, 5; Orange, 1; Grape, 4; Blueberry, 3;
    // Expected Result: Banana, Grape, Blueberry, Apple, Orange
    // Defect(s) Found: Dequeue does not remove item from queue; 
    // Started dequeue for loop at index 1 instead of 0 and ended before going through list
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Apple", 2);
        priorityQueue.Enqueue("Banana", 5);
        priorityQueue.Enqueue("Orange", 1);
        priorityQueue.Enqueue("Grape", 4);
        priorityQueue.Enqueue("Blueberry", 3);

        string[] expectedResult = ["Banana", "Grape", "Blueberry", "Apple", "Orange"];

        for (int i = 0; i <= expectedResult.Length - 1; i++)
        {
            Assert.AreEqual(priorityQueue.Dequeue(), expectedResult[i]);
        }
    }

    [TestMethod]
    // Scenario: Create a queue with the following values and priorities. Run until the queue is gone;
    // Apple, 2; Banana, 3; Orange, 2; Grape, 3; Blueberry, 1;
    // Expected Result: Banana, Grape, Apple, Orange, Blueberry
    // Defect(s) Found: It removed the last high-priority item instead of the first
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Apple", 2);
        priorityQueue.Enqueue("Banana", 3);
        priorityQueue.Enqueue("Orange", 2);
        priorityQueue.Enqueue("Grape", 3);
        priorityQueue.Enqueue("Blueberry", 1);

        string[] expectedResult = ["Banana", "Grape", "Apple", "Orange", "Blueberry"];

        for (int i = 0; i <= expectedResult.Length - 1; i++)
        {
            Assert.AreEqual(priorityQueue.Dequeue(), expectedResult[i]);
        }
    }

    [TestMethod]
    // Scenario: Create an empty queue and run the program.
    // Expected Result: "The queue is empty
    // Defect(s) Found: 
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
    // Add more test cases as needed below.
}