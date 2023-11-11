/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Add 6 different people to the queue, and then deque them one by one. The first one has the highest priority.
        // Expected Result: Levente, Levi, George, John, Bob, Carl
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Levente", 3);
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("George", 2);
        priorityQueue.Enqueue("Levi", 3);
        priorityQueue.Enqueue("John", 2);
        priorityQueue.Enqueue("Carl", 1);
        Console.WriteLine(priorityQueue);

        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: 
        // 1: In the dequeue function the >= had to be changet to > in this part line this:
        // "if (_queue[index].Priority > _queue[highPriorityIndex].Priority)".
        // because the first highest priority item should not be changed to the second one in the queue.
        //
        // 2: I had to add this to the Dequeue function: "_queue.RemoveAt(highPriorityIndex);"
        // because it did not remove the highest priority item, so it repeatedly gave the same result.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Add 6 different people to the queue, and then deque them one by one. The last one has the highest priority.
        // Expected Result: Carl, Levente, Levi, George, John, Bob
        Console.WriteLine("Test 2");

        priorityQueue.Enqueue("Levente", 3);
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("George", 2);
        priorityQueue.Enqueue("Levi", 3);
        priorityQueue.Enqueue("John", 2);
        priorityQueue.Enqueue("Carl", 4);
        Console.WriteLine(priorityQueue);

        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: in the dequeue function the for loop did not go all the way to the end of the list. 
        // The last item was not recognized as the largest.
        // "index < _queue.Count - 1" had to be changed to "index < _queue.Count"

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Try to dequeue an empty list.
        // Expected Result: "The queue is empty."
        Console.WriteLine("Test 3");

        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: none

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}