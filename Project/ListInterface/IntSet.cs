using System;
using System.Collections.Generic;
using System.Text;
using ListInterface;

namespace IntSetClass
{
    public class IntSet : ISet<uint, IntSet>
    {
        private uint[] bitSet;
        private uint maxRange;
        public uint MaxRange
        {
            get
            {
                return this.maxRange;
            }
        }
        public IntSet(uint max)
        {
            uint i, len;
            this.maxRange = max;
            len = max / 32 + 1;
            this.bitSet = new uint[len];
            for (i = 0; i < len; i++)
            {
                bitSet[i] = 0;
            }
        }
        // 获取元素在数组中的索引
        private uint ArrayIndex(uint elt)
        {
            if (elt > this.maxRange) throw new Exception("不在范围内");
            return elt / 32;
        }
        // 获取元素对应位置的整数
        private uint BitMask(uint elt)
        {
            if (elt > this.maxRange) throw new Exception("不在范围内");
            return (uint)Math.Pow(2, elt % 32);
        }
        public void Insert(uint elt)
        {
            if (elt > this.maxRange) throw new Exception("超出范围");
            this.bitSet[this.ArrayIndex(elt)] |= this.BitMask(elt);
        }
        public void Remove(uint elt)
        {
            if (elt > this.maxRange) throw new Exception("超出范围");
            this.bitSet[this.ArrayIndex(elt)] &= ~this.BitMask(elt);
        }
        public bool isMember(uint elt)
        {
            if (elt > this.maxRange) return false;
            uint i = this.bitSet[this.ArrayIndex(elt)] & this.BitMask(elt);
            return i != 0;
        }
        // 获取对象二进制字符串
        public string GetBitString()
        {
            string str = string.Empty;
            for (int i = 0; i < this.bitSet.Length; i++)
            {
                str = Convert.ToString(bitSet[i], 2).PadLeft(32, '0') + str;
            }
            return str.Remove(0, (int)maxRange % 32 + 1);
        }
        // 得到集合中的所有元素
        public string GetElement()
        {
            string S = this.GetBitString();
            string str = string.Empty;
            int j = 0;
            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] == '1') str += j.ToString() + " ";
                j++;
            }
            return str;
        }
        // 判断两个集合是否相等
        public bool Equals(IntSet B)
        {
            if (B == null) throw new Exception("未传入集合");
            if (B.MaxRange != this.maxRange) return false;
            return B.GetBitString() == this.GetBitString();
        }
        // 得到两个集合的交集
        public IntSet Intersect(IntSet B)
        {
            if (B == null) throw new Exception("未传入集合");
            if (B.MaxRange != this.maxRange) throw new Exception("两个集合的范围不同");
            IntSet result = new IntSet(this.maxRange);
            for (int i = 0; i < this.bitSet.Length; i++)
            {
                result.bitSet[i] = this.bitSet[i] & B.bitSet[i];
            }
            return result;
        }
        // 得到两个集合的并集
        public IntSet Union(IntSet B)
        {
            if (B == null) throw new Exception("未传入集合");
            if (B.MaxRange != this.maxRange) throw new Exception("两个集合的范围不同");
            IntSet result = new IntSet(this.maxRange);
            for (int i = 0; i < this.bitSet.Length; i++)
            {
                result.bitSet[i] = this.bitSet[i] | B.bitSet[i];
            }
            return result;
        }
        // 得到两个集合的差集
        public IntSet DiffSet(IntSet B)
        {
            if (B == null) throw new Exception("未传入集合");
            if (B.MaxRange != this.maxRange) throw new Exception("两个集合的范围不同");
            IntSet result = new IntSet(this.maxRange);
            for (int i = 0; i < this.bitSet.Length; i++)
            {
                result.bitSet[i] = this.bitSet[i] & (~B.bitSet[i]);
            }
            return result;
        }
        // 得到集合的补集
        public IntSet Complement()
        {
            IntSet result = new IntSet(this.maxRange);
            for (int i = 0; i < this.bitSet.Length; i++)
            {
                result.bitSet[i] = ~(this.bitSet[i]);
            }
            return result;
        }
        // 判断集合是否为其子集
        public bool IsSubSet(IntSet B)
        {
            if (B == null) throw new Exception("未传入集合");
            if (B.MaxRange != this.maxRange) throw new Exception("两个集合的范围不同");
            for (int i = 0; i < this.bitSet.Length; i++)
            {
                uint temp = this.bitSet[i] | B.bitSet[i];
                if (temp != this.bitSet[i]) return false;
            }
            return true;
        }
    }
}
