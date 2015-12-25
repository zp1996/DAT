using System;
using System.Collections.Generic;
using System.Text;
using ListInterface;
using DnodeClass;

namespace DLinkListClass
{
    public class DLinkList<T> : ILinearList<T>
    {
        private int length;
        private Dnode<T> pHead;
        private Dnode<T> pRear;

        public DLinkList()
        {
            this.length = 0;
            this.pHead = null;
            this.pRear = null;
        }

        public int Length
        {
            get { return this.length; }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > this.length - 1) throw new Exception("索引值传入有错");
                return Locate(index).Data;
            }
            set
            {
                if (index < 0 || index > this.length - 1) throw new Exception("索引值传入有错");
                Locate(index).Data = value;
            }
        }
        private Dnode<T> Locate(int index)
        {
            if (index < 0 || index > this.length - 1) throw new Exception("索引值传入有错");
            Dnode<T> temp = this.pHead;
            for (int i = 0; i < index; i++)
            {
                temp = temp.Next;
            }
            return temp;
        }
        public void InsertAtFirst(T data)
        {
            if (this.length == 0)
            {
                Dnode<T> node = new Dnode<T>(data);
                this.pRear = node;
                this.pHead = node;
            }
            else
            {
                Dnode<T> node = new Dnode<T>(null, data, this.pHead);
                this.pHead.Prior = node;
                this.pHead = node;
            }
            this.length++;
        }
        public void InsertAtEnd(T data)
        {
            if (this.length == 0)
            {
                Dnode<T> node = new Dnode<T>(data);
                this.pHead = node;
                this.pRear = node;
            }
            else
            {
                Dnode<T> node = new Dnode<T>(this.pRear, data, null);
                this.pRear.Next = node;
                this.pRear = node;
            }
            this.length++;
        }
        public bool IsEmpty()
        {
            return this.length == 0 ? true : false;
        }

        public void Insert(int index, T data)
        {
            if (index < 0 || index > this.length) throw new Exception("索引值传入有错");
            if (index == 0) InsertAtFirst(data);
            else if (index == this.length) InsertAtEnd(data);
            else
            {
                Dnode<T> temp = new Dnode<T>(Locate(index - 1), data, Locate(index));
                Locate(index - 1).Next = temp;
                Locate(index).Prior = temp;
                this.length++;
            }
        }

        public void Clear()
        {
            this.length = 0;
            this.pRear = null;
            this.pHead = null;
        }

        public void Remove(int index)
        {
            if (index < 0 || index > this.length - 1 || this.length == 0) throw new Exception("索引值传入有错");
            if (index == 0)
            {
                this.pHead = this.pHead.Next;
                this.pHead.Prior = null;
            }
            else if (index == this.length - 1)
            {
                this.pRear = this.pRear.Prior;
                this.pRear.Next = null;
            }
            else
            {
                Dnode<T> temp = Locate(index);
                temp.Prior.Next = temp.Next;
                temp.Next.Prior = temp.Prior;
            }
            this.length--;
        }

        public int Search(T data)
        {
            Dnode<T> temp = this.pHead;
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
    }
}
