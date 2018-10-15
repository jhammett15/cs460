using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWK3
{ 
    /// <summary>
    /// A singly linked FIFO Queue.
    /// </summary>
    /// <typeparam name="T">This LinkedQueue will be created with a generic type.</typeparam>
    public class LinkedQueue<T> : IQueue<T>
    {
        private Node<T> Front;
        private Node<T> Rear;

        public LinkedQueue()
        {
            Front = null;
            Rear = null;
        }

        /// <summary>
        /// Adds a Node element to the end of the LinkedQueue
        /// If the element passed in is null, throws a NullReferenceException.
        /// If the LinkedQueue is currently empty, adds the element to the list and sets the 
        /// Front and Rear fields to the element.
        /// </summary>
        /// <param name="element">the Node element to be added to the LinkedQueue</param>
        /// <returns>returns the element that was enqueued</returns>
        public T Push(T element)
        {
            if(element == null)
            {
                throw new NullReferenceException();
            }
            if(IsEmpty())
            {
                Node<T> tmp = new Node<T>(element, null);
                Rear = Front = tmp;
            }
            else
            {
                // general case
                Node<T> tmp = new Node<T>(element, null);
                Rear.Next = tmp;
                Rear = tmp;
            }
            return element;
        }

        /// <summary>
        /// "Pops" the first item off the front of the LinkedQueue, then sets the Front field to be 
        /// the next element in the queue. 
        /// If the queue is empty, throw a QueueUnderflowException.
        /// If there is only one element in the list, pop it and set the Front and 
        /// Rear fields to null
        /// </summary>
        /// <returns>returns the element from the front of the LinkedQueue</returns>
        public T Pop()
        {
            T tmp;
            if(IsEmpty())
            {
                throw new QueueUnderflowException("The queue was empty when Pop was invoked");
            }
            else
            {
                if(Front == Rear)
                {
                    tmp = Front.Data;
                    Front = null;
                    Rear = null;
                }
                else
                {
                    tmp = Front.Data;
                    Front = Front.Next;
                }
            }
            return tmp;
        }

        /// <summary>
        /// Checks to see if the LinkedQueue is empty or not.
        /// </summary>
        /// <returns>returns true if the queue is empty, returns false if it isn't</returns>
        public bool IsEmpty()
        {
            if(Front == null && Rear == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
