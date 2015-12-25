using System;
using System.Collections.Generic;
using System.Text;
using ListInterface;
using LinearListClass;

namespace SeqStackClass
{
    public class SeqStack<T> : IStack<T>
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
        public T StackTop
        {
            get
            {
                if (list.Length == 0)
                {
                    throw new Exception("栈最大的容量为0");
                }
                return list[0];
            }
        }
        public SeqStack(int max)
        {
            if (max <= 0) throw new Exception("传入长度需要大于1");
            list = new LinearList<T>(max);
        }
        public void Push(T data)
        {
            if (list.Length == list.MaxSize) throw new Exception("栈已经达到了最大容量");
            list.Insert(0, data);
        }
        public void Pop()
        {
            if (list.Length == 0) throw new Exception("栈为空");
            list.Remove(0);
        }
        public bool IsEmpty()
        {
            return list.IsEmpty();
        }
        public void Clear()
        {
            list.Clear();
        }
    }
}
