using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ListInterface;
using SeqStringClass;

namespace StringTests
{
    public partial class Form1 : Form
    {
        private IString str;
        public Form1()
        {
            InitializeComponent();
        }

        private void InputString_TextChanged(object sender, EventArgs e)
        {
            str = new SeqString(InputString.Text);
            StringLegthNum.Text = str.Length.ToString();
        }
        // 取子串
        private void SubString_Click(object sender, EventArgs e)
        {
            try
            {
                int start = (int)SubStart.Value;
                int count = (int)SubStringCount.Value;
                IString newStr = str.SubString(start, count);
                SubNewText.Text = newStr.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        // 插入子串
        private void Insert_Click(object sender, EventArgs e)
        {
            try 
            {
                int start = (int)InsertStart.Value;
                IString child = new SeqString(InsertString.Text);
                InsertnewString.Text = str.Insert(start, child).ToString();
            } 
            catch (Exception error) 
            {
                MessageBox.Show(error.Message);
            }
        }
        // 克隆串
        private void Clone_Click(object sender, EventArgs e)
        {
            CloneString.Text = str.Clone().ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        // 删除串
        private void RemoveStr_Click(object sender, EventArgs e)
        {
            try
            {
                int start = (int)RemoveStartNum.Value;
                int count = (int)RemoveCount.Value;
                IString newStr = str.Remove(start, count);
                RemovenewStr.Text = newStr.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        // 模式匹配
        private void Find_Click(object sender, EventArgs e)
        {
            try
            {
                IString pattern = new SeqString(Pattern.Text);
                Pos.Text = str.FindParam(pattern).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        // 连接串
        private void Concat_Click(object sender, EventArgs e)
        {
            try
            {
                IString pattern = new SeqString(ConcatChild.Text);
                ConcatNew.Text = (str.concat(pattern)).ToString();
            }
            catch (Exception error) 
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Trim_Click(object sender, EventArgs e)
        {
            TrimText.Text = str.Trim().ToString();
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            string targetStr = target.Text;
            string replaceStr = replacement.Text;
            try
            {
                IString newStr = this.str.Replace(targetStr, replaceStr, 0);
                ReplaceString.Text = newStr.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
