using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ListInterface;

namespace City
{
    public partial class Form1 : Form
    {
        private CityList list = new CityList();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CityData data = this.makeData();
            this.list.InsertAtFirst(data);
            this.Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private CityData makeData() 
        {
            string name = textBox1.Text;
            int x = 0; 
            int y = 0;
            try
            {
                x = Convert.ToInt32(textBox2.Text);
                y = Convert.ToInt32(textBox3.Text);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            CityData city = new CityData(x,y,name);
            return city;
        }

        private void Update()
        {
            richTextBox1.Clear();
            for (int i = 0; i < this.list.Length; i++)
            {
                CityData childData = list[i];
                richTextBox1.AppendText(list[i].name + "\t" + list[i].X + "\t" + list[i].Y + "\n");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CityData data = this.makeData();
            this.list.InsertAtEnd(data);
            this.Update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                CityData data = this.makeData();
                int index = Convert.ToInt32(numericUpDown1.Value);
                this.list.Insert(index, data);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            this.Update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(numericUpDown2.Value);
                this.list.Remove(index);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            this.Update();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try 
            {
                CityData data = this.makeData();
                int index = Convert.ToInt32(numericUpDown3.Value);
                list[index] = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Update();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string name = textBox4.Text;
            CityData data = this.list.SearchPosInfo(name);
            if (data == null)
            {
                MessageBox.Show("并没有该城市");
            }
            else 
            {
                textBox5.Text = data.X.ToString();
                textBox6.Text = data.Y.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            try
            {
                int pointX = Convert.ToInt32(textBox7.Text);
                int pointY = Convert.ToInt32(textBox8.Text);
                int distance = Convert.ToInt32(textBox9.Text);
                this.list.SearchCity(distance, pointX, pointY);
                int len = this.list.dataInfo.Length;
                string str = "";
                for (int i = 0; i < len; i++) 
                {
                    if (list.dataInfo[i] != null) {
                        str += list.distances[i].ToString("0.00") + "\t" +list.dataInfo[i].name + "\t" + list.dataInfo[i].X + "\t" + list.dataInfo[i].Y + "\n";                
                    }
                    richTextBox2.Text = str;
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
