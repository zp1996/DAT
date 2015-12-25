using System;
using System.Collections.Generic;
using System.Text;

namespace TripleClass
{
    public class Triple
    {
        private int rows;
        private int cols;
        private double val;
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
        public double Val
        {
            get
            {
                return this.val;
            }
            set
            {
                this.val = value;
            }
        }
        public Triple(int i, int j, double val)
        {
            if (i < 0 || j < 0) throw new Exception("行列传入有错");
            this.rows = i;
            this.cols = j;
            this.val = val;
        }
        public override string ToString()
        {
            return string.Format("({0},{1},{2})", this.rows, this.cols, this.val);
        }
    }
}
