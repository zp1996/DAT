using System;
using System.Collections.Generic;
using System.Text;
using ListInterface;
using DArrayClass;

namespace LinearListClass
{
    public class LinearList<T> : ILinearList<T>
    {
        #region 私有成员

        private int length;
        private DArray<T> list;
        private int maxSize;

        #endregion;

        #region ILinearList<T> 成员

        public LinearList(int max)
        {
            if (max < 0)
            {
                throw new Exception("顺序列表的长度要大于0");
            }
            this.maxSize = max;
            list = new DArray<T>(max);
        }
        public int MaxSize
        {
            get
            {
                return this.maxSize;
            }
        }
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
                    throw new Exception("索引值的传入有错误");
                }
                return this.list[index];
            }
            set
            {
                if (index < 0 || index > this.length - 1) throw new Exception("索引值的传入有错误");
                this.list[index] = value;
            }
        }

        public bool IsEmpty()
        {
            return this.length == 0 ? true : false;
        }

        public void Insert(int index, T data)
        {
            if (index < 0)
            {
                throw new Exception("索引值传入有错误");
            }
            if (index >= this.length || this.length == this.maxSize)
            {
                list.ReSize(this.length + 10);
            }
            for (int i = this.length; i > index; i--)
            {
                list[i] = list[i - 1];
            }
            list[index] = data;
            this.length++;
        }

        public void Remove(int index)
        {
            if (index < 0 || index > this.length || this.length == this.maxSize)
            {
                throw new Exception("索引值传入有错误");
            }
            for (int i = index; i < this.length; i++)
            {
                list[i] = list[i + 1];
            }
            length--;
        }

        public int Search(T data)
        {
            for (int i = 0; i < this.length; i++)
            {
                if (list[i].Equals(data) == true)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Clear()
        {
            this.length = 0;
        }

        #endregion
    }
}
