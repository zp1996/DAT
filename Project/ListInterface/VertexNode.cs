using System;
using System.Collections.Generic;
using System.Text;
using EdgeNodeClass;

namespace VertexNodeClass
{
    public class VertexNode
    {
        private string vertextName;

        public string VertextName
        {
            get { return vertextName; }
            set { vertextName = value; }
        }
        private bool visited;

        public bool Visited
        {
            get { return visited; }
            set { visited = value; }
        }
        private EdgeNode firstNode;

        public EdgeNode FirstNode
        {
            get { return firstNode; }
            set { firstNode = value; }
        }
        public VertexNode(string name)
        {
            this.vertextName = name;
            this.visited = false;
            this.firstNode = null;
        }
        public VertexNode(string name, EdgeNode first)
        {
            this.vertextName = name;
            this.visited = false;
            this.firstNode = first;
        }
    }
}
