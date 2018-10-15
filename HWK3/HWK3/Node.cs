using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWK3
{
    /// <summary>
    /// Singly linked node class
    /// </summary>
    /// <typeparam name="T">specifies that the Node will be of a generic type</typeparam>
    class Node<T>
    {
        public T Data;
        public Node<T> Next;

        /// <summary>
        /// Creates a Node with two fields
        /// </summary>
        /// <param name="data">the contents of the Node</param>
        /// <param name="next">a pointer to the next Node</param>
        public Node(T data, Node<T> next)
        {
            this.Data = data;
            this.Next = next;
        }
    }
}
