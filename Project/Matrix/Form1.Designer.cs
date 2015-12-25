namespace MatrixTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputMatrix = new System.Windows.Forms.RichTextBox();
            this.startOrder = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "稀疏矩阵A";
            // 
            // inputMatrix
            // 
            this.inputMatrix.Location = new System.Drawing.Point(12, 35);
            this.inputMatrix.Name = "inputMatrix";
            this.inputMatrix.Size = new System.Drawing.Size(162, 96);
            this.inputMatrix.TabIndex = 1;
            this.inputMatrix.Text = "";
            // 
            // startOrder
            // 
            this.startOrder.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.startOrder.Location = new System.Drawing.Point(12, 156);
            this.startOrder.Name = "startOrder";
            this.startOrder.Size = new System.Drawing.Size(75, 23);
            this.startOrder.TabIndex = 2;
            this.startOrder.Text = "对应三元组";
            this.startOrder.UseVisualStyleBackColor = true;
            this.startOrder.Click += new System.EventHandler(this.startOrder_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 198);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(162, 237);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.startOrder);
            this.Controls.Add(this.inputMatrix);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "稀疏矩阵实验";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox inputMatrix;
        private System.Windows.Forms.Button startOrder;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

