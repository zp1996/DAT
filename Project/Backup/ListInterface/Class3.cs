using System;
using System.Collections.Generic;
using System.Text;

namespace ListInterface
{
    public class StudentData
    {
        public int id;
        public string name;
        public double score;
        public StudentData(int id,string name,double score) 
        {
            this.id = id;
            this.name = name;
            this.score = score;
        }
        public override string ToString()
        {
            return this.id + " " +this.name + " " + this.score;
        }
    }
}
