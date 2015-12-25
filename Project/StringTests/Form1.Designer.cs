namespace StringTests
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
            this.InputString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StringLength = new System.Windows.Forms.Label();
            this.SubStart = new System.Windows.Forms.NumericUpDown();
            this.StartIndex = new System.Windows.Forms.Label();
            this.SubCount = new System.Windows.Forms.Label();
            this.SubStringCount = new System.Windows.Forms.NumericUpDown();
            this.Subnew = new System.Windows.Forms.Label();
            this.SubNewText = new System.Windows.Forms.TextBox();
            this.StringLegthNum = new System.Windows.Forms.Label();
            this.SubString = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.InsertStart = new System.Windows.Forms.NumericUpDown();
            this.Insertlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InsertString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InsertnewString = new System.Windows.Forms.TextBox();
            this.RemoveStr = new System.Windows.Forms.Button();
            this.RemoveStart = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.Button();
            this.RemoveStartNum = new System.Windows.Forms.NumericUpDown();
            this.Clone = new System.Windows.Forms.Button();
            this.CloneString = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RemoveCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.RemovenewStr = new System.Windows.Forms.TextBox();
            this.Concat = new System.Windows.Forms.Button();
            this.ConcatChild = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ConcatNew = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Pattern = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Pos = new System.Windows.Forms.TextBox();
            this.Trim = new System.Windows.Forms.Button();
            this.TrimText = new System.Windows.Forms.TextBox();
            this.Replace = new System.Windows.Forms.Button();
            this.target = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.replacement = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ReplaceString = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SubStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubStringCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveStartNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveCount)).BeginInit();
            this.SuspendLayout();
            // 
            // InputString
            // 
            this.InputString.Location = new System.Drawing.Point(87, 21);
            this.InputString.Name = "InputString";
            this.InputString.Size = new System.Drawing.Size(222, 21);
            this.InputString.TabIndex = 0;
            this.InputString.TextChanged += new System.EventHandler(this.InputString_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "写入字符串";
            // 
            // StringLength
            // 
            this.StringLength.AutoSize = true;
            this.StringLength.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StringLength.Location = new System.Drawing.Point(357, 24);
            this.StringLength.Name = "StringLength";
            this.StringLength.Size = new System.Drawing.Size(101, 12);
            this.StringLength.TabIndex = 2;
            this.StringLength.Text = "该字符串的长度为";
            this.StringLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubStart
            // 
            this.SubStart.Location = new System.Drawing.Point(190, 59);
            this.SubStart.Name = "SubStart";
            this.SubStart.Size = new System.Drawing.Size(67, 21);
            this.SubStart.TabIndex = 4;
            // 
            // StartIndex
            // 
            this.StartIndex.AutoSize = true;
            this.StartIndex.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StartIndex.Location = new System.Drawing.Point(105, 61);
            this.StartIndex.Name = "StartIndex";
            this.StartIndex.Size = new System.Drawing.Size(65, 12);
            this.StartIndex.TabIndex = 5;
            this.StartIndex.Text = "StartIndex";
            // 
            // SubCount
            // 
            this.SubCount.AutoSize = true;
            this.SubCount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SubCount.Location = new System.Drawing.Point(290, 61);
            this.SubCount.Name = "SubCount";
            this.SubCount.Size = new System.Drawing.Size(35, 12);
            this.SubCount.TabIndex = 6;
            this.SubCount.Text = "Count";
            // 
            // SubStringCount
            // 
            this.SubStringCount.Location = new System.Drawing.Point(341, 59);
            this.SubStringCount.Name = "SubStringCount";
            this.SubStringCount.Size = new System.Drawing.Size(65, 21);
            this.SubStringCount.TabIndex = 7;
            // 
            // Subnew
            // 
            this.Subnew.AutoSize = true;
            this.Subnew.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Subnew.Location = new System.Drawing.Point(451, 61);
            this.Subnew.Name = "Subnew";
            this.Subnew.Size = new System.Drawing.Size(29, 12);
            this.Subnew.TabIndex = 8;
            this.Subnew.Text = "新串";
            // 
            // SubNewText
            // 
            this.SubNewText.Location = new System.Drawing.Point(504, 58);
            this.SubNewText.Name = "SubNewText";
            this.SubNewText.Size = new System.Drawing.Size(275, 21);
            this.SubNewText.TabIndex = 9;
            // 
            // StringLegthNum
            // 
            this.StringLegthNum.AutoSize = true;
            this.StringLegthNum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StringLegthNum.Location = new System.Drawing.Point(464, 24);
            this.StringLegthNum.Name = "StringLegthNum";
            this.StringLegthNum.Size = new System.Drawing.Size(11, 12);
            this.StringLegthNum.TabIndex = 10;
            this.StringLegthNum.Text = "0";
            // 
            // SubString
            // 
            this.SubString.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SubString.Location = new System.Drawing.Point(12, 56);
            this.SubString.Name = "SubString";
            this.SubString.Size = new System.Drawing.Size(75, 23);
            this.SubString.TabIndex = 11;
            this.SubString.Text = "取子串";
            this.SubString.UseVisualStyleBackColor = true;
            this.SubString.Click += new System.EventHandler(this.SubString_Click);
            // 
            // Insert
            // 
            this.Insert.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Insert.Location = new System.Drawing.Point(12, 109);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 12;
            this.Insert.Text = "插入子串";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // InsertStart
            // 
            this.InsertStart.Location = new System.Drawing.Point(189, 111);
            this.InsertStart.Name = "InsertStart";
            this.InsertStart.Size = new System.Drawing.Size(68, 21);
            this.InsertStart.TabIndex = 13;
            // 
            // Insertlabel
            // 
            this.Insertlabel.AutoSize = true;
            this.Insertlabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Insertlabel.Location = new System.Drawing.Point(105, 114);
            this.Insertlabel.Name = "Insertlabel";
            this.Insertlabel.Size = new System.Drawing.Size(65, 12);
            this.Insertlabel.TabIndex = 14;
            this.Insertlabel.Text = "StartIndex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(280, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "子串";
            // 
            // InsertString
            // 
            this.InsertString.Location = new System.Drawing.Point(328, 111);
            this.InsertString.Name = "InsertString";
            this.InsertString.Size = new System.Drawing.Size(100, 21);
            this.InsertString.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(451, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "新串";
            // 
            // InsertnewString
            // 
            this.InsertnewString.Location = new System.Drawing.Point(504, 110);
            this.InsertnewString.Name = "InsertnewString";
            this.InsertnewString.Size = new System.Drawing.Size(275, 21);
            this.InsertnewString.TabIndex = 18;
            // 
            // RemoveStr
            // 
            this.RemoveStr.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RemoveStr.Location = new System.Drawing.Point(12, 163);
            this.RemoveStr.Name = "RemoveStr";
            this.RemoveStr.Size = new System.Drawing.Size(75, 23);
            this.RemoveStr.TabIndex = 19;
            this.RemoveStr.Text = "删除子串";
            this.RemoveStr.UseVisualStyleBackColor = true;
            this.RemoveStr.Click += new System.EventHandler(this.RemoveStr_Click);
            // 
            // RemoveStart
            // 
            this.RemoveStart.AutoSize = true;
            this.RemoveStart.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RemoveStart.Location = new System.Drawing.Point(105, 168);
            this.RemoveStart.Name = "RemoveStart";
            this.RemoveStart.Size = new System.Drawing.Size(65, 12);
            this.RemoveStart.TabIndex = 20;
            this.RemoveStart.Text = "StartIndex";
            // 
            // Find
            // 
            this.Find.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Find.Location = new System.Drawing.Point(12, 217);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(75, 23);
            this.Find.TabIndex = 21;
            this.Find.Text = "模式匹配";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // RemoveStartNum
            // 
            this.RemoveStartNum.Location = new System.Drawing.Point(189, 163);
            this.RemoveStartNum.Name = "RemoveStartNum";
            this.RemoveStartNum.Size = new System.Drawing.Size(68, 21);
            this.RemoveStartNum.TabIndex = 22;
            // 
            // Clone
            // 
            this.Clone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Clone.Location = new System.Drawing.Point(12, 272);
            this.Clone.Name = "Clone";
            this.Clone.Size = new System.Drawing.Size(75, 23);
            this.Clone.TabIndex = 23;
            this.Clone.Text = "拷贝";
            this.Clone.UseVisualStyleBackColor = true;
            this.Clone.Click += new System.EventHandler(this.Clone_Click);
            // 
            // CloneString
            // 
            this.CloneString.Location = new System.Drawing.Point(116, 274);
            this.CloneString.Name = "CloneString";
            this.CloneString.Size = new System.Drawing.Size(290, 21);
            this.CloneString.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(290, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "Count";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // RemoveCount
            // 
            this.RemoveCount.Location = new System.Drawing.Point(341, 163);
            this.RemoveCount.Name = "RemoveCount";
            this.RemoveCount.Size = new System.Drawing.Size(65, 21);
            this.RemoveCount.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(451, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 27;
            this.label5.Text = "新串";
            // 
            // RemovenewStr
            // 
            this.RemovenewStr.Location = new System.Drawing.Point(504, 163);
            this.RemovenewStr.Name = "RemovenewStr";
            this.RemovenewStr.Size = new System.Drawing.Size(275, 21);
            this.RemovenewStr.TabIndex = 28;
            // 
            // Concat
            // 
            this.Concat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Concat.Location = new System.Drawing.Point(12, 326);
            this.Concat.Name = "Concat";
            this.Concat.Size = new System.Drawing.Size(75, 23);
            this.Concat.TabIndex = 29;
            this.Concat.Text = "连接串";
            this.Concat.UseVisualStyleBackColor = true;
            this.Concat.Click += new System.EventHandler(this.Concat_Click);
            // 
            // ConcatChild
            // 
            this.ConcatChild.Location = new System.Drawing.Point(209, 328);
            this.ConcatChild.Name = "ConcatChild";
            this.ConcatChild.Size = new System.Drawing.Size(228, 21);
            this.ConcatChild.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(105, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "写入的另一个串";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(451, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 32;
            this.label7.Text = "新串";
            // 
            // ConcatNew
            // 
            this.ConcatNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConcatNew.Location = new System.Drawing.Point(504, 328);
            this.ConcatNew.Name = "ConcatNew";
            this.ConcatNew.Size = new System.Drawing.Size(275, 21);
            this.ConcatNew.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(114, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 34;
            this.label8.Text = "模式串";
            // 
            // Pattern
            // 
            this.Pattern.Location = new System.Drawing.Point(189, 219);
            this.Pattern.Name = "Pattern";
            this.Pattern.Size = new System.Drawing.Size(100, 21);
            this.Pattern.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(339, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 36;
            this.label9.Text = "位置";
            // 
            // Pos
            // 
            this.Pos.Location = new System.Drawing.Point(403, 219);
            this.Pos.Name = "Pos";
            this.Pos.Size = new System.Drawing.Size(100, 21);
            this.Pos.TabIndex = 37;
            // 
            // Trim
            // 
            this.Trim.Location = new System.Drawing.Point(12, 377);
            this.Trim.Name = "Trim";
            this.Trim.Size = new System.Drawing.Size(109, 24);
            this.Trim.TabIndex = 38;
            this.Trim.Text = "去除两边空格";
            this.Trim.UseVisualStyleBackColor = true;
            this.Trim.Click += new System.EventHandler(this.Trim_Click);
            // 
            // TrimText
            // 
            this.TrimText.Location = new System.Drawing.Point(190, 380);
            this.TrimText.Name = "TrimText";
            this.TrimText.Size = new System.Drawing.Size(343, 21);
            this.TrimText.TabIndex = 39;
            // 
            // Replace
            // 
            this.Replace.Location = new System.Drawing.Point(12, 427);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(75, 23);
            this.Replace.TabIndex = 40;
            this.Replace.Text = "替换串";
            this.Replace.UseVisualStyleBackColor = true;
            this.Replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // target
            // 
            this.target.Location = new System.Drawing.Point(190, 429);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(78, 21);
            this.target.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 42;
            this.label10.Text = "所需替换串";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 43;
            this.label11.Text = "替换后串";
            // 
            // replacement
            // 
            this.replacement.Location = new System.Drawing.Point(359, 429);
            this.replacement.Name = "replacement";
            this.replacement.Size = new System.Drawing.Size(78, 21);
            this.replacement.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(451, 432);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 45;
            this.label12.Text = "新串";
            // 
            // ReplaceString
            // 
            this.ReplaceString.Location = new System.Drawing.Point(504, 427);
            this.ReplaceString.Name = "ReplaceString";
            this.ReplaceString.Size = new System.Drawing.Size(296, 21);
            this.ReplaceString.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 470);
            this.Controls.Add(this.ReplaceString);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.replacement);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.target);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.TrimText);
            this.Controls.Add(this.Trim);
            this.Controls.Add(this.Pos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Pattern);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ConcatNew);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ConcatChild);
            this.Controls.Add(this.Concat);
            this.Controls.Add(this.RemovenewStr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RemoveCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CloneString);
            this.Controls.Add(this.Clone);
            this.Controls.Add(this.RemoveStartNum);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.RemoveStart);
            this.Controls.Add(this.RemoveStr);
            this.Controls.Add(this.InsertnewString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InsertString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Insertlabel);
            this.Controls.Add(this.InsertStart);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.SubString);
            this.Controls.Add(this.StringLegthNum);
            this.Controls.Add(this.SubNewText);
            this.Controls.Add(this.Subnew);
            this.Controls.Add(this.SubStringCount);
            this.Controls.Add(this.SubCount);
            this.Controls.Add(this.StartIndex);
            this.Controls.Add(this.SubStart);
            this.Controls.Add(this.StringLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputString);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.Text = "串实验";
            ((System.ComponentModel.ISupportInitialize)(this.SubStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubStringCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveStartNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StringLength;
        private System.Windows.Forms.NumericUpDown SubStart;
        private System.Windows.Forms.Label StartIndex;
        private System.Windows.Forms.Label SubCount;
        private System.Windows.Forms.NumericUpDown SubStringCount;
        private System.Windows.Forms.Label Subnew;
        private System.Windows.Forms.TextBox SubNewText;
        private System.Windows.Forms.Label StringLegthNum;
        private System.Windows.Forms.Button SubString;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.NumericUpDown InsertStart;
        private System.Windows.Forms.Label Insertlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InsertString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InsertnewString;
        private System.Windows.Forms.Button RemoveStr;
        private System.Windows.Forms.Label RemoveStart;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.NumericUpDown RemoveStartNum;
        private System.Windows.Forms.Button Clone;
        private System.Windows.Forms.TextBox CloneString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown RemoveCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RemovenewStr;
        private System.Windows.Forms.Button Concat;
        private System.Windows.Forms.TextBox ConcatChild;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ConcatNew;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Pattern;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Pos;
        private System.Windows.Forms.Button Trim;
        private System.Windows.Forms.TextBox TrimText;
        private System.Windows.Forms.Button Replace;
        private System.Windows.Forms.TextBox target;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox replacement;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ReplaceString;
    }
}

