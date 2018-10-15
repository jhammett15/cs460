using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWK3
{
    /// <summary>
    /// This simple example demonstrates the rather powerful
    /// application of Breadth-First Search to enumeration of states problems.
    /// 
    /// There are easier ways to generate a list of binary values, but this technique
    /// is very general and a good one to remember for other uses.
    /// </summary>
    class Program
    {
        /// <summary> 
        /// Print the binary representation of all numbers from 1 up to n.
        /// This is accomplished by using a FIFO queue to perform a level order (breadth first search)
        /// traversal of a virtual binary tree and then storing each "value" in a list as it is "visited"
        /// </summary>
        /// <param name="n">the decimal number we will be creating a binary representation for</param>
        /// <returns>the list of the binary values</returns>
        static LinkedList<string> GenerateBinaryRepresentation(int n)
        {
            // create an empty queue of strings with which to perform the traversal
            LinkedQueue<StringBuilder> q = new LinkedQueue<StringBuilder>();

            // a list for returning the binary values
            LinkedList<string> output = new LinkedList<string>();

            if(n < 1)
            {
                // binary representation of negative values is not supported
                // return an empty list
                return output;
            }

            // enqueue the first binary number
            // use a dynamic string to avoid string concat
            q.Push(new StringBuilder("1"));

            // breadth first search
            while(n-- > 0)
            {
                // print the front of the queue
                StringBuilder sb = q.Pop();
                output.AddLast(sb.ToString());

                // make a copy
                StringBuilder sbc = new StringBuilder(sb.ToString());

                // left child
                sb.Append("0");
                q.Push(sb);

                // right child
                sbc.Append("1");
                q.Push(sbc);
            }

            return output;
        }

        /// <summary>
        /// The driver program to test the above function
        /// </summary>
        /// <param name="args">the argument taken in from the command line, the number to be converted into binary</param>
        static void Main(string[] args)
        {
            int n = 10;
            if(args.Length < 1)
            {
                Console.WriteLine("Please invoke with the max value to print binary up to, like this:");
                Console.WriteLine("HWK3.exe 12");
                return;
            }
            try
            {
                n = int.Parse(args[0]);
            }
            catch(FormatException)
            {
                Console.WriteLine("I'm sorry, I can't understand the number: " + args[0]);
                return;
            }

            LinkedList<string> output = GenerateBinaryRepresentation(n);

            // print it right justified, longest string is the last one
            // print enough spaces to move it over the correct distance
            int maxLength = output.Last().Length;
            foreach(string s in output)
            {
                for(int i = 0; i < maxLength - s.Length; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(s);
            }
        }
    }
}
