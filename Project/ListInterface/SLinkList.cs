using System;
using System.Collections.Generic;
using System.Text;
using SNodeClass;
using ListInterface;
using SNodeClass;

namespace SLinkListClass
{
    public class SLinkList<T> : ILinearList<T>
    {
        protected SNode<T> pHead;
        protected int length;

        public int Length
        {
            get
            {
                return this.length;
            }
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index > this.length - 1)
                {
                    throw new Exception("索引值传入有错误");
                }
                return Locate(index).Data;
            }
            set
            {
                if (index < 0 || index > this.length - 1)
                {
                    throw new Exception("索引值传入有错误");
                }
                Locate(index).Data = value;
            }
        }
        public SLinkList()
        {
            this.length = 0;
            this.pHead = null;
        }
        protected SNode<T> Locate(int index)
        {
            if (index < 0 || index > this.length - 1)
            {
                throw new Exception("索引值传入有错误");
            }
            SNode<T> temp = this.pHead;
            for (int i = 0; i < index; i++)
            {
                temp = temp.Next;
            }
            return temp;
        }
        public void InsertAtFirst(T data)
        {
            SNode<T> node = new SNode<T>(data, this.pHead);
            this.pHead = node;
            this.length++;
        }
        public void InsertAtEnd(T data)
        {
            SNode<T> node = new SNode<T>(data);
            if (this.length == 0)
            {
                this.pHead = node;
            }
            else
            {
                Locate(this.length - 1).Next = node;
            }
            this.length++;
        }
        public void Insert(int index, T data)
        {
            if (index < 0 || index > this.length)
            {
                throw new Exception("索引值传入有错误");
            }
            if (index == 0)
            {
                InsertAtFirst(data);
            }
            else if (index == this.length)
            {
                InsertAtEnd(data);
            }
            else
            {
                SNode<T> node = new SNode<T>(data, Locate(index));
                Locate(index - 1).Next = node;
                this.length++;
            }
        }
        public void Remove(int index)
        {
            if (index < 0 || index > this.length)
            {
                throw new Exception("索引值输入有错误啊");
            }
            if (index == 0)
            {
                this.pHead = this.pHead.Next;
            }
            else
            {
                Locate(index - 1).Next = Locate(index).Next;
            }
            this.length--;
        }
        public int Search(T data)
        {
            SNode<T> temp = this.pHead;
            for (int i = 0; i < this.length; i++)
            {
                if (temp.Data.Equals(data) == true)
                {
                    return i;
                }
                temp = temp.Next;
            }
            return -1;
        }
        public bool IsEmpty()
        {
            return this.length == 0 ? true : false;
        }
        public void Clear()
        {
            this.length = 0;
            this.pHead = null;
        }
        public override string ToString()
        {
            string str = "";
            SNode<T> temp = this.pHead;
            for (int i = 0; i < this.length; i++)
            {
                if (temp.Next == null)
                {
                    str += temp.Data + "这是最后一个；";
                }
                else
                {
                    str += temp.Data + "下一个的数据是:" + temp.Next.Data + "\n";
                }
                temp = temp.Next;
            }
            return str;
        }
        public SLinkList<T> clone()
        {
            SLinkList<T> List = new SLinkList<T>();
            SNode<T> newHead = null;
            SNode<T> temp = this.pHead;
            for (int i = 0; i < length; i++)
            {
                if (newHead == null)
                {
                    newHead = new SNode<T>(temp.Data);
                    List.pHead = newHead;
                }
                else
                {
                    newHead.Next = new SNode<T>(temp.Data);
                    newHead = newHead.Next;
                }
                temp = temp.Next;
            }
            List.length = this.length;
            return List;
        }
        public void reverse()
        {
            SNode<T> temp = this.pHead;
            SNode<T> nextRaer = null;
            //for (int i = 0; i < this.length; i++) 
            //{
            //SNode<T> item = temp.Next;
            //temp.Next = nextRaer;
            //nextRaer = temp;
            //    if (item != null)
            //    {
            //        temp = item;
            //    }
            //}
            while (temp != null)
            {
                SNode<T> item = temp.Next;
                temp.Next = nextRaer;
                nextRaer = temp;
                temp = item;
            }
            this.pHead = nextRaer;
        }
    }
}
