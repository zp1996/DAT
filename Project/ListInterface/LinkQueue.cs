using System;
using System.Collections.Generic;
using System.Text;
using ListInterface;
using SLinkListClass;

namespace LinkQueueClass
{
    // 链式队列
    public class LinkQueue<T> : IQueue<T>
    {
        private SLinkList<T> list;
        public int Length
        {
            get
            {
                return list.Length;
            }
        }
        public T QueueFront
        {
            get
            {
                return list[0];
            }
        }
        public LinkQueue()
        {
            list = new SLinkList<T>();
        }
        public void EnQueue(T data)
        {
            list.InsertAtEnd(data);
        }
        public void DeQueue()
        {
            if (list.IsEmpty()) throw new Exception("队列为空");
            list.Remove(0);
        }
        public bool IsEmpty()
        {
            return list.Length == 0;
        }
        public void Clear()
        {
            list.Clear();
        }
    }
}
