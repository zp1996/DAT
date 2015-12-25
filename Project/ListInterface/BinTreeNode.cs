using System;
using System.Collections.Generic;
using System.Text;

namespace BinTreeNodeClass
{
    public class BinTreeNode<T>
    {
        private T data;
        private BinTreeNode<T> leftChild;
        private BinTreeNode<T> rightChild;
        public T Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
        public BinTreeNode<T> LeftChild
        {
            get
            {
                return this.leftChild;
            }
            set
            {
                this.leftChild = value;
            }
        }
        public BinTreeNode<T> RightChild
        {
            get
            {
                return this.rightChild;
            }
            set
            {
                this.rightChild = value;
            }
        }
        // 无子节点构造函数
        public BinTreeNode(T data)
        {
            if (data == null) throw new Exception("节点数据不能为空");
            this.data = data;
            this.leftChild = null;
            this.rightChild = null;
        }
        // 含有子节点的构造函数
        public BinTreeNode(BinTreeNode<T> lChild, T data, BinTreeNode<T> rChild)
        {
            if (data == null) throw new Exception("节点数据不能为空");
            this.data = data;
            this.leftChild = lChild;
            this.rightChild = rChild;
        }
    }
}
