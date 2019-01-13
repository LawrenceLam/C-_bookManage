namespace booksManage.student
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
            this.shuming = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.shijian = new System.Windows.Forms.TextBox();
            this.shuhao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookManageDataSet4 = new booksManage.bookManageDataSet4();
            this.bookManageDataSet3 = new booksManage.bookManageDataSet3();
            this.borrowrecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.借阅学号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.借阅人姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.借阅书籍书号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.借阅书籍书名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.借阅时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookManageDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookManageDataSet5 = new booksManage.bookManageDataSet5();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.borrow_recordTableAdapter = new booksManage.bookManageDataSet5TableAdapters.borrow_recordTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowrecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // shuming
            // 
            this.shuming.Location = new System.Drawing.Point(135, 193);
            this.shuming.Name = "shuming";
            this.shuming.Size = new System.Drawing.Size(100, 21);
            this.shuming.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(52, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 50;
            this.label5.Text = "借阅书籍书名";
            // 
            // shijian
            // 
            this.shijian.Location = new System.Drawing.Point(135, 248);
            this.shijian.Name = "shijian";
            this.shijian.Size = new System.Drawing.Size(100, 21);
            this.shijian.TabIndex = 49;
            // 
            // shuhao
            // 
            this.shuhao.Location = new System.Drawing.Point(135, 143);
            this.shuhao.Name = "shuhao";
            this.shuhao.Size = new System.Drawing.Size(100, 21);
            this.shuhao.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(76, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 47;
            this.label4.Text = "借阅时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(64, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 46;
            this.label3.Text = "借阅书籍号";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Location = new System.Drawing.Point(160, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 44;
            this.button4.Text = "搜索";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 233);
            this.label2.TabIndex = 45;
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
            this.dataGridView1.Location = new System.Drawing.Point(273, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(544, 233);
            this.dataGridView1.TabIndex = 37;
            // 
            // bookManageDataSet4
            // 
            this.bookManageDataSet4.DataSetName = "bookManageDataSet4";
            this.bookManageDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookManageDataSet3
            // 
            this.bookManageDataSet3.DataSetName = "bookManageDataSet3";
            this.bookManageDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borrowrecordBindingSource
            // 
            this.borrowrecordBindingSource.DataMember = "borrow_record";
            this.borrowrecordBindingSource.DataSource = this.bookManageDataSet5BindingSource;
            // 
            // 借阅学号DataGridViewTextBoxColumn
            // 
            this.借阅学号DataGridViewTextBoxColumn.DataPropertyName = "借阅学号";
            this.借阅学号DataGridViewTextBoxColumn.HeaderText = "借阅学号";
            this.借阅学号DataGridViewTextBoxColumn.Name = "借阅学号DataGridViewTextBoxColumn";
            this.借阅学号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 借阅人姓名DataGridViewTextBoxColumn
            // 
            this.借阅人姓名DataGridViewTextBoxColumn.DataPropertyName = "借阅人姓名";
            this.借阅人姓名DataGridViewTextBoxColumn.HeaderText = "借阅人姓名";
            this.借阅人姓名DataGridViewTextBoxColumn.Name = "借阅人姓名DataGridViewTextBoxColumn";
            this.借阅人姓名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 借阅书籍书号DataGridViewTextBoxColumn
            // 
            this.借阅书籍书号DataGridViewTextBoxColumn.DataPropertyName = "借阅书籍书号";
            this.借阅书籍书号DataGridViewTextBoxColumn.HeaderText = "借阅书籍书号";
            this.借阅书籍书号DataGridViewTextBoxColumn.Name = "借阅书籍书号DataGridViewTextBoxColumn";
            this.借阅书籍书号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 借阅书籍书名DataGridViewTextBoxColumn
            // 
            this.借阅书籍书名DataGridViewTextBoxColumn.DataPropertyName = "借阅书籍书名";
            this.借阅书籍书名DataGridViewTextBoxColumn.HeaderText = "借阅书籍书名";
            this.借阅书籍书名DataGridViewTextBoxColumn.Name = "借阅书籍书名DataGridViewTextBoxColumn";
            this.借阅书籍书名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 借阅时间DataGridViewTextBoxColumn
            // 
            this.借阅时间DataGridViewTextBoxColumn.DataPropertyName = "借阅时间";
            this.借阅时间DataGridViewTextBoxColumn.HeaderText = "借阅时间";
            this.借阅时间DataGridViewTextBoxColumn.Name = "借阅时间DataGridViewTextBoxColumn";
            this.借阅时间DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookManageDataSet5BindingSource
            // 
            this.bookManageDataSet5BindingSource.DataSource = this.bookManageDataSet5;
            this.bookManageDataSet5BindingSource.Position = 0;
            // 
            // bookManageDataSet5
            // 
            this.bookManageDataSet5.DataSetName = "bookManageDataSet5";
            this.bookManageDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.bookManageDataSet5;
            this.bindingSource1.Position = 0;
            // 
            // borrow_recordTableAdapter
            // 
            this.borrow_recordTableAdapter.ClearBeforeFill = true;
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Record";
            this.Text = "record";
            this.Load += new System.EventHandler(this.Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowrecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox shuming;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox shijian;
        private System.Windows.Forms.TextBox shuhao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private bookManageDataSet4 bookManageDataSet4;
        private System.Windows.Forms.BindingSource bookManageDataSet5BindingSource;
        private bookManageDataSet5 bookManageDataSet5;
        private bookManageDataSet3 bookManageDataSet3;
        private System.Windows.Forms.BindingSource borrowrecordBindingSource;
        private bookManageDataSet5TableAdapters.borrow_recordTableAdapter borrow_recordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借阅学号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借阅人姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借阅书籍书号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借阅书籍书名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借阅时间DataGridViewTextBoxColumn;
    }
}