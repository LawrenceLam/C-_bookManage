namespace booksManage.manager
{
    partial class Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Record));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookManageDataSet3 = new booksManage.bookManageDataSet3();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.借阅学号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.借阅人姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.借阅书籍书号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.借阅书籍书名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.借阅时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowrecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrow_recordTableAdapter = new booksManage.bookManageDataSet3TableAdapters.borrow_recordTableAdapter();
            this.shijian = new System.Windows.Forms.TextBox();
            this.shuhao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.xingming = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xuehao = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shuming = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowrecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.bookManageDataSet3;
            this.bindingSource1.Position = 0;
            // 
            // bookManageDataSet3
            // 
            this.bookManageDataSet3.DataSetName = "bookManageDataSet3";
            this.bookManageDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.借阅学号DataGridViewTextBoxColumn,
            this.借阅人姓名DataGridViewTextBoxColumn,
            this.借阅书籍书号DataGridViewTextBoxColumn,
            this.借阅书籍书名DataGridViewTextBoxColumn,
            this.借阅时间DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borrowrecordBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(273, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(544, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // 借阅学号DataGridViewTextBoxColumn
            // 
            this.借阅学号DataGridViewTextBoxColumn.DataPropertyName = "借阅学号";
            this.借阅学号DataGridViewTextBoxColumn.HeaderText = "借阅学号";
            this.借阅学号DataGridViewTextBoxColumn.Name = "借阅学号DataGridViewTextBoxColumn";
            // 
            // 借阅人姓名DataGridViewTextBoxColumn
            // 
            this.借阅人姓名DataGridViewTextBoxColumn.DataPropertyName = "借阅人姓名";
            this.借阅人姓名DataGridViewTextBoxColumn.HeaderText = "借阅人姓名";
            this.借阅人姓名DataGridViewTextBoxColumn.Name = "借阅人姓名DataGridViewTextBoxColumn";
            // 
            // 借阅书籍书号DataGridViewTextBoxColumn
            // 
            this.借阅书籍书号DataGridViewTextBoxColumn.DataPropertyName = "借阅书籍书号";
            this.借阅书籍书号DataGridViewTextBoxColumn.HeaderText = "借阅书籍书号";
            this.借阅书籍书号DataGridViewTextBoxColumn.Name = "借阅书籍书号DataGridViewTextBoxColumn";
            // 
            // 借阅书籍书名DataGridViewTextBoxColumn
            // 
            this.借阅书籍书名DataGridViewTextBoxColumn.DataPropertyName = "借阅书籍书名";
            this.借阅书籍书名DataGridViewTextBoxColumn.HeaderText = "借阅书籍书名";
            this.借阅书籍书名DataGridViewTextBoxColumn.Name = "借阅书籍书名DataGridViewTextBoxColumn";
            // 
            // 借阅时间DataGridViewTextBoxColumn
            // 
            this.借阅时间DataGridViewTextBoxColumn.DataPropertyName = "借阅时间";
            this.借阅时间DataGridViewTextBoxColumn.HeaderText = "借阅时间";
            this.借阅时间DataGridViewTextBoxColumn.Name = "借阅时间DataGridViewTextBoxColumn";
            // 
            // borrowrecordBindingSource
            // 
            this.borrowrecordBindingSource.DataMember = "borrow_record";
            this.borrowrecordBindingSource.DataSource = this.bindingSource1;
            // 
            // borrow_recordTableAdapter
            // 
            this.borrow_recordTableAdapter.ClearBeforeFill = true;
            // 
            // shijian
            // 
            this.shijian.Location = new System.Drawing.Point(110, 229);
            this.shijian.Name = "shijian";
            this.shijian.Size = new System.Drawing.Size(100, 21);
            this.shijian.TabIndex = 34;
            // 
            // shuhao
            // 
            this.shuhao.Location = new System.Drawing.Point(110, 167);
            this.shuhao.Name = "shuhao";
            this.shuhao.Size = new System.Drawing.Size(100, 21);
            this.shuhao.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(51, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 32;
            this.label4.Text = "借阅时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(39, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "借阅书籍号";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Location = new System.Drawing.Point(135, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 29;
            this.button4.Text = "搜索";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Location = new System.Drawing.Point(135, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(41, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xingming
            // 
            this.xingming.Location = new System.Drawing.Point(110, 133);
            this.xingming.Name = "xingming";
            this.xingming.Size = new System.Drawing.Size(100, 21);
            this.xingming.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(39, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "借阅人姓名";
            // 
            // xuehao
            // 
            this.xuehao.Location = new System.Drawing.Point(110, 99);
            this.xuehao.Name = "xuehao";
            this.xuehao.Size = new System.Drawing.Size(100, 21);
            this.xuehao.TabIndex = 24;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Image = ((System.Drawing.Image)(resources.GetObject("name.Image")));
            this.name.Location = new System.Drawing.Point(51, 102);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(53, 12);
            this.name.TabIndex = 23;
            this.name.Text = "借阅学号";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 268);
            this.label2.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(27, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 35;
            this.label5.Text = "借阅书籍书名";
            // 
            // shuming
            // 
            this.shuming.Location = new System.Drawing.Point(110, 199);
            this.shuming.Name = "shuming";
            this.shuming.Size = new System.Drawing.Size(100, 21);
            this.shuming.TabIndex = 36;
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(839, 518);
            this.Controls.Add(this.shuming);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.shijian);
            this.Controls.Add(this.shuhao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xingming);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xuehao);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Record";
            this.Text = "record";
            this.Load += new System.EventHandler(this.record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowrecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private bookManageDataSet3 bookManageDataSet3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource borrowrecordBindingSource;
        private bookManageDataSet3TableAdapters.borrow_recordTableAdapter borrow_recordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借阅学号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借阅人姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借阅书籍书号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借阅书籍书名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借阅时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox shijian;
        private System.Windows.Forms.TextBox shuhao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox xingming;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xuehao;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox shuming;
    }
}