using System;
using System.Collections.Generic;
using System.Text;

namespace EdgeNodeClass
{
    public class EdgeNode
    {

        private int index;
        private double weight;
        private EdgeNode next;
        // 无next节点的构造函数
        public EdgeNode(int index, double weight)
        {
            if (index < 0)
            {
                throw new Exception("索引值传入有错误");
            }
            this.index = index;
            this.weight = weight;
            this.next = null;
        }
        // 有next节点的构造函数
        public EdgeNode(int index, double weight, EdgeNode next)
        {
            if (index < 0)
            {
                throw new Exception("索引值传入有错误");
            }
            this.index = index;
            this.weight = weight;
            this.next = next;
        }
        public int Index
        {
            get
            {
                return this.index;
            }
        }
        public double Weight
        {
            get
            {
                return this.weight;
            }
        }
        public EdgeNode Next
        {
            get
            {
                return this.next;
            }
            set
            {
                this.next = value;
            }
        }
    }
}
