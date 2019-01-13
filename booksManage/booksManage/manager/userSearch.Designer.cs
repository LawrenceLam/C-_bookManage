namespace booksManage
{
    partial class userSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userSearch));
            System.Windows.Forms.Label label11;
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookManageDataSet = new booksManage.bookManageDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.学生类别号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.专业DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年级DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系电话DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.校内地址DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentmessageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookManageDataSet1 = new booksManage.bookManageDataSet1();
            this.bookManageDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_messageTableAdapter = new booksManage.bookManageDataSet1TableAdapters.student_messageTableAdapter();
            this.search = new System.Windows.Forms.Button();
            this.nianji = new System.Windows.Forms.TextBox();
            this.weizhi = new System.Windows.Forms.Label();
            this.zhuanye = new System.Windows.Forms.TextBox();
            this.chubanshe = new System.Windows.Forms.Label();
            this.xingming = new System.Windows.Forms.TextBox();
            this.zuozhe = new System.Windows.Forms.Label();
            this.xuehao = new System.Windows.Forms.TextBox();
            this.shuming = new System.Windows.Forms.Label();
            this.leibie = new System.Windows.Forms.TextBox();
            this.shuhao = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dianhua = new System.Windows.Forms.TextBox();
            this.得到 = new System.Windows.Forms.Label();
            this.dizhi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.xiugai = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentmessageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            label1.Location = new System.Drawing.Point(12, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(376, 182);
            label1.TabIndex = 73;
            // 
            // label11
            // 
            label11.BackColor = System.Drawing.Color.Transparent;
            label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            label11.Location = new System.Drawing.Point(12, 236);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(376, 65);
            label11.TabIndex = 104;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.bookManageDataSet;
            this.bindingSource1.Position = 0;
            // 
            // bookManageDataSet
            // 
            this.bookManageDataSet.DataSetName = "bookManageDataSet";
            this.bookManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学生类别号DataGridViewTextBoxColumn,
            this.学号DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.专业DataGridViewTextBoxColumn,
            this.年级DataGridViewTextBoxColumn,
            this.联系电话DataGridViewTextBoxColumn,
            this.校内地址DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentmessageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(424, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(738, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // 学生类别号DataGridViewTextBoxColumn
            // 
            this.学生类别号DataGridViewTextBoxColumn.DataPropertyName = "学生类别号";
            this.学生类别号DataGridViewTextBoxColumn.HeaderText = "学生类别号";
            this.学生类别号DataGridViewTextBoxColumn.Name = "学生类别号DataGridViewTextBoxColumn";
            // 
            // 学号DataGridViewTextBoxColumn
            // 
            this.学号DataGridViewTextBoxColumn.DataPropertyName = "学号";
            this.学号DataGridViewTextBoxColumn.HeaderText = "学号";
            this.学号DataGridViewTextBoxColumn.Name = "学号DataGridViewTextBoxColumn";
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // 专业DataGridViewTextBoxColumn
            // 
            this.专业DataGridViewTextBoxColumn.DataPropertyName = "专业";
            this.专业DataGridViewTextBoxColumn.HeaderText = "专业";
            this.专业DataGridViewTextBoxColumn.Name = "专业DataGridViewTextBoxColumn";
            // 
            // 年级DataGridViewTextBoxColumn
            // 
            this.年级DataGridViewTextBoxColumn.DataPropertyName = "年级";
            this.年级DataGridViewTextBoxColumn.HeaderText = "年级";
            this.年级DataGridViewTextBoxColumn.Name = "年级DataGridViewTextBoxColumn";
            // 
            // 联系电话DataGridViewTextBoxColumn
            // 
            this.联系电话DataGridViewTextBoxColumn.DataPropertyName = "联系电话";
            this.联系电话DataGridViewTextBoxColumn.HeaderText = "联系电话";
            this.联系电话DataGridViewTextBoxColumn.Name = "联系电话DataGridViewTextBoxColumn";
            // 
            // 校内地址DataGridViewTextBoxColumn
            // 
            this.校内地址DataGridViewTextBoxColumn.DataPropertyName = "校内地址";
            this.校内地址DataGridViewTextBoxColumn.HeaderText = "校内地址";
            this.校内地址DataGridViewTextBoxColumn.Name = "校内地址DataGridViewTextBoxColumn";
            // 
            // studentmessageBindingSource
            // 
            this.studentmessageBindingSource.DataMember = "student_message";
            this.studentmessageBindingSource.DataSource = this.bookManageDataSet1;
            // 
            // bookManageDataSet1
            // 
            this.bookManageDataSet1.DataSetName = "bookManageDataSet1";
            this.bookManageDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookManageDataSetBindingSource
            // 
            this.bookManageDataSetBindingSource.DataSource = this.bookManageDataSet;
            this.bookManageDataSetBindingSource.Position = 0;
            // 
            // student_messageTableAdapter
            // 
            this.student_messageTableAdapter.ClearBeforeFill = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(125, 191);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 72;
            this.search.Text = "搜索";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // nianji
            // 
            this.nianji.Location = new System.Drawing.Point(91, 125);
            this.nianji.Name = "nianji";
            this.nianji.Size = new System.Drawing.Size(100, 21);
            this.nianji.TabIndex = 71;
            // 
            // weizhi
            // 
            this.weizhi.AutoSize = true;
            this.weizhi.Location = new System.Drawing.Point(20, 131);
            this.weizhi.Name = "weizhi";
            this.weizhi.Size = new System.Drawing.Size(65, 12);
            this.weizhi.TabIndex = 70;
            this.weizhi.Text = "   年级   ";
            // 
            // zhuanye
            // 
            this.zhuanye.Location = new System.Drawing.Point(272, 89);
            this.zhuanye.Name = "zhuanye";
            this.zhuanye.Size = new System.Drawing.Size(100, 21);
            this.zhuanye.TabIndex = 69;
            // 
            // chubanshe
            // 
            this.chubanshe.AutoSize = true;
            this.chubanshe.Location = new System.Drawing.Point(198, 92);
            this.chubanshe.Name = "chubanshe";
            this.chubanshe.Size = new System.Drawing.Size(65, 12);
            this.chubanshe.TabIndex = 68;
            this.chubanshe.Text = "   专业   ";
            // 
            // xingming
            // 
            this.xingming.Location = new System.Drawing.Point(91, 89);
            this.xingming.Name = "xingming";
            this.xingming.Size = new System.Drawing.Size(100, 21);
            this.xingming.TabIndex = 67;
            // 
            // zuozhe
            // 
            this.zuozhe.AutoSize = true;
            this.zuozhe.Location = new System.Drawing.Point(20, 92);
            this.zuozhe.Name = "zuozhe";
            this.zuozhe.Size = new System.Drawing.Size(65, 12);
            this.zuozhe.TabIndex = 66;
            this.zuozhe.Text = "   姓名   ";
            // 
            // xuehao
            // 
            this.xuehao.Location = new System.Drawing.Point(272, 54);
            this.xuehao.Name = "xuehao";
            this.xuehao.Size = new System.Drawing.Size(100, 21);
            this.xuehao.TabIndex = 65;
            // 
            // shuming
            // 
            this.shuming.AutoSize = true;
            this.shuming.Location = new System.Drawing.Point(198, 57);
            this.shuming.Name = "shuming";
            this.shuming.Size = new System.Drawing.Size(65, 12);
            this.shuming.TabIndex = 64;
            this.shuming.Text = "   学号   ";
            // 
            // leibie
            // 
            this.leibie.Location = new System.Drawing.Point(91, 54);
            this.leibie.Name = "leibie";
            this.leibie.Size = new System.Drawing.Size(100, 21);
            this.leibie.TabIndex = 63;
            // 
            // shuhao
            // 
            this.shuhao.AutoSize = true;
            this.shuhao.Location = new System.Drawing.Point(20, 57);
            this.shuhao.Name = "shuhao";
            this.shuhao.Size = new System.Drawing.Size(65, 12);
            this.shuhao.TabIndex = 62;
            this.shuhao.Text = "学生类别号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 88;
            this.label8.Text = " 联系电话 ";
            // 
            // dianhua
            // 
            this.dianhua.Location = new System.Drawing.Point(272, 125);
            this.dianhua.Name = "dianhua";
            this.dianhua.Size = new System.Drawing.Size(100, 21);
            this.dianhua.TabIndex = 89;
            // 
            // 得到
            // 
            this.得到.AutoSize = true;
            this.得到.Location = new System.Drawing.Point(20, 167);
            this.得到.Name = "得到";
            this.得到.Size = new System.Drawing.Size(65, 12);
            this.得到.TabIndex = 90;
            this.得到.Text = " 校内地址 ";
            // 
            // dizhi
            // 
            this.dizhi.Location = new System.Drawing.Point(91, 164);
            this.dizhi.Name = "dizhi";
            this.dizhi.Size = new System.Drawing.Size(100, 21);
            this.dizhi.TabIndex = 91;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 103;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(91, 249);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 21);
            this.delete.TabIndex = 94;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 93;
            this.label10.Text = "学号";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(212, 191);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 105;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // xiugai
            // 
            this.xiugai.Location = new System.Drawing.Point(297, 191);
            this.xiugai.Name = "xiugai";
            this.xiugai.Size = new System.Drawing.Size(75, 23);
            this.xiugai.TabIndex = 106;
            this.xiugai.Text = "修改";
            this.xiugai.UseVisualStyleBackColor = true;
            this.xiugai.Click += new System.EventHandler(this.xiugai_Click);
            // 
            // userSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1197, 506);
            this.Controls.Add(this.xiugai);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label10);
            this.Controls.Add(label11);
            this.Controls.Add(this.dizhi);
            this.Controls.Add(this.得到);
            this.Controls.Add(this.dianhua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.search);
            this.Controls.Add(this.nianji);
            this.Controls.Add(this.weizhi);
            this.Controls.Add(this.zhuanye);
            this.Controls.Add(this.chubanshe);
            this.Controls.Add(this.xingming);
            this.Controls.Add(this.zuozhe);
            this.Controls.Add(this.xuehao);
            this.Controls.Add(this.shuming);
            this.Controls.Add(this.leibie);
            this.Controls.Add(this.shuhao);
            this.Controls.Add(label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "userSearch";
            this.Text = "userSearch";
            this.Load += new System.EventHandler(this.userSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentmessageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private bookManageDataSet bookManageDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bookManageDataSetBindingSource;
        private bookManageDataSet1 bookManageDataSet1;
        private System.Windows.Forms.BindingSource studentmessageBindingSource;
        private bookManageDataSet1TableAdapters.student_messageTableAdapter student_messageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生类别号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 专业DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年级DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系电话DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 校内地址DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox nianji;
        private System.Windows.Forms.Label weizhi;
        private System.Windows.Forms.TextBox zhuanye;
        private System.Windows.Forms.Label chubanshe;
        private System.Windows.Forms.TextBox xingming;
        private System.Windows.Forms.Label zuozhe;
        private System.Windows.Forms.TextBox xuehao;
        private System.Windows.Forms.Label shuming;
        private System.Windows.Forms.TextBox leibie;
        private System.Windows.Forms.Label shuhao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dianhua;
        private System.Windows.Forms.Label 得到;
        private System.Windows.Forms.TextBox dizhi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox delete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button xiugai;
    }
}