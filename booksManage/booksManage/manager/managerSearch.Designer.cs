namespace booksManage
{
    partial class managerSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managerSearch));
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.书号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.书名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版社DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.在库数量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.位置DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookManageDataSet = new booksManage.bookManageDataSet();
            this.search = new System.Windows.Forms.Button();
            this.searchweizhi = new System.Windows.Forms.TextBox();
            this.weizhi = new System.Windows.Forms.Label();
            this.searchchubanshe = new System.Windows.Forms.TextBox();
            this.chubanshe = new System.Windows.Forms.Label();
            this.searchzuozhe = new System.Windows.Forms.TextBox();
            this.zuozhe = new System.Windows.Forms.Label();
            this.searchshuming = new System.Windows.Forms.TextBox();
            this.shuming = new System.Windows.Forms.Label();
            this.searchshuhao = new System.Windows.Forms.TextBox();
            this.shuhao = new System.Windows.Forms.Label();
            this.booksTableAdapter = new booksManage.bookManageDataSetTableAdapters.booksTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.editweizhi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editchubanshe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editzuozhe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editshuming = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editshuhao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.alterweizhi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.alterchubanshe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.alterzuozhe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.altershuming = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.altershuhao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.deleteshuhao = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.alternum = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.editnum = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            label1.Location = new System.Drawing.Point(35, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(301, 177);
            label1.TabIndex = 27;
            // 
            // label7
            // 
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            label7.Location = new System.Drawing.Point(35, 253);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(320, 177);
            label7.TabIndex = 40;
            // 
            // label13
            // 
            label13.BackColor = System.Drawing.Color.Transparent;
            label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            label13.Location = new System.Drawing.Point(35, 449);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(320, 177);
            label13.TabIndex = 53;
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
            this.dataGridView1.Location = new System.Drawing.Point(361, 53);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(645, 489);
            this.dataGridView1.TabIndex = 26;
            // 
            // 书号DataGridViewTextBoxColumn
            // 
            this.书号DataGridViewTextBoxColumn.DataPropertyName = "书号";
            this.书号DataGridViewTextBoxColumn.HeaderText = "书号";
            this.书号DataGridViewTextBoxColumn.Name = "书号DataGridViewTextBoxColumn";
            this.书号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 书名DataGridViewTextBoxColumn
            // 
            this.书名DataGridViewTextBoxColumn.DataPropertyName = "书名";
            this.书名DataGridViewTextBoxColumn.HeaderText = "书名";
            this.书名DataGridViewTextBoxColumn.Name = "书名DataGridViewTextBoxColumn";
            this.书名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 作者DataGridViewTextBoxColumn
            // 
            this.作者DataGridViewTextBoxColumn.DataPropertyName = "作者";
            this.作者DataGridViewTextBoxColumn.HeaderText = "作者";
            this.作者DataGridViewTextBoxColumn.Name = "作者DataGridViewTextBoxColumn";
            this.作者DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 出版社DataGridViewTextBoxColumn
            // 
            this.出版社DataGridViewTextBoxColumn.DataPropertyName = "出版社";
            this.出版社DataGridViewTextBoxColumn.HeaderText = "出版社";
            this.出版社DataGridViewTextBoxColumn.Name = "出版社DataGridViewTextBoxColumn";
            this.出版社DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 在库数量DataGridViewTextBoxColumn
            // 
            this.在库数量DataGridViewTextBoxColumn.DataPropertyName = "在库数量";
            this.在库数量DataGridViewTextBoxColumn.HeaderText = "在库数量";
            this.在库数量DataGridViewTextBoxColumn.Name = "在库数量DataGridViewTextBoxColumn";
            this.在库数量DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 位置DataGridViewTextBoxColumn
            // 
            this.位置DataGridViewTextBoxColumn.DataPropertyName = "位置";
            this.位置DataGridViewTextBoxColumn.HeaderText = "位置";
            this.位置DataGridViewTextBoxColumn.Name = "位置DataGridViewTextBoxColumn";
            this.位置DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.bindingSource1;
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
            // search
            // 
            this.search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search.BackgroundImage")));
            this.search.Location = new System.Drawing.Point(239, 194);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 24;
            this.search.Text = "搜索";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchweizhi
            // 
            this.searchweizhi.Location = new System.Drawing.Point(78, 154);
            this.searchweizhi.Name = "searchweizhi";
            this.searchweizhi.Size = new System.Drawing.Size(100, 21);
            this.searchweizhi.TabIndex = 23;
            // 
            // weizhi
            // 
            this.weizhi.AutoSize = true;
            this.weizhi.Image = ((System.Drawing.Image)(resources.GetObject("weizhi.Image")));
            this.weizhi.Location = new System.Drawing.Point(43, 157);
            this.weizhi.Name = "weizhi";
            this.weizhi.Size = new System.Drawing.Size(29, 12);
            this.weizhi.TabIndex = 22;
            this.weizhi.Text = "位置";
            // 
            // searchchubanshe
            // 
            this.searchchubanshe.Location = new System.Drawing.Point(223, 110);
            this.searchchubanshe.Name = "searchchubanshe";
            this.searchchubanshe.Size = new System.Drawing.Size(100, 21);
            this.searchchubanshe.TabIndex = 21;
            // 
            // chubanshe
            // 
            this.chubanshe.AutoSize = true;
            this.chubanshe.Image = ((System.Drawing.Image)(resources.GetObject("chubanshe.Image")));
            this.chubanshe.Location = new System.Drawing.Point(184, 110);
            this.chubanshe.Name = "chubanshe";
            this.chubanshe.Size = new System.Drawing.Size(41, 12);
            this.chubanshe.TabIndex = 20;
            this.chubanshe.Text = "出版社";
            // 
            // searchzuozhe
            // 
            this.searchzuozhe.Location = new System.Drawing.Point(78, 110);
            this.searchzuozhe.Name = "searchzuozhe";
            this.searchzuozhe.Size = new System.Drawing.Size(100, 21);
            this.searchzuozhe.TabIndex = 19;
            // 
            // zuozhe
            // 
            this.zuozhe.AutoSize = true;
            this.zuozhe.Image = ((System.Drawing.Image)(resources.GetObject("zuozhe.Image")));
            this.zuozhe.Location = new System.Drawing.Point(43, 113);
            this.zuozhe.Name = "zuozhe";
            this.zuozhe.Size = new System.Drawing.Size(29, 12);
            this.zuozhe.TabIndex = 18;
            this.zuozhe.Text = "作者";
            // 
            // searchshuming
            // 
            this.searchshuming.Location = new System.Drawing.Point(223, 66);
            this.searchshuming.Name = "searchshuming";
            this.searchshuming.Size = new System.Drawing.Size(100, 21);
            this.searchshuming.TabIndex = 17;
            // 
            // shuming
            // 
            this.shuming.AutoSize = true;
            this.shuming.Image = ((System.Drawing.Image)(resources.GetObject("shuming.Image")));
            this.shuming.Location = new System.Drawing.Point(188, 69);
            this.shuming.Name = "shuming";
            this.shuming.Size = new System.Drawing.Size(29, 12);
            this.shuming.TabIndex = 16;
            this.shuming.Text = "书名";
            // 
            // searchshuhao
            // 
            this.searchshuhao.Location = new System.Drawing.Point(78, 66);
            this.searchshuhao.Name = "searchshuhao";
            this.searchshuhao.Size = new System.Drawing.Size(100, 21);
            this.searchshuhao.TabIndex = 15;
            // 
            // shuhao
            // 
            this.shuhao.AutoSize = true;
            this.shuhao.Image = ((System.Drawing.Image)(resources.GetObject("shuhao.Image")));
            this.shuhao.Location = new System.Drawing.Point(43, 69);
            this.shuhao.Name = "shuhao";
            this.shuhao.Size = new System.Drawing.Size(29, 12);
            this.shuhao.TabIndex = 14;
            this.shuhao.Text = "书号";
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(239, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // editweizhi
            // 
            this.editweizhi.Location = new System.Drawing.Point(78, 354);
            this.editweizhi.Name = "editweizhi";
            this.editweizhi.Size = new System.Drawing.Size(100, 21);
            this.editweizhi.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(43, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 36;
            this.label2.Text = "位置";
            // 
            // editchubanshe
            // 
            this.editchubanshe.Location = new System.Drawing.Point(239, 310);
            this.editchubanshe.Name = "editchubanshe";
            this.editchubanshe.Size = new System.Drawing.Size(100, 21);
            this.editchubanshe.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(193, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "出版社";
            // 
            // editzuozhe
            // 
            this.editzuozhe.Location = new System.Drawing.Point(78, 310);
            this.editzuozhe.Name = "editzuozhe";
            this.editzuozhe.Size = new System.Drawing.Size(100, 21);
            this.editzuozhe.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(43, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 32;
            this.label4.Text = "作者";
            // 
            // editshuming
            // 
            this.editshuming.Location = new System.Drawing.Point(239, 267);
            this.editshuming.Name = "editshuming";
            this.editshuming.Size = new System.Drawing.Size(100, 21);
            this.editshuming.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(201, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "书名";
            // 
            // editshuhao
            // 
            this.editshuhao.Location = new System.Drawing.Point(78, 266);
            this.editshuhao.Name = "editshuhao";
            this.editshuhao.Size = new System.Drawing.Size(100, 21);
            this.editshuhao.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(43, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "书号";
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(239, 591);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 51;
            this.button4.Text = "修改";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // alterweizhi
            // 
            this.alterweizhi.Location = new System.Drawing.Point(78, 550);
            this.alterweizhi.Name = "alterweizhi";
            this.alterweizhi.Size = new System.Drawing.Size(100, 21);
            this.alterweizhi.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(43, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 49;
            this.label8.Text = "位置";
            // 
            // alterchubanshe
            // 
            this.alterchubanshe.Location = new System.Drawing.Point(239, 506);
            this.alterchubanshe.Name = "alterchubanshe";
            this.alterchubanshe.Size = new System.Drawing.Size(100, 21);
            this.alterchubanshe.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(194, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 47;
            this.label9.Text = "出版社";
            // 
            // alterzuozhe
            // 
            this.alterzuozhe.Location = new System.Drawing.Point(78, 506);
            this.alterzuozhe.Name = "alterzuozhe";
            this.alterzuozhe.Size = new System.Drawing.Size(100, 21);
            this.alterzuozhe.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(43, 509);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 45;
            this.label10.Text = "作者";
            // 
            // altershuming
            // 
            this.altershuming.Location = new System.Drawing.Point(239, 462);
            this.altershuming.Name = "altershuming";
            this.altershuming.Size = new System.Drawing.Size(100, 21);
            this.altershuming.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(204, 467);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 43;
            this.label11.Text = "书名";
            // 
            // altershuhao
            // 
            this.altershuhao.Location = new System.Drawing.Point(78, 462);
            this.altershuhao.Name = "altershuhao";
            this.altershuhao.Size = new System.Drawing.Size(100, 21);
            this.altershuhao.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(43, 465);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 41;
            this.label12.Text = "书号";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.Location = new System.Drawing.Point(408, 578);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 54;
            this.label14.Text = "要删除的书号";
            // 
            // deleteshuhao
            // 
            this.deleteshuhao.Location = new System.Drawing.Point(488, 573);
            this.deleteshuhao.Name = "deleteshuhao";
            this.deleteshuhao.Size = new System.Drawing.Size(100, 21);
            this.deleteshuhao.TabIndex = 55;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(601, 573);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 56;
            this.button5.Text = "删除";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.Location = new System.Drawing.Point(399, 565);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(289, 49);
            this.label15.TabIndex = 57;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Image = ((System.Drawing.Image)(resources.GetObject("label16.Image")));
            this.label16.Location = new System.Drawing.Point(184, 553);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 58;
            this.label16.Text = "在库数量";
            // 
            // alternum
            // 
            this.alternum.Location = new System.Drawing.Point(239, 550);
            this.alternum.Name = "alternum";
            this.alternum.Size = new System.Drawing.Size(100, 21);
            this.alternum.TabIndex = 59;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Image = ((System.Drawing.Image)(resources.GetObject("label17.Image")));
            this.label17.Location = new System.Drawing.Point(184, 357);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 60;
            this.label17.Text = "在库数量";
            // 
            // editnum
            // 
            this.editnum.Location = new System.Drawing.Point(239, 354);
            this.editnum.Name = "editnum";
            this.editnum.Size = new System.Drawing.Size(100, 21);
            this.editnum.TabIndex = 61;
            // 
            // managerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1027, 641);
            this.Controls.Add(this.editnum);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.alternum);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.deleteshuhao);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.alterweizhi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.alterchubanshe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.alterzuozhe);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.altershuming);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.altershuhao);
            this.Controls.Add(this.label12);
            this.Controls.Add(label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.editweizhi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editchubanshe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editzuozhe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.editshuming);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.editshuhao);
            this.Controls.Add(this.label6);
            this.Controls.Add(label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchweizhi);
            this.Controls.Add(this.weizhi);
            this.Controls.Add(this.searchchubanshe);
            this.Controls.Add(this.chubanshe);
            this.Controls.Add(this.searchzuozhe);
            this.Controls.Add(this.zuozhe);
            this.Controls.Add(this.searchshuming);
            this.Controls.Add(this.shuming);
            this.Controls.Add(this.searchshuhao);
            this.Controls.Add(this.shuhao);
            this.Controls.Add(label1);
            this.Controls.Add(this.label15);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "managerSearch";
            this.Text = "managerSearch";
            this.Load += new System.EventHandler(this.managerSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox searchweizhi;
        private System.Windows.Forms.Label weizhi;
        private System.Windows.Forms.TextBox searchchubanshe;
        private System.Windows.Forms.Label chubanshe;
        private System.Windows.Forms.TextBox searchzuozhe;
        private System.Windows.Forms.Label zuozhe;
        private System.Windows.Forms.TextBox searchshuming;
        private System.Windows.Forms.Label shuming;
        private System.Windows.Forms.TextBox searchshuhao;
        private System.Windows.Forms.Label shuhao;
        private System.Windows.Forms.BindingSource bindingSource1;
        private bookManageDataSet bookManageDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private bookManageDataSetTableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 书号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 书名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作者DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出版社DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 在库数量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 位置DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox editweizhi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editchubanshe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox editzuozhe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox editshuming;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox editshuhao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox alterweizhi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox alterchubanshe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox alterzuozhe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox altershuming;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox altershuhao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox deleteshuhao;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox alternum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox editnum;
    }
}