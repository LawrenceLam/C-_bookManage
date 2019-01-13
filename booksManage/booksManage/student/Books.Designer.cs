namespace booksManage
{
    partial class books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(books));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.shuhao = new System.Windows.Forms.Label();
            this.textshuhao = new System.Windows.Forms.TextBox();
            this.shuming = new System.Windows.Forms.Label();
            this.textshuming = new System.Windows.Forms.TextBox();
            this.zuozhe = new System.Windows.Forms.Label();
            this.textzuozhe = new System.Windows.Forms.TextBox();
            this.chubanshe = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.weizhi = new System.Windows.Forms.Label();
            this.textweizhi = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookManageDataSet = new booksManage.bookManageDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.书号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.书名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版社DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.在库数量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.位置DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new booksManage.bookManageDataSetTableAdapters.booksTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // shuhao
            // 
            this.shuhao.AutoSize = true;
            this.shuhao.Image = ((System.Drawing.Image)(resources.GetObject("shuhao.Image")));
            this.shuhao.Location = new System.Drawing.Point(93, 43);
            this.shuhao.Name = "shuhao";
            this.shuhao.Size = new System.Drawing.Size(29, 12);
            this.shuhao.TabIndex = 1;
            this.shuhao.Text = "书号";
            // 
            // textshuhao
            // 
            this.textshuhao.Location = new System.Drawing.Point(128, 40);
            this.textshuhao.Name = "textshuhao";
            this.textshuhao.Size = new System.Drawing.Size(100, 21);
            this.textshuhao.TabIndex = 2;
            // 
            // shuming
            // 
            this.shuming.AutoSize = true;
            this.shuming.Image = ((System.Drawing.Image)(resources.GetObject("shuming.Image")));
            this.shuming.Location = new System.Drawing.Point(93, 87);
            this.shuming.Name = "shuming";
            this.shuming.Size = new System.Drawing.Size(29, 12);
            this.shuming.TabIndex = 3;
            this.shuming.Text = "书名";
            // 
            // textshuming
            // 
            this.textshuming.Location = new System.Drawing.Point(128, 84);
            this.textshuming.Name = "textshuming";
            this.textshuming.Size = new System.Drawing.Size(100, 21);
            this.textshuming.TabIndex = 4;
            // 
            // zuozhe
            // 
            this.zuozhe.AutoSize = true;
            this.zuozhe.Image = ((System.Drawing.Image)(resources.GetObject("zuozhe.Image")));
            this.zuozhe.Location = new System.Drawing.Point(93, 135);
            this.zuozhe.Name = "zuozhe";
            this.zuozhe.Size = new System.Drawing.Size(29, 12);
            this.zuozhe.TabIndex = 5;
            this.zuozhe.Text = "作者";
            // 
            // textzuozhe
            // 
            this.textzuozhe.Location = new System.Drawing.Point(128, 132);
            this.textzuozhe.Name = "textzuozhe";
            this.textzuozhe.Size = new System.Drawing.Size(100, 21);
            this.textzuozhe.TabIndex = 6;
            // 
            // chubanshe
            // 
            this.chubanshe.AutoSize = true;
            this.chubanshe.Image = ((System.Drawing.Image)(resources.GetObject("chubanshe.Image")));
            this.chubanshe.Location = new System.Drawing.Point(81, 181);
            this.chubanshe.Name = "chubanshe";
            this.chubanshe.Size = new System.Drawing.Size(41, 12);
            this.chubanshe.TabIndex = 7;
            this.chubanshe.Text = "出版社";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 8;
            // 
            // weizhi
            // 
            this.weizhi.AutoSize = true;
            this.weizhi.Image = ((System.Drawing.Image)(resources.GetObject("weizhi.Image")));
            this.weizhi.Location = new System.Drawing.Point(93, 220);
            this.weizhi.Name = "weizhi";
            this.weizhi.Size = new System.Drawing.Size(29, 12);
            this.weizhi.TabIndex = 9;
            this.weizhi.Text = "位置";
            // 
            // textweizhi
            // 
            this.textweizhi.Location = new System.Drawing.Point(128, 217);
            this.textweizhi.Name = "textweizhi";
            this.textweizhi.Size = new System.Drawing.Size(100, 21);
            this.textweizhi.TabIndex = 10;
            // 
            // search
            // 
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(83, 267);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 11;
            this.search.Text = "搜索";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click_1);
            // 
            // reset
            // 
            this.reset.Image = ((System.Drawing.Image)(resources.GetObject("reset.Image")));
            this.reset.Location = new System.Drawing.Point(186, 267);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 12;
            this.reset.Text = "重置";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.书号DataGridViewTextBoxColumn,
            this.书名DataGridViewTextBoxColumn,
            this.作者DataGridViewTextBoxColumn,
            this.出版社DataGridViewTextBoxColumn,
            this.在库数量DataGridViewTextBoxColumn,
            this.位置DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(313, 28);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(643, 444);
            this.dataGridView1.TabIndex = 13;
            // 
            // 书号DataGridViewTextBoxColumn
            // 
            this.书号DataGridViewTextBoxColumn.DataPropertyName = "书号";
            this.书号DataGridViewTextBoxColumn.Frozen = true;
            this.书号DataGridViewTextBoxColumn.HeaderText = "书号";
            this.书号DataGridViewTextBoxColumn.Name = "书号DataGridViewTextBoxColumn";
            this.书号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 书名DataGridViewTextBoxColumn
            // 
            this.书名DataGridViewTextBoxColumn.DataPropertyName = "书名";
            this.书名DataGridViewTextBoxColumn.Frozen = true;
            this.书名DataGridViewTextBoxColumn.HeaderText = "书名";
            this.书名DataGridViewTextBoxColumn.Name = "书名DataGridViewTextBoxColumn";
            this.书名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 作者DataGridViewTextBoxColumn
            // 
            this.作者DataGridViewTextBoxColumn.DataPropertyName = "作者";
            this.作者DataGridViewTextBoxColumn.Frozen = true;
            this.作者DataGridViewTextBoxColumn.HeaderText = "作者";
            this.作者DataGridViewTextBoxColumn.Name = "作者DataGridViewTextBoxColumn";
            this.作者DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 出版社DataGridViewTextBoxColumn
            // 
            this.出版社DataGridViewTextBoxColumn.DataPropertyName = "出版社";
            this.出版社DataGridViewTextBoxColumn.Frozen = true;
            this.出版社DataGridViewTextBoxColumn.HeaderText = "出版社";
            this.出版社DataGridViewTextBoxColumn.Name = "出版社DataGridViewTextBoxColumn";
            this.出版社DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 在库数量DataGridViewTextBoxColumn
            // 
            this.在库数量DataGridViewTextBoxColumn.DataPropertyName = "在库数量";
            this.在库数量DataGridViewTextBoxColumn.Frozen = true;
            this.在库数量DataGridViewTextBoxColumn.HeaderText = "在库数量";
            this.在库数量DataGridViewTextBoxColumn.Name = "在库数量DataGridViewTextBoxColumn";
            this.在库数量DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 位置DataGridViewTextBoxColumn
            // 
            this.位置DataGridViewTextBoxColumn.DataPropertyName = "位置";
            this.位置DataGridViewTextBoxColumn.Frozen = true;
            this.位置DataGridViewTextBoxColumn.HeaderText = "位置";
            this.位置DataGridViewTextBoxColumn.Name = "位置DataGridViewTextBoxColumn";
            this.位置DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.bindingSource1;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(72, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 296);
            this.label1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(81, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "搜索条件设置";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(74, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 87);
            this.label3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(109, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "书号";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(169, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "借阅";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 382);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 19;
            // 
            // books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1018, 635);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textweizhi);
            this.Controls.Add(this.weizhi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chubanshe);
            this.Controls.Add(this.textzuozhe);
            this.Controls.Add(this.zuozhe);
            this.Controls.Add(this.textshuming);
            this.Controls.Add(this.shuming);
            this.Controls.Add(this.textshuhao);
            this.Controls.Add(this.shuhao);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "books";
            this.Text = "图书管理系统";
            this.Load += new System.EventHandler(this.books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label shuhao;
        private System.Windows.Forms.TextBox textshuhao;
        private System.Windows.Forms.Label shuming;
        private System.Windows.Forms.TextBox textshuming;
        private System.Windows.Forms.Label zuozhe;
        private System.Windows.Forms.TextBox textzuozhe;
        private System.Windows.Forms.Label chubanshe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label weizhi;
        private System.Windows.Forms.TextBox textweizhi;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.BindingSource bindingSource1;
        private bookManageDataSet bookManageDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private bookManageDataSetTableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 书号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 书名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作者DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出版社DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 在库数量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 位置DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}