using System;
using System.Collections.Generic;
using System.Text;

namespace DArrayClass
{
    public class DArray<T>
    {
        private T[] array;
        private int size;
        public int Size
        {
            get
            {
                return this.size;
            }
        }
        public DArray(int sz)
        {
            if (sz <= 0) throw new Exception("数组长度不能小于1啊");
            this.size = sz;
            this.array = new T[sz];
        }
        public void ReSize(int newSize)
        {
            if (newSize <= 0) throw new Exception("数组长度不能小于1啊");
            if (this.size != newSize)
            {
                T[] newArray = new T[newSize];
                int temp = Math.Min(size, newSize);
                for (int i = 0; i < temp; i++)
                {
                    newArray[i] = this.array[i];
                }
                this.array = newArray;
                this.size = newSize;
            }
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.size) throw new Exception("索引值有错啊");
                return this.array[index];
            }
            set
            {
                if (index < 0 || index >= this.size) throw new Exception("索引值有错啊");
                array[index] = value;
            }
        }
    }
}
