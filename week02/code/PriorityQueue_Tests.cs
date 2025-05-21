using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Test enqueueing and dequeuing items in order
    // Expected Result: Items are dequeued in the same order they were enqueued
    // Defect(s) Found: None 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);

        Assert.AreEqual("A", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
        
    }

    [TestMethod]
     // Scenario: Test enqueueing items with different priorities and dequeuing them
    // Expected Result: Items are dequeued based on priority, regardless of enqueue order
    // Defect(s) Found: None 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 3);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 1);

        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
    [TestMethod]
     // Scenario: Attempt to dequeue from an empty queue
    // Expected Result: InvalidOperationException is thrown
    // Defect(s) Found: None
    [ExpectedException(typeof(InvalidOperationException))]

    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue(); // Attempt to dequeue from an empty queue
        // This should throw an InvalidOperationException
    }
}