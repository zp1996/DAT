namespace BinTreeTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.PictureBox();
            this.Exchange = new System.Windows.Forms.Button();
            this.PreOrder = new System.Windows.Forms.Button();
            this.PreOrderString = new System.Windows.Forms.TextBox();
            this.MidOrder = new System.Windows.Forms.Button();
            this.MidOrderString = new System.Windows.Forms.TextBox();
            this.PostOrder = new System.Windows.Forms.Button();
            this.PostOrderString = new System.Windows.Forms.TextBox();
            this.LevelOrder = new System.Windows.Forms.Button();
            this.LevelOrderString = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Node = new System.Windows.Forms.ComboBox();
            this.parent = new System.Windows.Forms.Button();
            this.parentString = new System.Windows.Forms.TextBox();
            this.Left = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.LeftString = new System.Windows.Forms.TextBox();
            this.RightString = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.Button();
            this.CountString = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Image = global::BinTreeTest.Properties.Resources.start;
            this.Start.ImageLocation = "";
            this.Start.Location = new System.Drawing.Point(0, 0);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(389, 267);
            this.Start.TabIndex = 0;
            this.Start.TabStop = false;
            // 
            // Exchange
            // 
            this.Exchange.Location = new System.Drawing.Point(423, 271);
            this.Exchange.Name = "Exchange";
            this.Exchange.Size = new System.Drawing.Size(75, 23);
            this.Exchange.TabIndex = 1;
            this.Exchange.Text = "交换子树";
            this.Exchange.UseVisualStyleBackColor = true;
            this.Exchange.Click += new System.EventHandler(this.Exchange_Click);
            // 
            // PreOrder
            // 
            this.PreOrder.Location = new System.Drawing.Point(12, 285);
            this.PreOrder.Name = "PreOrder";
            this.PreOrder.Size = new System.Drawing.Size(75, 23);
            this.PreOrder.TabIndex = 2;
            this.PreOrder.Text = "先序遍历";
            this.PreOrder.UseVisualStyleBackColor = true;
            this.PreOrder.Click += new System.EventHandler(this.PreOrder_Click);
            // 
            // PreOrderString
            // 
            this.PreOrderString.Location = new System.Drawing.Point(109, 287);
            this.PreOrderString.Name = "PreOrderString";
            this.PreOrderString.Size = new System.Drawing.Size(280, 21);
            this.PreOrderString.TabIndex = 3;
            // 
            // MidOrder
            // 
            this.MidOrder.Location = new System.Drawing.Point(12, 333);
            this.MidOrder.Name = "MidOrder";
            this.MidOrder.Size = new System.Drawing.Size(75, 23);
            this.MidOrder.TabIndex = 4;
            this.MidOrder.Text = "中序遍历";
            this.MidOrder.UseVisualStyleBackColor = true;
            this.MidOrder.Click += new System.EventHandler(this.MidOrder_Click);
            // 
            // MidOrderString
            // 
            this.MidOrderString.Location = new System.Drawing.Point(109, 335);
            this.MidOrderString.Name = "MidOrderString";
            this.MidOrderString.Size = new System.Drawing.Size(280, 21);
            this.MidOrderString.TabIndex = 5;
            // 
            // PostOrder
            // 
            this.PostOrder.Location = new System.Drawing.Point(12, 384);
            this.PostOrder.Name = "PostOrder";
            this.PostOrder.Size = new System.Drawing.Size(75, 23);
            this.PostOrder.TabIndex = 6;
            this.PostOrder.Text = "后序遍历";
            this.PostOrder.UseVisualStyleBackColor = true;
            this.PostOrder.Click += new System.EventHandler(this.PostOrder_Click);
            // 
            // PostOrderString
            // 
            this.PostOrderString.Location = new System.Drawing.Point(109, 386);
            this.PostOrderString.Name = "PostOrderString";
            this.PostOrderString.Size = new System.Drawing.Size(280, 21);
            this.PostOrderString.TabIndex = 7;
            // 
            // LevelOrder
            // 
            this.LevelOrder.Location = new System.Drawing.Point(12, 431);
            this.LevelOrder.Name = "LevelOrder";
            this.LevelOrder.Size = new System.Drawing.Size(75, 23);
            this.LevelOrder.TabIndex = 8;
            this.LevelOrder.Text = "层次遍历";
            this.LevelOrder.UseVisualStyleBackColor = true;
            this.LevelOrder.Click += new System.EventHandler(this.LevelOrder_Click);
            // 
            // LevelOrderString
            // 
            this.LevelOrderString.Location = new System.Drawing.Point(109, 433);
            this.LevelOrderString.Name = "LevelOrderString";
            this.LevelOrderString.Size = new System.Drawing.Size(280, 21);
            this.LevelOrderString.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Node);
            this.groupBox1.Location = new System.Drawing.Point(423, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 74);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择节点";
            // 
            // Node
            // 
            this.Node.FormattingEnabled = true;
            this.Node.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I"});
            this.Node.Location = new System.Drawing.Point(39, 30);
            this.Node.Name = "Node";
            this.Node.Size = new System.Drawing.Size(121, 20);
            this.Node.TabIndex = 0;
            // 
            // parent
            // 
            this.parent.Location = new System.Drawing.Point(423, 105);
            this.parent.Name = "parent";
            this.parent.Size = new System.Drawing.Size(75, 23);
            this.parent.TabIndex = 1;
            this.parent.Text = "双亲";
            this.parent.UseVisualStyleBackColor = true;
            this.parent.Click += new System.EventHandler(this.parent_Click);
            // 
            // parentString
            // 
            this.parentString.Location = new System.Drawing.Point(530, 107);
            this.parentString.Name = "parentString";
            this.parentString.Size = new System.Drawing.Size(115, 21);
            this.parentString.TabIndex = 11;
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(423, 147);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(75, 23);
            this.Left.TabIndex = 1;
            this.Left.Text = "左兄弟";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(423, 190);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(75, 23);
            this.Right.TabIndex = 12;
            this.Right.Text = "右兄弟";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // LeftString
            // 
            this.LeftString.Location = new System.Drawing.Point(530, 147);
            this.LeftString.Name = "LeftString";
            this.LeftString.Size = new System.Drawing.Size(115, 21);
            this.LeftString.TabIndex = 13;
            // 
            // RightString
            // 
            this.RightString.Location = new System.Drawing.Point(530, 192);
            this.RightString.Name = "RightString";
            this.RightString.Size = new System.Drawing.Size(115, 21);
            this.RightString.TabIndex = 14;
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(423, 232);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(75, 23);
            this.Count.TabIndex = 15;
            this.Count.Text = "叶子节点数";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // CountString
            // 
            this.CountString.Location = new System.Drawing.Point(530, 234);
            this.CountString.Name = "CountString";
            this.CountString.Size = new System.Drawing.Size(115, 21);
            this.CountString.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 475);
            this.Controls.Add(this.CountString);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.RightString);
            this.Controls.Add(this.LeftString);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.parentString);
            this.Controls.Add(this.parent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LevelOrderString);
            this.Controls.Add(this.LevelOrder);
            this.Controls.Add(this.PostOrderString);
            this.Controls.Add(this.PostOrder);
            this.Controls.Add(this.MidOrderString);
            this.Controls.Add(this.MidOrder);
            this.Controls.Add(this.PreOrderString);
            this.Controls.Add(this.PreOrder);
            this.Controls.Add(this.Exchange);
            this.Controls.Add(this.Start);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.Text = "二叉树实验";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Start)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Start;
        private System.Windows.Forms.Button Exchange;
        private System.Windows.Forms.Button PreOrder;
        private System.Windows.Forms.TextBox PreOrderString;
        private System.Windows.Forms.Button MidOrder;
        private System.Windows.Forms.TextBox MidOrderString;
        private System.Windows.Forms.Button PostOrder;
        private System.Windows.Forms.TextBox PostOrderString;
        private System.Windows.Forms.Button LevelOrder;
        private System.Windows.Forms.TextBox LevelOrderString;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Node;
        private System.Windows.Forms.Button parent;
        private System.Windows.Forms.TextBox parentString;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.TextBox LeftString;
        private System.Windows.Forms.TextBox RightString;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.TextBox CountString;
    }
}

