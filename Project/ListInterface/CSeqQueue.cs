using System;
using System.Collections.Generic;
using System.Text;
using ListInterface;

namespace CSeqQueueClass
{
    public class CSeqQueue<T> : IQueue<T>
    {
        private T[] dataSet;
        private int pFront;
        private int pRear;
        private int length;
        private int maxSize;
        public int Length
        {
            get
            {
                return this.length;
            }
        }
        public T QueueFront
        {
            get
            {
                return dataSet[pFront];
            }
        }
        public CSeqQueue(int max)
        {
            dataSet = new T[max];
            this.length = 0;
            this.pRear = 0;
            this.pFront = 0;
            this.maxSize = max;
        }
        public void EnQueue(T data)
        {
            if (this.length == this.maxSize) throw new Exception("队列已经满了");
            dataSet[this.pRear] = data;
            this.length++;
            this.pRear = (this.pRear + 1) % this.maxSize;
        }
        // 出队,出队后这个元素仍然在内存中存储着
        public void DeQueue()
        {
            if (this.length == 0) throw new Exception("队列为空");
            this.length--;
            this.pFront = (this.pFront + 1) % this.maxSize;
        }
        public bool IsEmpty()
        {
            return this.length == 0;
        }
        public void Clear()
        {
            this.length = 0;
            this.pRear = 0;
            this.pFront = 0;
        }
    }
}
