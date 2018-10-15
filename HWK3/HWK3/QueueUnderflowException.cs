using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWK3
{
    /// <summary>
    /// A custom unchecked exception to represent situations where 
    /// an illegal operation was performed on an empty queue.
    /// </summary>
    public class QueueUnderflowException : SystemException
    {
        /// <summary>
        /// empty constructor, creates an exception without a message
        /// </summary>
        public QueueUnderflowException()
        {
        }

        /// <summary>
        /// prints out the message taken in then the stacktrace
        /// </summary>
        /// <param name="message">the message to be printed out when the exception is thrown</param>
        public QueueUnderflowException(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine(Environment.StackTrace);
        }
    }
}
