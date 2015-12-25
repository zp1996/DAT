using System;
using System.Collections.Generic;
using System.Text;

namespace MGraphClass
{
    public class MGraph
    {
        // 二维邻接矩阵
        private double[,] adMatrix;
        // 存储图中各个节点名字的数组
        private string[] vertexNameList;
        // 图中节点个数
        private int vertextCount;
        public int VertextCount
        {
            get
            {
                return this.vertextCount;
            }
        }
        public string this[int index]
        {
            get
            {
                if (index < 0 || index > this.vertexNameList.Length - 1)
                {
                    throw new Exception("索引位置传入有错");
                }
                return this.vertexNameList[index];
            }
            set
            {
                if (index < 0 || index > this.vertexNameList.Length - 1)
                {
                    throw new Exception("索引位置传入有错");
                }
                this.vertexNameList[index] = value;
            }
        }
        public MGraph(int vCount)
        {
            if (vCount < 0) throw new Exception("图中节点个数不能小于0");
            this.vertexNameList = new string[vCount];
            this.vertextCount = vCount;
            this.adMatrix = new double[vCount, vCount];
        }
        // 找出对应名字的节点的索引
        private int GetIndex(string Vertexname)
        {
            int i;
            for (i = 0; i < this.vertextCount; i++)
            {
                if (this.vertexNameList[i] == Vertexname)
                    break;
            }
            return i == this.vertextCount ? -1 : i;
        }
        // 给邻接矩阵赋值
        public void AddEdge(string startVertextName, string endVertextName, double weight)
        {
            int i = this.GetIndex(startVertextName);
            int j = this.GetIndex(endVertextName);
            if (i == -1 || j == -1) throw new Exception("所传入的起始位置与");
            this.adMatrix[i, j] = weight;
        }
    }
}
