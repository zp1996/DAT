namespace MatTest
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
            this.startOrder = new System.Windows.Forms.Button();
            this.inputMatrix = new System.Windows.Forms.RichTextBox();
            this.TripleText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TransponseA = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TripleTranA = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddMatTran = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TripleAddTranMat = new System.Windows.Forms.RichTextBox();
            this.MulTranMat = new System.Windows.Forms.Label();
            this.MulMatTran = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TripleMulTranMat = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // startOrder
            // 
            this.startOrder.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.startOrder.Location = new System.Drawing.Point(23, 155);
            this.startOrder.Name = "startOrder";
            this.startOrder.Size = new System.Drawing.Size(75, 23);
            this.startOrder.TabIndex = 0;
            this.startOrder.Text = "生成三元组";
            this.startOrder.UseVisualStyleBackColor = true;
            this.startOrder.Click += new System.EventHandler(this.startOrder_Click);
            // 
            // inputMatrix
            // 
            this.inputMatrix.Location = new System.Drawing.Point(23, 28);
            this.inputMatrix.Name = "inputMatrix";
            this.inputMatrix.Size = new System.Drawing.Size(147, 96);
            this.inputMatrix.TabIndex = 1;
            this.inputMatrix.Text = "";
            this.inputMatrix.TextChanged += new System.EventHandler(this.inputMatrix_TextChanged);
            // 
            // TripleText
            // 
            this.TripleText.Location = new System.Drawing.Point(23, 213);
            this.TripleText.Name = "TripleText";
            this.TripleText.Size = new System.Drawing.Size(147, 227);
            this.TripleText.TabIndex = 2;
            this.TripleText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "A的转置";
            // 
            // TransponseA
            // 
            this.TransponseA.Location = new System.Drawing.Point(228, 28);
            this.TransponseA.Name = "TransponseA";
            this.TransponseA.Size = new System.Drawing.Size(161, 96);
            this.TransponseA.TabIndex = 4;
            this.TransponseA.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "请输入矩阵";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(226, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "A转置所对应的三元组";
            // 
            // TripleTranA
            // 
            this.TripleTranA.Location = new System.Drawing.Point(228, 213);
            this.TripleTranA.Name = "TripleTranA";
            this.TripleTranA.Size = new System.Drawing.Size(163, 227);
            this.TripleTranA.TabIndex = 7;
            this.TripleTranA.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(452, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "A+A\'";
            // 
            // AddMatTran
            // 
            this.AddMatTran.Location = new System.Drawing.Point(454, 28);
            this.AddMatTran.Name = "AddMatTran";
            this.AddMatTran.Size = new System.Drawing.Size(160, 96);
            this.AddMatTran.TabIndex = 9;
            this.AddMatTran.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(452, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "A+A\'转置所对应的三元组";
            // 
            // TripleAddTranMat
            // 
            this.TripleAddTranMat.Location = new System.Drawing.Point(454, 213);
            this.TripleAddTranMat.Name = "TripleAddTranMat";
            this.TripleAddTranMat.Size = new System.Drawing.Size(160, 227);
            this.TripleAddTranMat.TabIndex = 11;
            this.TripleAddTranMat.Text = "";
            // 
            // MulTranMat
            // 
            this.MulTranMat.AutoSize = true;
            this.MulTranMat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MulTranMat.Location = new System.Drawing.Point(693, 9);
            this.MulTranMat.Name = "MulTranMat";
            this.MulTranMat.Size = new System.Drawing.Size(29, 12);
            this.MulTranMat.TabIndex = 12;
            this.MulTranMat.Text = "A*A\'";
            // 
            // MulMatTran
            // 
            this.MulMatTran.Location = new System.Drawing.Point(681, 28);
            this.MulMatTran.Name = "MulMatTran";
            this.MulMatTran.Size = new System.Drawing.Size(161, 96);
            this.MulMatTran.TabIndex = 13;
            this.MulMatTran.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(679, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "A+A\'转置所对应的三元组";
            // 
            // TripleMulTranMat
            // 
            this.TripleMulTranMat.Location = new System.Drawing.Point(681, 213);
            this.TripleMulTranMat.Name = "TripleMulTranMat";
            this.TripleMulTranMat.Size = new System.Drawing.Size(161, 227);
            this.TripleMulTranMat.TabIndex = 15;
            this.TripleMulTranMat.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.TripleMulTranMat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MulMatTran);
            this.Controls.Add(this.MulTranMat);
            this.Controls.Add(this.TripleAddTranMat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddMatTran);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TripleTranA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransponseA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TripleText);
            this.Controls.Add(this.inputMatrix);
            this.Controls.Add(this.startOrder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startOrder;
        private System.Windows.Forms.RichTextBox inputMatrix;
        private System.Windows.Forms.RichTextBox TripleText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TransponseA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TripleTranA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox AddMatTran;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox TripleAddTranMat;
        private System.Windows.Forms.Label MulTranMat;
        private System.Windows.Forms.RichTextBox MulMatTran;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox TripleMulTranMat;
    }
}

