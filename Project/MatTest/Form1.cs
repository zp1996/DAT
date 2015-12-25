using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ListInterface;
using MatrixClass;

namespace MatTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void startOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string str = inputMatrix.Text;
                int rows = inputMatrix.Lines.Length;
                string[] strArr = str.Split('\n');
                string temp = strArr[0];
                int cols = temp.Split(' ').Length;
                if (cols != rows) throw new Exception("必须输入方阵");
                IMatrix matrix = new Matrix(rows, cols);
                for (int i = 0; i < rows; i++)
                {
                    string[] childStr = strArr[i].Split(' ');
                    if (childStr.Length != rows) throw new Exception("必须输入方阵");
                    for (int j = 0; j < cols; j++)
                    {
                        double val = Convert.ToDouble(childStr[j]);
                        if (val != 0.0)
                        {
                            matrix[i, j] = val;
                        }

                    }
                }
                IMatrix tranMat = matrix.Transpose();
                IMatrix AddtranMat = (Matrix)matrix + (Matrix)tranMat;
                IMatrix MultranMat = (Matrix)matrix * (Matrix)tranMat;
                // 生成三元组
                TripleText.Text = matrix.ToString();
                // 生成转置
                TransponseA.Text = this.toText(tranMat);
                // 生成转置的三元组
                TripleTranA.Text = tranMat.ToString();
                // A+A'
                AddMatTran.Text = this.toText(AddtranMat);
                // 生成A+A'的三元组
                TripleAddTranMat.Text = AddtranMat.ToString();
                // A*A'
                MulMatTran.Text = this.toText(MultranMat);
                // 生成A*A'的三元组
                TripleMulTranMat.Text = MultranMat.ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        // 生成矩阵
        private string toText(IMatrix A) 
        {
            string str = "";
            for (int i = 0; i < A.Rows; i++) 
            {
                for (int j = 0; j < A.Cols; j++) 
                {
                    if (A[i, j] == 0.0) str += " 0";
                    else str += " " + A[i, j];
                }
                str += "\n";
            }
            return str;
        }
        private void inputMatrix_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
