using System;
using System.Collections.Generic;
using System.Text;
using ListInterface;
using LinearListClass;

namespace SeqQueueClass
{
    public class SeqQueue<T> : IQueue<T>
    {
        private LinearList<T> list;
        public int Length
        {
            get
            {
                return list.Length;
            }
        }
        public int MaxSize
        {
            get
            {
                return list.MaxSize;
            }
        }
        public T QueueFront
        {
            get
            {
                if (list.Length == 0)
                {
                    throw new Exception("队列是空的");
                }
                return list[0];
            }
        }
        public SeqQueue(int max)
        {
            if (max <= 0)
            {
                throw new Exception("队列长度不能为0");
            }
            list = new LinearList<T>(max);
        }
        // 入队
        public void EnQueue(T data)
        {
            if (list.Length == list.MaxSize) throw new Exception("队列已经满了");
            list.Insert(list.Length, data);
        }
        // 出队
        public void DeQueue()
        {
            if (list.Length == 0) throw new Exception("队列为空");
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
