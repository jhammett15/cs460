using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWK3
{
    class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T data, Node<T> next)
        {
            this.Data = data;
            this.Next = next;
        }
    }
}
