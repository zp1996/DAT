using System;
using System.Collections.Generic;
using System.Text;

namespace SpanTreeNodeClass
{
    public class SpanTreeNode
    {
        private string selfName;

        public string SelfName
        {
            get { return selfName; }
            set { selfName = value; }
        }
        private string parentName;

        public string ParentName
        {
            get { return parentName; }
            set { parentName = value; }
        }
        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public SpanTreeNode() 
        {
            this.selfName = string.Empty;
            this.parentName = string.Empty;
            this.weight = 0.0;
        }
        public SpanTreeNode(string selfName, string parentName, double weight) 
        {
            this.selfName = selfName;
            this.parentName = parentName;
            this.weight = weight;
        }
    }
}
