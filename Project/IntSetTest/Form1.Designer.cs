namespace IntSetTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemoveA = new System.Windows.Forms.Button();
            this.InsertA = new System.Windows.Forms.Button();
            this.ANumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RemoveB = new System.Windows.Forms.Button();
            this.InsertB = new System.Windows.Forms.Button();
            this.BNumber = new System.Windows.Forms.NumericUpDown();
            this.stringA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ElementA = new System.Windows.Forms.TextBox();
            this.Intersect = new System.Windows.Forms.Button();
            this.Union = new System.Windows.Forms.Button();
            this.DiffSet = new System.Windows.Forms.Button();
            this.Complement = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.EqualsJudge = new System.Windows.Forms.Label();
            this.IsSubSet = new System.Windows.Forms.Button();
            this.IsSubSetJudge = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stringB = new System.Windows.Forms.TextBox();
            this.ElementB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stringAunB = new System.Windows.Forms.TextBox();
            this.ElementAunB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stringAinB = new System.Windows.Forms.TextBox();
            this.ElementAinB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stringAsubB = new System.Windows.Forms.TextBox();
            this.ElementAsubB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.stringAcom = new System.Windows.Forms.TextBox();
            this.ElementAcom = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ANumber)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoveA);
            this.groupBox1.Controls.Add(this.InsertA);
            this.groupBox1.Controls.Add(this.ANumber);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "集合A";
            // 
            // RemoveA
            // 
            this.RemoveA.Location = new System.Drawing.Point(112, 60);
            this.RemoveA.Name = "RemoveA";
            this.RemoveA.Size = new System.Drawing.Size(75, 23);
            this.RemoveA.TabIndex = 2;
            this.RemoveA.Text = "移出集合";
            this.RemoveA.UseVisualStyleBackColor = true;
            this.RemoveA.Click += new System.EventHandler(this.RemoveA_Click);
            // 
            // InsertA
            // 
            this.InsertA.Location = new System.Drawing.Point(6, 60);
            this.InsertA.Name = "InsertA";
            this.InsertA.Size = new System.Drawing.Size(75, 23);
            this.InsertA.TabIndex = 2;
            this.InsertA.Text = "加入集合";
            this.InsertA.UseVisualStyleBackColor = true;
            this.InsertA.Click += new System.EventHandler(this.InsertA_Click);
            // 
            // ANumber
            // 
            this.ANumber.Location = new System.Drawing.Point(39, 20);
            this.ANumber.Name = "ANumber";
            this.ANumber.Size = new System.Drawing.Size(120, 21);
            this.ANumber.TabIndex = 2;
            this.ANumber.ValueChanged += new System.EventHandler(this.ANumber_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "集合元素的最大值为80";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RemoveB);
            this.groupBox2.Controls.Add(this.InsertB);
            this.groupBox2.Controls.Add(this.BNumber);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "集合B";
            // 
            // RemoveB
            // 
            this.RemoveB.Location = new System.Drawing.Point(112, 61);
            this.RemoveB.Name = "RemoveB";
            this.RemoveB.Size = new System.Drawing.Size(75, 23);
            this.RemoveB.TabIndex = 3;
            this.RemoveB.Text = "移出集合";
            this.RemoveB.UseVisualStyleBackColor = true;
            this.RemoveB.Click += new System.EventHandler(this.RemoveB_Click);
            // 
            // InsertB
            // 
            this.InsertB.Location = new System.Drawing.Point(6, 61);
            this.InsertB.Name = "InsertB";
            this.InsertB.Size = new System.Drawing.Size(75, 23);
            this.InsertB.TabIndex = 2;
            this.InsertB.Text = "加入集合";
            this.InsertB.UseVisualStyleBackColor = true;
            this.InsertB.Click += new System.EventHandler(this.InsertB_Click);
            // 
            // BNumber
            // 
            this.BNumber.Location = new System.Drawing.Point(39, 20);
            this.BNumber.Name = "BNumber";
            this.BNumber.Size = new System.Drawing.Size(120, 21);
            this.BNumber.TabIndex = 2;
            // 
            // stringA
            // 
            this.stringA.Location = new System.Drawing.Point(234, 42);
            this.stringA.Name = "stringA";
            this.stringA.Size = new System.Drawing.Size(518, 21);
            this.stringA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "集合A";
            // 
            // ElementA
            // 
            this.ElementA.Location = new System.Drawing.Point(234, 74);
            this.ElementA.Name = "ElementA";
            this.ElementA.Size = new System.Drawing.Size(518, 21);
            this.ElementA.TabIndex = 4;
            // 
            // Intersect
            // 
            this.Intersect.Location = new System.Drawing.Point(18, 265);
            this.Intersect.Name = "Intersect";
            this.Intersect.Size = new System.Drawing.Size(75, 23);
            this.Intersect.TabIndex = 5;
            this.Intersect.Text = "A交B";
            this.Intersect.UseVisualStyleBackColor = true;
            this.Intersect.Click += new System.EventHandler(this.Intersect_Click);
            // 
            // Union
            // 
            this.Union.Location = new System.Drawing.Point(124, 265);
            this.Union.Name = "Union";
            this.Union.Size = new System.Drawing.Size(75, 23);
            this.Union.TabIndex = 6;
            this.Union.Text = "A并B";
            this.Union.UseVisualStyleBackColor = true;
            this.Union.Click += new System.EventHandler(this.Union_Click);
            // 
            // DiffSet
            // 
            this.DiffSet.Location = new System.Drawing.Point(18, 316);
            this.DiffSet.Name = "DiffSet";
            this.DiffSet.Size = new System.Drawing.Size(75, 23);
            this.DiffSet.TabIndex = 7;
            this.DiffSet.Text = "A差B";
            this.DiffSet.UseVisualStyleBackColor = true;
            this.DiffSet.Click += new System.EventHandler(this.DiffSet_Click);
            // 
            // Complement
            // 
            this.Complement.Cursor = System.Windows.Forms.Cursors.Default;
            this.Complement.Location = new System.Drawing.Point(124, 316);
            this.Complement.Name = "Complement";
            this.Complement.Size = new System.Drawing.Size(75, 23);
            this.Complement.TabIndex = 8;
            this.Complement.Text = "A的补集";
            this.Complement.UseVisualStyleBackColor = true;
            this.Complement.Click += new System.EventHandler(this.Complement_Click);
            // 
            // Equals
            // 
            this.Equals.Location = new System.Drawing.Point(18, 368);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(107, 23);
            this.Equals.TabIndex = 9;
            this.Equals.Text = "两结合是否相等";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // EqualsJudge
            // 
            this.EqualsJudge.AutoSize = true;
            this.EqualsJudge.Location = new System.Drawing.Point(158, 379);
            this.EqualsJudge.Name = "EqualsJudge";
            this.EqualsJudge.Size = new System.Drawing.Size(0, 12);
            this.EqualsJudge.TabIndex = 10;
            // 
            // IsSubSet
            // 
            this.IsSubSet.Location = new System.Drawing.Point(18, 419);
            this.IsSubSet.Name = "IsSubSet";
            this.IsSubSet.Size = new System.Drawing.Size(107, 23);
            this.IsSubSet.TabIndex = 11;
            this.IsSubSet.Text = "B是否为A的子集";
            this.IsSubSet.UseVisualStyleBackColor = true;
            this.IsSubSet.Click += new System.EventHandler(this.IsSubSet_Click);
            // 
            // IsSubSetJudge
            // 
            this.IsSubSetJudge.AutoSize = true;
            this.IsSubSetJudge.Location = new System.Drawing.Point(158, 424);
            this.IsSubSetJudge.Name = "IsSubSetJudge";
            this.IsSubSetJudge.Size = new System.Drawing.Size(0, 12);
            this.IsSubSetJudge.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "集合B";
            // 
            // stringB
            // 
            this.stringB.Location = new System.Drawing.Point(234, 148);
            this.stringB.Name = "stringB";
            this.stringB.Size = new System.Drawing.Size(518, 21);
            this.stringB.TabIndex = 14;
            // 
            // ElementB
            // 
            this.ElementB.Location = new System.Drawing.Point(234, 185);
            this.ElementB.Name = "ElementB";
            this.ElementB.Size = new System.Drawing.Size(518, 21);
            this.ElementB.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "集合A并B";
            // 
            // stringAunB
            // 
            this.stringAunB.Location = new System.Drawing.Point(234, 256);
            this.stringAunB.Name = "stringAunB";
            this.stringAunB.Size = new System.Drawing.Size(518, 21);
            this.stringAunB.TabIndex = 17;
            // 
            // ElementAunB
            // 
            this.ElementAunB.Location = new System.Drawing.Point(234, 295);
            this.ElementAunB.Name = "ElementAunB";
            this.ElementAunB.Size = new System.Drawing.Size(518, 21);
            this.ElementAunB.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "集合A交B";
            // 
            // stringAinB
            // 
            this.stringAinB.Location = new System.Drawing.Point(234, 370);
            this.stringAinB.Name = "stringAinB";
            this.stringAinB.Size = new System.Drawing.Size(518, 21);
            this.stringAinB.TabIndex = 20;
            // 
            // ElementAinB
            // 
            this.ElementAinB.Location = new System.Drawing.Point(234, 415);
            this.ElementAinB.Name = "ElementAinB";
            this.ElementAinB.Size = new System.Drawing.Size(518, 21);
            this.ElementAinB.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "集合A差B";
            // 
            // stringAsubB
            // 
            this.stringAsubB.Location = new System.Drawing.Point(234, 490);
            this.stringAsubB.Name = "stringAsubB";
            this.stringAsubB.Size = new System.Drawing.Size(518, 21);
            this.stringAsubB.TabIndex = 23;
            // 
            // ElementAsubB
            // 
            this.ElementAsubB.Location = new System.Drawing.Point(234, 531);
            this.ElementAsubB.Name = "ElementAsubB";
            this.ElementAsubB.Size = new System.Drawing.Size(518, 21);
            this.ElementAsubB.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 570);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "集合A的补集";
            // 
            // stringAcom
            // 
            this.stringAcom.Location = new System.Drawing.Point(234, 606);
            this.stringAcom.Name = "stringAcom";
            this.stringAcom.Size = new System.Drawing.Size(518, 21);
            this.stringAcom.TabIndex = 26;
            // 
            // ElementAcom
            // 
            this.ElementAcom.Location = new System.Drawing.Point(234, 646);
            this.ElementAcom.Name = "ElementAcom";
            this.ElementAcom.Size = new System.Drawing.Size(518, 21);
            this.ElementAcom.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 687);
            this.Controls.Add(this.ElementAcom);
            this.Controls.Add(this.stringAcom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ElementAsubB);
            this.Controls.Add(this.stringAsubB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ElementAinB);
            this.Controls.Add(this.stringAinB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ElementAunB);
            this.Controls.Add(this.stringAunB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ElementB);
            this.Controls.Add(this.stringB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IsSubSetJudge);
            this.Controls.Add(this.IsSubSet);
            this.Controls.Add(this.EqualsJudge);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.Complement);
            this.Controls.Add(this.DiffSet);
            this.Controls.Add(this.Union);
            this.Controls.Add(this.Intersect);
            this.Controls.Add(this.ElementA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stringA);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ANumber)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RemoveA;
        private System.Windows.Forms.Button InsertA;
        private System.Windows.Forms.NumericUpDown ANumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button RemoveB;
        private System.Windows.Forms.Button InsertB;
        private System.Windows.Forms.NumericUpDown BNumber;
        private System.Windows.Forms.TextBox stringA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ElementA;
        private System.Windows.Forms.Button Intersect;
        private System.Windows.Forms.Button Union;
        private System.Windows.Forms.Button DiffSet;
        private System.Windows.Forms.Button Complement;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Label EqualsJudge;
        private System.Windows.Forms.Button IsSubSet;
        private System.Windows.Forms.Label IsSubSetJudge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stringB;
        private System.Windows.Forms.TextBox ElementB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stringAunB;
        private System.Windows.Forms.TextBox ElementAunB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stringAinB;
        private System.Windows.Forms.TextBox ElementAinB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stringAsubB;
        private System.Windows.Forms.TextBox ElementAsubB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox stringAcom;
        private System.Windows.Forms.TextBox ElementAcom;
    }
}

