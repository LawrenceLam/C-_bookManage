using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//管理员身份对借阅记录的修改，操作的是所有人的借阅记录
namespace booksManage.manager
{
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void record_Load(object sender, EventArgs e)
        {
            //这行代码将数据加载到表“bookManageDataSet3.borrow_record”中。您可以根据需要移动或删除它。
            this.borrow_recordTableAdapter.Fill(this.bookManageDataSet3.borrow_record);

        }
        //用来将数据表中的数据绑定到GridView中，每次对数据表的数据修改后可以调用此方法刷新数据显示
        private void show()
        {
            this.borrow_recordTableAdapter.Fill(this.bookManageDataSet3.borrow_record);
        }
        //添加借阅记录
        private void button1_Click(object sender, EventArgs e)
        {
            //数据表中所有的字段都要求为非空，借阅学号、借阅书号、借阅时间作为主码可以确定一条记录
            if (xuehao.Text == "" || xingming.Text == "" || shuhao.Text == "" || shuming.Text == "" || shijian.Text == "")
            {
                MessageBox.Show("输入信息不完整","输入信息不完整");
                return;
            }
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "insert into borrow_record values ('" + xuehao.Text + "','" + xingming.Text + "','"+shuhao.Text+"','"+shuming.Text+"','"+shijian.Text +"')";
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("添加成功", "添加成功");
            show();
        }
        //搜索书籍
        private void button4_Click(object sender, EventArgs e)
        {
            //当所有的搜索条件为空的时候，无需进行搜索操作
            if (xuehao.Text.Equals("") && xingming.Text.Equals("") && shuhao.Text.Equals("") && shuming.Equals("") && shijian.Text.Equals("")) return;
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            string strcon = "";//将查询条件转换为查询语句
            if (!xuehao.Text.Equals("")) strcon = "where 借阅学号 like '%" + xuehao.Text + "%'";//在书写查询语句时，需要判断哪些字段作为搜索条件，根据文本框的内容判断
            if (xingming.Text != "")//除去第一个文本框外，其余的文本框除了需要判断内容是否为空，还需要判断strcon是否为空
            {
                if (strcon != "") strcon += " and 借阅人姓名 like '%" + xingming.Text + "%'";
                else strcon = "where 借阅人姓名 like '%" + xingming.Text + "%'";
            }
            if (shuhao.Text != "")
            {
                if (strcon != "") strcon += " and 借阅书籍书号 like '%" + shuhao.Text + "%'";
                else strcon = "where 借阅书籍书号 like '%" + shuhao.Text + "%'";
            }
            if (shuming.Text != "")
            {
                if (strcon != "") strcon += " and 借阅书籍书名 like '%" + shuming.Text + "%'";
                else strcon = "where 借阅书籍书名 like '%" + shuming.Text + "%'";
            }
            if (shijian.Text != "")
            {
                if (strcon != "") strcon += " and 借阅时间 like '%" + shijian.Text + "%'";
                else strcon = "where 借阅时间 like '%" + shijian.Text + "%'";
            }
            comm.CommandText = "select * from borrow_record " + strcon;
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }
        //删除记录
        private void button3_Click(object sender, EventArgs e)
        {
            //主码为借阅学号，借阅书号，借阅时间，这三项必须填写，以达到删除的目的
            if (xuehao.Text.Equals("") ||shuhao.Text.Equals("") || shijian.Text.Equals(""))
            {
                MessageBox.Show("学号，书号和借阅时间为必填项", "输入不完整");
                return;
            }
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "delete from borrow_record where 借阅学号='" + xuehao.Text + "' and 借阅书籍书号='"+shuhao.Text+"' and 借阅时间='"+shijian.Text+"'";
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("删除成功", "删除成功");
            show();
        }
    }
}
