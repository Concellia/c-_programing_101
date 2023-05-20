using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class StacksAndQueues
    {
        // Stacks is a data structure which stores data in a form of stacks it is a first come last out (FCLO) or last in first out (LIFO)
        // Stacks are collections and have its own operations
        // Here are the stacks operations:
        // - Push(Object obj): Add data to the top
        // - Object Pop(): Removes the top data
        // - Object Peek(): Return data on top of the stack without removing it.

        public static void stackMethod()
        {
            int[] numbers = { 6, 7, 8, 9, 10 };
            Stack<int> reversedNumbers = new Stack<int>();
            Stack<int> stack1 = new Stack<int>();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            stack1.Push(5);

            Console.WriteLine(stack1.Peek());
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Peek());
        }
        
        



    // Queues are data structures which stores data and it is a first in first out (FIFO) or last in last out (LILO)
    // Queues oprations: 
    // - Enqueue(Oject obj): Add data at the back of the queue
    // - Object Dequeue(): Removes data from the front of the queue
    //- Object Peek(): Return data in the front of the queue without removing it.

    public static void queueMethod()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());


        }
    }
}
