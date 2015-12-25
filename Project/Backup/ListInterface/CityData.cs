using System;
using System.Collections.Generic;
using System.Text;

namespace ListInterface
{
    public class CityList : SLinkList<CityData> 
    {
        public CityData[] dataInfo = new CityData[10];
        public double[] distances = new double[10];
        private int CDLen = 0;
        public CityData SearchPosInfo (string name) 
        {
            SNode<CityData> temp = this.pHead;
            for (int i = 0; i < this.length; i++) 
            {
                if (temp.Data.name == name) 
                {
                    return Locate(i).Data;
                }
                temp = temp.Next;
            }
            return null;
        }

        public void SearchCity(int distance, int pointX, int pointY) 
        {
            SNode<CityData> temp = this.pHead;
            for (int i = 0; i < this.length; i++)
            {
                double dis = Math.Sqrt(Math.Pow((temp.Data.X - pointX),2) + Math.Pow((temp.Data.Y - pointY),2));
                if (dis <= distance) 
                {
                    dataInfo[this.CDLen++] = temp.Data;
                    distances[this.CDLen - 1] = dis;
                }
                temp = temp.Next;
            }
        }
    }
    public class CityData
    {
        public int X;
        public int Y;
        public string name;
        public CityData(int x, int y, string name) 
        {
            this.X = x;
            this.Y = y;
            this.name = name;
        }
    }
}
