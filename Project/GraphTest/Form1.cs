using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AdGraphClass;
using EdgeNodeClass;

namespace GraphTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            AdGraph CityGraph = new AdGraph(17);
            // 添加构成网络的节点
            CityGraph[0] = "San Rapeal";
            CityGraph[1] = "Cross";
            CityGraph[2] = "Daly Cit";
            CityGraph[3] = "San Francisco";
            CityGraph[4] = "Qakland";
            CityGraph[5] = "San larenzo";
            CityGraph[6] = "Cross B";
            CityGraph[7] = "San Mateo";
            CityGraph[8] = "Hayward";
            CityGraph[9] = "Dublin";
            CityGraph[10] = "Redwood City";
            CityGraph[11] = "Cross C";
            CityGraph[12] = "Palo Alto";
            CityGraph[13] = "Freemont";
            CityGraph[14] = "Mtn View";
            CityGraph[15] = "Cupertin";
            CityGraph[16] = "San Jose";
            // 添加边
            CityGraph.AddEdge("San Rapeal", "Cross", 12);
            CityGraph.AddEdge("San Rapeal", "Qakland", 18);
            CityGraph.AddEdge("Cross", "San Rapeal", 12);
            CityGraph.AddEdge("Cross", "Daly Cit", 3);
            CityGraph.AddEdge("Cross", "San Francisco", 3);
            CityGraph.AddEdge("Daly Cit", "Cross", 3);
            CityGraph.AddEdge("Daly Cit", "San Francisco", 4);
            CityGraph.AddEdge("Daly Cit", "Cross B", 19);
            CityGraph.AddEdge("San Francisco", "Daly Cit", 4);
            CityGraph.AddEdge("San Francisco", "Qakland", 7);
            CityGraph.AddEdge("San Francisco", "Cross", 3);
            CityGraph.AddEdge("Qakland", "San Rapheal", 18);
            CityGraph.AddEdge("Qakland", "San Francisco", 7);
            CityGraph.AddEdge("Qakland", "San larenzo", 18);
            CityGraph.AddEdge("Qakland", "Dublin", 31);
            //CityGraph.AddEdge("San larenzo","")
            InitializeComponent();
        }

        private void DFSBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
