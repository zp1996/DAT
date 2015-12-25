using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BinTreeNodeClass;
using BinTreeClass;

namespace BinTreeTest
{
    public partial class Form1 : Form
    {
        private int index = 1;
        private BinTree<string> tree;
        public Form1()
        {
            BinTreeNode<string> A = new BinTreeNode<string>("A");
            BinTreeNode<string> B = new BinTreeNode<string>("B");
            BinTreeNode<string> C = new BinTreeNode<string>("C");
            BinTreeNode<string> D = new BinTreeNode<string>("D");
            BinTreeNode<string> E = new BinTreeNode<string>("E");
            BinTreeNode<string> F = new BinTreeNode<string>("F");
            BinTreeNode<string> G = new BinTreeNode<string>("G");
            BinTreeNode<string> H = new BinTreeNode<string>("H");
            BinTreeNode<string> I = new BinTreeNode<string>("I");
            tree = new BinTree<string>(A);
            tree.Insert(A, B, C);
            tree.Insert(B, D, null);
            tree.Insert(C, E, F);
            tree.Insert(E, null, G);
            tree.Insert(F, H, I);
            InitializeComponent();
        }

        private void Exchange_Click(object sender, EventArgs e)
        {
            this.tree.Exchange();
            if (this.index++ % 2 != 0)
            {
                Start.Image = BinTreeTest.Properties.Resources.change;
            }
            else 
            {
                Start.Image = BinTreeTest.Properties.Resources.start;
            }
        }

        private void PreOrder_Click(object sender, EventArgs e)
        {
            try
            {
                PreOrderString.Text = this.tree.PreOrderTraversal();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void MidOrder_Click(object sender, EventArgs e)
        {
            try
            {
                MidOrderString.Text = this.tree.MidOrderTraversal();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void PostOrder_Click(object sender, EventArgs e)
        {
            try
            {
                PostOrderString.Text = this.tree.PostOrderTraversal();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void LevelOrder_Click(object sender, EventArgs e)
        {
            try
            {
            LevelOrderString.Text = this.tree.LevelTraversal();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void parent_Click(object sender, EventArgs e)
        {
            try
            {
                parentString.Text = tree.GetParent(tree.Search(Node.Text)).Data.ToString();
            }
            catch (Exception error) 
            {
                parentString.Text = "没有双亲节点";
            }
        }

        private void Left_Click(object sender, EventArgs e)
        {
            try
            {
                LeftString.Text = tree.GetLeftSibling(tree.Search(Node.Text)).Data.ToString();
            }
            catch (Exception error)
            {
                LeftString.Text = "没有左兄弟";
            }
        }

        private void Right_Click(object sender, EventArgs e)
        {
            try
            {
                RightString.Text = tree.GetRightSibling(tree.Search(Node.Text)).Data.ToString();
            }
            catch (Exception error)
            {
                RightString.Text = "没有右兄弟";
            }
        }

        private void Count_Click(object sender, EventArgs e)
        {
            try
            {
                CountString.Text = tree.GetLeafCount().ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
