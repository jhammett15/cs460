﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWK3
{
    class LinkedQueue<T> : IQueue<T>
    {
        private Node<T> Front;
        private Node<T> Rear;

        public LinkedQueue()
        {
            Front = null;
            Rear = null;
        }

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
