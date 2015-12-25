using System;
using System.Collections.Generic;
using System.Text;
using SLinkListClass;
using TripleClass;
using ListInterface;

namespace MatrixClass
{
    public class Matrix : IMatrix
    {
        private int rows;
        private int cols;
        private SLinkList<Triple> list = new SLinkList<Triple>();

        public int Rows
        {
            get
            {
                return this.rows;
            }
        }
        public int Cols
        {
            get
            {
                return this.cols;
            }
        }
        public Matrix(int rows, int cols)
        {
            if (rows < 0 || cols < 0) throw new Exception("行列传入有错");
            this.rows = rows;
            this.cols = cols;
        }
        public double this[int i, int j]
        {
            get
            {
                if (i < 0 || i > this.rows - 1 || j < 0 || j > this.cols - 1)
                {
                    throw new Exception("索引值传入有错误");
                }
                for (int k = 0; k < list.Length; k++)
                {
                    if (list[k].Cols == j && list[k].Rows == i)
                    {
                        return list[k].Val;
                    }
                }
                return 0.0;
            }
            set
            {
                if (i < 0 || i > this.rows - 1 || j < 0 || j > this.cols - 1)
                {
                    throw new Exception("索引值传入有错误");
                }
                int k;
                for (k = 0; k < list.Length; k++)
                {
                    if (list[k].Cols == j && list[k].Rows == i)
                    {
                        break;
                    }
                }
                if (k == list.Length)
                {
                    if (value != 0)
                    {
                        Triple node = new Triple(i, j, value);
                        list.InsertAtEnd(node);
                    }
                }
                else
                {
                    if (value == 0)
                    {
                        list.Remove(k);
                    }
                    else
                    {
                        list[k].Val = value;
                    }
                }
            }
        }
        public IMatrix Add(IMatrix B)
        {
            if (B == null) throw new Exception("请传入一个矩阵");
            if (this.cols != B.Cols || this.rows != B.Rows) throw new Exception("矩阵传入有错误");
            Matrix temp = new Matrix(this.rows, this.cols);
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    temp[i, j] = this[i, j] + B[i, j];
                }
            }
            return temp;
        }
        public static Matrix operator +(Matrix A, Matrix B)
        {
            if (A == null || B == null)
            {
                throw new Exception("矩阵传入有错误");
            }
            return A.Add(B) as Matrix;
        }
        public IMatrix Transpose()
        {
            Matrix temp = new Matrix(this.cols, this.rows);
            for (int i = 0; i < this.cols; i++)
            {
                for (int j = 0; j < this.rows; j++)
                {
                    temp[i, j] = this[j, i];
                }
            }
            return temp;
        }
        public IMatrix Multiply(IMatrix B)
        {
            if (B == null) throw new Exception("请传入一个矩阵");
            if (B.Rows != this.cols) throw new Exception("矩阵传入有错误");
            Matrix temp = new Matrix(this.rows, B.Cols);
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < B.Cols; j++)
                {
                    for (int k = 0; k < this.cols; k++)
                    {
                        temp[i, j] += this[i, k] * B[k, j];
                    }
                }
            }
            return temp;
        }
        public static Matrix operator *(Matrix A, Matrix B)
        {
            if (A == null || B == null) throw new Exception("参数传入有错误");
            return A.Multiply(B) as Matrix;
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < list.Length; i++)
            {
                str += list[i].ToString() + "\n";
            }
            return str;
        }
    }
}
