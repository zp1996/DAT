using System;
using System.Collections.Generic;
using System.Text;
using BinTreeNodeClass;
using LinkQueueClass;

namespace BinTreeClass
{
    public class BinTree<T>
    {
        private string orderString;
        private BinTreeNode<T> root;
        public BinTreeNode<T> Root
        {
            get
            {
                return this.root;
            }
            set
            {
                this.root = value;
            }
        }
        // 构造函数
        public BinTree(BinTreeNode<T> root)
        {
            this.root = root;
        }
        // 向二叉树中插入节点
        public void Insert(BinTreeNode<T> current, BinTreeNode<T> leftchild, BinTreeNode<T> rightchild)
        {
            if (root == null) throw new Exception("树为空");
            if (current == null) throw new Exception("插入节点不能为空");
            current.LeftChild = leftchild;
            current.RightChild = rightchild;
        }
        // 先序遍历
        private void PreOrder(BinTreeNode<T> current)
        {
            if (current == null) return;
            this.orderString += current.Data.ToString() + " ";
            this.PreOrder(current.LeftChild);
            this.PreOrder(current.RightChild);
        }
        public string PreOrderTraversal()
        {
            this.orderString = string.Empty;
            PreOrder(this.root);
            return this.orderString.Trim();
        }
        // 中序遍历
        private void MidOrder(BinTreeNode<T> current)
        {
            if (current == null) return;
            MidOrder(current.LeftChild);
            orderString += current.Data.ToString() + " ";
            MidOrder(current.RightChild);
        }
        public string MidOrderTraversal()
        {
            this.orderString = string.Empty;
            MidOrder(this.root);
            return this.orderString.Trim();
        }
        // 后序遍历
        private void PostOrder(BinTreeNode<T> current)
        {
            if (current == null) return;
            PostOrder(current.LeftChild);
            PostOrder(current.RightChild);
            orderString += current.Data.ToString() + " ";
        }
        public string PostOrderTraversal()
        {
            this.orderString = string.Empty;
            PostOrder(this.root);
            return this.orderString;
        }
        // 层级遍历,利用队列(从根节点开始入队)
        public string LevelTraversal()
        {
            this.orderString = string.Empty;
            if (root == null) return this.orderString;
            LinkQueue<BinTreeNode<T>> LQ = new LinkQueue<BinTreeNode<T>>();
            LQ.EnQueue(this.root);
            while (LQ.IsEmpty() == false)
            {
                BinTreeNode<T> temp = LQ.QueueFront;
                LQ.DeQueue();
                orderString += temp.Data.ToString() + " ";
                if (temp.LeftChild != null) LQ.EnQueue(temp.LeftChild);
                if (temp.RightChild != null) LQ.EnQueue(temp.RightChild);
            }
            return this.orderString.Trim();
        }
        // 找父节点
        private BinTreeNode<T> FindParent(BinTreeNode<T> current, BinTreeNode<T> find)
        {
            if (find == null) throw new Exception("出入参数有错");
            if (current == null) return null;
            if (current.LeftChild != null && current.LeftChild.Equals(find))
            {
                return current;
            }
            if (current.RightChild != null && current.RightChild.Equals(find))
            {
                return current;
            }
            BinTreeNode<T> temp = FindParent(current.LeftChild, find);
            if (temp != null)
            {
                return temp;
            }
            else
            {
                return FindParent(current.RightChild, find);
            }
        }
        public BinTreeNode<T> GetParent(BinTreeNode<T> find)
        {
            if (find == null) throw new Exception("传入参数为null");
            return FindParent(root, find);
        }
        // 找左兄弟节点
        public BinTreeNode<T> GetLeftSibling(BinTreeNode<T> current)
        {
            if (current == null) throw new Exception("参数传入有错");
            BinTreeNode<T> parent = GetParent(current);
            if (parent != null && parent.LeftChild != null && parent.LeftChild.Equals(current) == false)
            {
                return parent.LeftChild;
            }
            else
            {
                return null;
            }
        }
        // 找右兄弟节点
        public BinTreeNode<T> GetRightSibling(BinTreeNode<T> current)
        {
            if (current == null) throw new Exception("参数传入有错");
            BinTreeNode<T> parent = GetParent(current);
            if (parent != null && parent.RightChild != null && parent.RightChild.Equals(current) == false)
            {
                return parent.RightChild;
            }
            else
            {
                return null;
            }
        }
        // 删除节点
        public void DeleteSubTree(BinTreeNode<T> current)
        {
            if (current == null) throw new Exception("传入参数有误");
            if (this.root == null) throw new Exception("树为空");
            if (root.Equals(this.root))
            {
                this.root = null;
            }
            else
            {
                BinTreeNode<T> parent = GetParent(current);
                if (parent != null && parent.LeftChild != null && parent.LeftChild.Equals(current))
                {
                    parent.LeftChild = null;
                }
                if (parent != null && parent.RightChild != null && parent.LeftChild.Equals(current))
                {
                    parent.RightChild = null;
                }
            }
        }
        // 寻找对应节点
        private BinTreeNode<T> FindData(BinTreeNode<T> current, T data)
        {
            if (data == null) throw new Exception("出入参数有误");
            if (current == null) return null;
            if (current.Data.Equals(data)) return current;
            BinTreeNode<T> temp = FindData(current.LeftChild, data);
            if (temp != null)
            {
                return temp;
            }
            else
            {
                return FindData(current.RightChild, data);
            }
        }
        public BinTreeNode<T> Search(T data)
        {
            if (data == null) throw new Exception("参数传入有错");
            return FindData(root, data);
        }
        // 叶子节点数量
        private void FindLeafCount(BinTreeNode<T> current, ref int count)
        {
            if (current == null) return;
            if (current.LeftChild == null && current.RightChild == null)
            {
                ++count;
                return;
            }
            FindLeafCount(current.LeftChild, ref count);
            FindLeafCount(current.RightChild, ref count);
        }
        public int GetLeafCount()
        {
            int count = 0;
            FindLeafCount(this.root, ref count);
            return count;
        }
        // 交换左右节点
        private void Exchange(BinTreeNode<T> current)
        {
            if (current == null) return;
            if (current.LeftChild != null || current.RightChild != null)
            {
                BinTreeNode<T> temp = current.LeftChild;
                current.LeftChild = current.RightChild;
                current.RightChild = temp;
            }
            if (current.LeftChild != null)
            {
                Exchange(current.LeftChild);
            }
            if (current.RightChild != null)
            {
                Exchange(current.RightChild);
            }
        }
        public void Exchange()
        {
            Exchange(root);
        }
    }
}
