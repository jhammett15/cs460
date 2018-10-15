using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWK3
{
    /// <summary>
    /// A FIFO queue interface. This is suitable for a singly linked queue
    /// </summary>
    /// <typeparam name="T">Specifies that the Queue that inherits from this will take in a generic type</typeparam>
    public interface IQueue<T>
    {
        /// <summary>
        /// adds an element to the rear of the queue
        /// </summary>
        /// <param name="element">the item to be enqueued</param>
        /// <returns>returns the element that was enqueued</returns>
        T Push(T element);

        /// <summary>
        /// removes and returns the front element
        /// exception thrown if the queue is empty
        /// </summary>
        /// <returns>the element taht was at the front of the queue</returns>
        T Pop();

        /// <summary>
        /// test if the queue is empty
        /// </summary>
        /// <returns>teturn true if the queue is empty, otherwise false</returns>
        bool IsEmpty();
    }
}
