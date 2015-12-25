using System;
using System.Collections.Generic;
using System.Text;
using LinkQueueClass;
using VertexNodeClass;
using EdgeNodeClass;

namespace AdGraphClass
{
    public class AdGraph
    {
        private VertexNode[] vertexList;
        private int vertexCount;
        public int VertexCount
        {
            get
            {
                return this.vertexCount;
            }
        }
        public string this[int index]
        {
            get
            {
                if (index < 0 || index > this.vertexCount) throw new Exception("索引位置有错");
                return this.vertexList[index] == null ? "NULL" : this.vertexList[index].VertextName;
            }
            set
            {
                if (index < 0 || index > this.vertexCount) throw new Exception("索引位置有错");
                if (this.vertexList[index] == null)
                {
                    this.vertexList[index] = new VertexNode(value);
                }
                else
                {
                    this.vertexList[index].VertextName = value;
                }
            }
        }
        public AdGraph(int count)
        {
            if (count < 0) throw new Exception("索引值传入有错");
            this.vertexCount = count;
            this.vertexList = new VertexNode[count];
        }
        private int GetIndex(string name)
        {
            int i;
            for (i = 0; i < this.vertexCount; i++)
            {
                if (this.vertexList[i] != null && this.vertexList[i].VertextName == name)
                {
                    break;
                }
            }
            return i == this.vertexCount ? -1 : i;
        }
        // 添加边
        private void AddEdge(string startName, string endName, double weight)
        {
            int i = this.GetIndex(startName),
                j = this.GetIndex(endName);
            if (i == -1 || j == -1)
            {
                throw new Exception("不存在这个的两个节点");
            }
            EdgeNode temp = this.vertexList[i].FirstNode;
            if (temp == null)
            {
                this.vertexList[i].FirstNode = new EdgeNode(j, weight);
            }
            else
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new EdgeNode(j, weight);
            }
        }
        // 深度优先搜索
        private void DFS(int i, ref string result)
        {
            this.vertexList[i].Visited = true;
            result += this.vertexList[i].VertextName + "\n";
            EdgeNode temp = this.vertexList[i].FirstNode;
            while (temp != null)
            {
                if (this.vertexList[temp.Index].Visited == true)
                {
                    temp = temp.Next;
                }
                else
                {
                    this.DFS(temp.Index, ref result);
                }
            }
        }
        public string DFSTraversal(string startName)
        {
            int i = this.GetIndex(startName);
            if (i == -1) throw new Exception("图中不存在该节点");
            string result = string.Empty;
            for (int j = 0; j < this.vertexCount; j++)
            {
                this.vertexList[j].Visited = false;
            }
            this.DFS(i, ref result);
            return result;
        }
        // 广度优先搜索
        public string BFSTraversal(string startName)
        {
            int i = this.GetIndex(startName);
            if (i == -1) throw new Exception("图中不存在该节点");
            string result = string.Empty;
            LinkQueue<int> Q = new LinkQueue<int>();
            for (int j = 0; j < this.vertexCount; j++)
            {
                this.vertexList[i].Visited = false;
            }
            this.vertexList[i].Visited = true;
            result += this.vertexList[i].VertextName + "\n";
            Q.EnQueue(i);
            while (Q.IsEmpty() == false)
            {
                int k = Q.QueueFront;
                Q.DeQueue();
                EdgeNode temp = this.vertexList[k].FirstNode;
                while (temp != null)
                {
                    if (this.vertexList[temp.Index].Visited == false)
                    {
                        this.vertexList[temp.Index].Visited = true;
                        result += this.vertexList[temp.Index].VertextName + "\n";
                        Q.EnQueue(temp.Index);
                    }
                    temp = temp.Next;
                }
            }
            return result;
        }
        // 拓扑排序
        // 返回所有顶点的入度
        private int[] GetDegressList()
        {
            int[] result = new int[this.vertexCount];
            for (int i = 0; i < this.vertexCount; i++)
            {
                EdgeNode temp = this.vertexList[i].FirstNode;
                while (temp != null)
                {
                    result[temp.Index]++;
                    temp = temp.Next;
                }
            }
            return result;
        }
        public string TopoSort()
        {
            string result = string.Empty;
            int[] ID = this.GetDegressList();
            LinkQueue<int> Q = new LinkQueue<int>();
            for (int i = 0; i < this.vertexCount; i++)
            {
                if (ID[i] == 0)
                {
                    Q.EnQueue(i);
                }
            }
            if (Q.Length == this.vertexCount) throw new Exception("此有向图无有向边");
            while (Q.IsEmpty() == false)
            {
                int j = Q.QueueFront;
                Q.DeQueue();
                result += this.vertexList[j].VertextName + "\n";
                EdgeNode temp = this.vertexList[j].FirstNode;
                while (temp != null)
                {
                    ID[temp.Index]--;
                    if (ID[temp.Index] == 0)
                    {
                        Q.EnQueue(temp.Index);
                    }
                    temp = temp.Next;
                }
            }
            int k;
            for (k = 0; k < this.vertexCount; k++)
            {
                if (ID[k] != 0) break;
            }
            return k == this.vertexCount ? result : "该AOV网中有环";
        }
    }
}
