using System;
using System.Collections.Generic;
using System.Text;

namespace ListInterface
{
    // 链表
    public interface ILinearList<T>
    {
        int Length
        {
            get;
        }
        bool IsEmpty();
        void Insert(int index, T data);
        void Remove(int index);
        int Search(T data);
        void Clear();
    }
    // 栈
    public interface IStack<T> 
    {
        int Length
        {
            get;
        }
        T StackTop
        {
            get;
        }
        void Push(T data);
        void Pop();
        bool IsEmpty();
        void Clear();
    }
    // 队列
    public interface IQueue<T> 
    {
        int Length
        {
            get;
        }
        T QueueFront
        {
            get;
        }
        void EnQueue(T data);
        void DeQueue();
        bool IsEmpty();
        void Clear();
    }
    // 稀疏矩阵
    public interface IMatrix 
    {
        // 行
        int Rows
        {
            get;
        }
        // 列
        int Cols
        {
            get;
        }
        double this[int i, int j]
        {
            get;
            set;
        }
        IMatrix Add(IMatrix B);
        IMatrix Transpose();
        IMatrix Multiply(IMatrix B);
    }
    // 串
    public interface IString 
    {
        int Length
        {
            get;
        }
        char this[int index] 
        {
            get;
            set;
        }
        IString Insert(int StartIndex, IString s);
        IString Remove(int StartIndex, int count);
        IString SubString(int StartIndex, int count);
        IString Clone();
        IString concat(IString S);
        int FindParam(IString S);
    }
}