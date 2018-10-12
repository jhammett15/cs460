using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWK3
{
    public interface IQueue<T>
    {
        // adds an element to the rear of the queue
        // returns the element that was enqueued
        T Push(T element);

        // removes and returns the front element
        // exception thrown if the queue is empty
        T Pop();

        // test if the queue is empty
        // return true if the queue is empty, otherwise false
        bool IsEmpty();
    }
}
