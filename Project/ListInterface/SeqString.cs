using System;
using System.Collections.Generic;
using System.Text;
using ListInterface;

namespace SeqStringClass
{
    public class SeqString : IString
    {
        private char[] Cstr;
        public int Length
        {
            get
            {
                int i = 0;
                while (this.Cstr[i] != '\0')
                {
                    i++;
                }
                return i;
            }
        }
        public char this[int index]
        {
            get
            {
                if (index < 0 || index > this.Cstr.Length - 1)
                {
                    throw new Exception("索引位置传入有错");
                }
                return this.Cstr[index];
            }
            set
            {
                if (index < 0 || index > this.Cstr.Length - 1)
                {
                    throw new Exception("索引位置传入有错");
                }
                this.Cstr[index] = value;
            }
        }
        // 构造函数
        public SeqString()
        {
            this.Cstr = new char[] { '\0' };
        }
        public SeqString(String s)
        {
            if (s == null) throw new Exception("传入字符串为空");
            int len = s.Length;
            this.Cstr = new char[len + 1];
            for (int i = 0; i < len; i++)
            {
                this.Cstr[i] = s[i];
            }
            this.Cstr[len] = '\0';
        }
        public SeqString(int len)
        {
            if (len < 0) throw new Exception("字符串长度不能为0");
            this.Cstr = new char[len + 1];
            this.Cstr[len] = '\0';
        }
        public IString Insert(int index, IString s)
        {
            if (s == null)
            {
                throw new Exception("插入子串有错");
            }
            if (index < 0 || index > this.Cstr.Length)
            {
                throw new Exception("插入位置有错");
            }
            int len = this.Cstr.Length + s.Length;
            SeqString str = new SeqString(len);
            for (int i = 0; i < index; i++)
            {
                str.Cstr[i] = this.Cstr[i];
            }
            for (int i = 0; i < s.Length; i++)
            {
                str.Cstr[i + index] = s[i];
            }
            for (int i = index; i < this.Cstr.Length; i++)
            {
                str.Cstr[i + s.Length] = this.Cstr[i];
            }
            return str;
        }
        public IString Remove(int start, int count)
        {
            if (start < 0 || start > this.Cstr.Length - 1)
            {
                throw new Exception("开始位置有错");
            }
            if (count < 0)
            {
                throw new Exception("移除的字符串长度小于0");
            }
            int maxOut = this.Cstr.Length - start;
            count = count < maxOut ? count : maxOut;
            SeqString str = new SeqString(this.Cstr.Length - count);
            for (int i = 0; i < start; i++)
            {
                str[i] = this.Cstr[i];
            }
            for (int i = start + count; i < this.Cstr.Length; i++)
            {
                str[i - count] = this.Cstr[i];
            }
            return str;
        }
        // 截取字符串(返回值为截取完的子串)
        public IString SubString(int start, int count)
        {
            if (start < 0 || start > this.Cstr.Length - 1)
            {
                throw new Exception("开始位置传入有错");
            }
            if (count < 0)
            {
                throw new Exception("截取长度小于0");
            }
            int left = this.Cstr.Length - start;
            count = count > left ? left : count;
            IString str = new SeqString(count);
            for (int i = start; i < count; i++)
            {
                str[i - start] = this.Cstr[i];
            }
            return str;
        }
        public IString Clone()
        {
            SeqString str = new SeqString(this.Cstr.Length);
            for (int i = 0; i < this.Cstr.Length; i++)
            {
                str.Cstr[i] = this.Cstr[i];
            }
            return str;
        }
        public IString concat(IString s)
        {
            if (s == null) throw new Exception("连接字符串为空");
            return this.Insert(this.Length, s);
        }
        public static SeqString operator +(SeqString s1, SeqString s2)
        {
            if (s1 == null || s2 == null)
            {
                throw new Exception("含有空字符串");
            }
            return s1.concat(s2) as SeqString;
        }
        public override string ToString()
        {
            string str = string.Empty;
            for (int i = 0; i < this.Cstr.Length - 1; i++)
            {
                str += this.Cstr[i];
            }
            return str;
        }
        public int FindParam(IString s)
        {
            if (s == null || s.Length == 0)
            {
                throw new Exception("参数字符串传入有错");
            }
            int j = 0;
            for (int i = 0; i <= this.Cstr.Length - s.Length; i++)
            {
                if (this.Cstr[i] == s[0])
                {
                    for (j = 1; j < s.Length; j++)
                    {
                        if (this.Cstr[i + j] != s[j]) break;
                    }
                }
                if (j == s.Length) return i;
            }
            return -1;
        }
        // 去除俩边空格
        public IString Trim()
        {
            string str = string.Empty;
            int i, j;
            for (i = 0; i < this.Length - 1; i++)
            {
                if (this.Cstr[i] != ' ') break;
            }
            if (i == this.Length - 1) return new SeqString();
            for (j = this.Length - 1; j >= 0; j--)
            {
                if (this.Cstr[j] != ' ') break;
            }
            for (int k = i; k <= j; k++)
            {
                str += this.Cstr[k];
            }
            return new SeqString(str);
        }
        // 替换字符串
        public IString Replace(string pattern, string replacement, int num)
        {
            if (pattern.Length > this.Length) throw new Exception("子串过于大");
            int i;
            string str = string.Empty;
            for (i = num; i < this.Length; i++)
            {
                if (this.Cstr[i] == pattern[0])
                {
                    int j;
                    for (j = 1; j < pattern.Length; j++)
                    {
                        if (this.Cstr[i + j] != pattern[j])
                        {
                            break;
                        }
                    }
                    if (j == pattern.Length)
                    {
                        str += replacement;
                        i += pattern.Length - 1;
                        continue;
                    }
                }
                str += this.Cstr[i];
            }
            Console.WriteLine("{0}", str);
            return new SeqString(str);
        }
        // 在左边添加元素达到指定长度
        public IString paddingLeft(int max, string a)
        {
            if (max <= this.Length) throw new Exception("串已经达到该长度");
            if (a == string.Empty) throw new Exception("传入的是空字符");
            string str = this.ToString();
            for (int i = 0; i < max - this.Length; i++)
            {
                str = a + str;
            }
            return new SeqString(str);
        }
    }
}
