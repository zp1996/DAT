using System;
using System.Collections.Generic;
using System.Text;
using SLinkListClass;
using ListInterface;

namespace LinkStackClass
{
    public class LinkStack<T> : IStack<T>
    {
        private SLinkList<T> _list;
        public int Length
        {
            get
            {
                return _list.Length;
            }
        }
        public T StackTop
        {
            get
            {
                return _list[0];
            }
        }
        public LinkStack()
        {
            _list = new SLinkList<T>();
        }
        public void Push(T data)
        {
            _list.InsertAtFirst(data);
        }
        public void Pop()
        {
            if (_list.Length == 0) throw new Exception("栈为空");
            _list.Remove(0);
        }
        public bool IsEmpty()
        {
            return _list.IsEmpty();
        }
        public void Clear()
        {
            _list.Clear();
        }
    }
}
