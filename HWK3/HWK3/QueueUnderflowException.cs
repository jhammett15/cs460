using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWK3
{
    public class QueueUnderflowException
    {
        // empty constructor, creates an exception without a message
        public QueueUnderflowException()
        {
        }

        // prints out the message taken in then the stacktrace
        public QueueUnderflowException(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine(Environment.StackTrace);
        }
    }
}
