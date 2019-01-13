namespace booksManage
{
    partial class managerBorrowSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managerBorrowSet));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookManageDataSet2 = new booksManage.bookManageDataSet2();
            this.bookManageDataSet4 = new booksManage.bookManageDataSet4();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.borrowmessageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrow_messageTableAdapter = new booksManage.bookManageDataSet4TableAdapters.borrow_messageTableAdapter();
            this.学生类别号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学生类别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.借阅上限DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.借阅天数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.leib = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.leibie = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.shangxian = new System.Windows.Forms.TextBox();
            this.tianshu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowmessageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.bookManageDataSet4;
            this.bindingSource1.Position = 0;
            // 
            // bookManageDataSet2
            // 
            this.bookManageDataSet2.DataSetName = "bookManageDataSet2";
            this.bookManageDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookManageDataSet4
            // 
            this.bookManageDataSet4.DataSetName = "bookManageDataSet4";
            this.bookManageDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学生类别号DataGridViewTextBoxColumn,
            this.学生类别DataGridViewTextBoxColumn,
            this.借阅上限DataGridViewTextBoxColumn,
            this.借阅天数DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borrowmessageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(315, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(444, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // borrowmessageBindingSource
            // 
            this.borrowmessageBindingSource.DataMember = "borrow_message";
            this.borrowmessageBindingSource.DataSource = this.bindingSource1;
            // 
            // borrow_messageTableAdapter
            // 
            this.borrow_messageTableAdapter.ClearBeforeFill = true;
            // 
            // 学生类别号DataGridViewTextBoxColumn
            // 
            this.学生类别号DataGridViewTextBoxColumn.DataPropertyName = "学生类别号";
            this.学生类别号DataGridViewTextBoxColumn.HeaderText = "学生类别号";
            this.学生类别号DataGridViewTextBoxColumn.Name = "学生类别号DataGridViewTextBoxColumn";
            this.学生类别号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 学生类别DataGridViewTextBoxColumn
            // 
            this.学生类别DataGridViewTextBoxColumn.DataPropertyName = "学生类别";
            this.学生类别DataGridViewTextBoxColumn.HeaderText = "学生类别";
            this.学生类别DataGridViewTextBoxColumn.Name = "学生类别DataGridViewTextBoxColumn";
            this.学生类别DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 借阅上限DataGridViewTextBoxColumn
            // 
            this.借阅上限DataGridViewTextBoxColumn.DataPropertyName = "借阅上限";
            this.借阅上限DataGridViewTextBoxColumn.HeaderText = "借阅上限";
            this.借阅上限DataGridViewTextBoxColumn.Name = "借阅上限DataGridViewTextBoxColumn";
            this.借阅上限DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 借阅天数DataGridViewTextBoxColumn
            // 
            this.借阅天数DataGridViewTextBoxColumn.DataPropertyName = "借阅天数";
            this.借阅天数DataGridViewTextBoxColumn.HeaderText = "借阅天数";
            this.借阅天数DataGridViewTextBoxColumn.Name = "借阅天数DataGridViewTextBoxColumn";
            this.借阅天数DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(147, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "修改";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(53, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // leib
            // 
            this.leib.Location = new System.Drawing.Point(122, 128);
            this.leib.Name = "leib";
            this.leib.Size = new System.Drawing.Size(100, 21);
            this.leib.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(63, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "学生类别";
            // 
            // leibie
            // 
            this.leibie.Location = new System.Drawing.Point(122, 91);
            this.leibie.Name = "leibie";
            this.leibie.Size = new System.Drawing.Size(100, 21);
            this.leibie.TabIndex = 11;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Image = ((System.Drawing.Image)(resources.GetObject("name.Image")));
            this.name.Location = new System.Drawing.Point(51, 94);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(65, 12);
            this.name.TabIndex = 10;
            this.name.Text = "学生类别号";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 268);
            this.label2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(63, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "借阅上限";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(63, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "借阅天数";
            // 
            // shangxian
            // 
            this.shangxian.Location = new System.Drawing.Point(122, 166);
            this.shangxian.Name = "shangxian";
            this.shangxian.Size = new System.Drawing.Size(100, 21);
            this.shangxian.TabIndex = 21;
            // 
            // tianshu
            // 
            this.tianshu.Location = new System.Drawing.Point(122, 198);
            this.tianshu.Name = "tianshu";
            this.tianshu.Size = new System.Drawing.Size(100, 21);
            this.tianshu.TabIndex = 22;
            // 
            // managerBorrowSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tianshu);
            this.Controls.Add(this.shangxian);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.leib);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leibie);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "managerBorrowSet";
            this.Text = "managerBorrowSet";
            this.Load += new System.EventHandler(this.managerBorrowSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowmessageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private bookManageDataSet2 bookManageDataSet2;
        private bookManageDataSet4 bookManageDataSet4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource borrowmessageBindingSource;
        private bookManageDataSet4TableAdapters.borrow_messageTableAdapter borrow_messageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生类别号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生类别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借阅上限DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借阅天数DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox leib;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox leibie;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox shangxian;
        private System.Windows.Forms.TextBox tianshu;
    }
}