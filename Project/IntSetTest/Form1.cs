using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntSetClass;

namespace IntSetTest
{
    public partial class Form1 : Form
    {
        private IntSet setA;
        private IntSet setB;
        public Form1() 
        {
            InitializeComponent();
            setA = new IntSet(80);
            setB = new IntSet(80);
            stringA.Text = setA.GetBitString();
            ElementA.Text = setA.GetElement();
            stringB.Text = setB.GetBitString();
            ElementB.Text = setB.GetElement();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void InsertUpdate(IntSet set, NumericUpDown e, TextBox stringBox, TextBox elementBox) 
        {
            try
            {
                uint elt = (uint)e.Value;
                set.Insert(elt);
                this.Update(stringBox, elementBox, set.GetBitString(), set.GetElement());
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void RemoveUpdate(IntSet set, NumericUpDown e, TextBox stringBox, TextBox elementBox)
        {
            try
            {
                uint elt = (uint)e.Value;
                set.Remove(elt);
                this.Update(stringBox, elementBox, set.GetBitString(), set.GetElement());
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void Update(TextBox stringBox, TextBox elementBox, string textString, string textElement) 
        {
            elementBox.Clear();
            stringBox.Clear();
            elementBox.Text = textElement;
            stringBox.Text = textString;
        }
        // 添加删除A集合
        private void InsertA_Click(object sender, EventArgs e)
        {
            this.InsertUpdate(setA, ANumber, stringA, ElementA);
        }
        private void RemoveA_Click(object sender, EventArgs e)
        {
            this.RemoveUpdate(setA, ANumber, stringA, ElementA);
        }
        // 添加删除B集合
        private void InsertB_Click(object sender, EventArgs e)
        {
            this.InsertUpdate(setB, BNumber, stringB, ElementB);
        }
        private void RemoveB_Click(object sender, EventArgs e)
        {
            this.RemoveUpdate(setB, BNumber, stringB, ElementB);
        }
        // A并B
        private void Union_Click(object sender, EventArgs e)
        {
            try
            {
                IntSet newSet = setA.Union(setB);
                this.Update(stringAunB, ElementAunB, newSet.GetBitString(), newSet.GetElement());
            }
            catch (Exception error) 
            {
                MessageBox.Show(error.Message);
            }     
        }
        // A交B
        private void Intersect_Click(object sender, EventArgs e)
        {
            try
            {
                IntSet newSet = setA.Intersect(setB);
                this.Update(stringAinB, ElementAinB, newSet.GetBitString(), newSet.GetElement());
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        // A差B
        private void DiffSet_Click(object sender, EventArgs e)
        {
            try
            {
                IntSet newSet = setA.DiffSet(setB);
                this.Update(stringAsubB, ElementAsubB, newSet.GetBitString(), newSet.GetElement());
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        // A的补集
        private void Complement_Click(object sender, EventArgs e)
        {
            try
            {
                IntSet newSet = setA.Complement();
                this.Update(stringAcom, ElementAcom, newSet.GetBitString(), newSet.GetElement());
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(setA.Equals(setB).ToString());
            }
            catch (Exception error) 
            {
                MessageBox.Show(error.Message);
            }
        }

        private void IsSubSet_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(setA.IsSubSet(setB).ToString());
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void ANumber_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
