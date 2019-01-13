using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

//学生身份查阅书籍库存
namespace booksManage
{
    public partial class books : Form
    {
        //用构造函数记录学号和用户名
        string stuno;
        string user;
        public books(string stuno,string user)
        {
            this.user = user;
            this.stuno = stuno;
            InitializeComponent();
        }
        //搜索功能
        private void search_Click_1(object sender, EventArgs e)
        {
            //在全部搜索条件都为空的情况下，不需要对数据进行搜索操作
            if (textshuhao.Text.Equals("") && textshuming.Text.Equals("") && textzuozhe.Text.Equals("") && textBox1.Equals("") && textweizhi.Text.Equals("")) return;
            //设置连接字符串
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            string strcon = "";//用来将对应的搜索条件转换为搜索语句
            if (!textshuhao.Text.Equals("")) strcon = "where 书号 like '%" + textshuhao.Text + "%'";//通过文本框中是否有内容判断是否将其作为搜索条件
            if (textshuming.Text != "")
            {
                if (strcon != "") strcon += " and 书名 like '%" + textshuming.Text + "%'";//除去第一个文本框外，其余的除了要判断文本框中是否有内容外，还需要判读strcon是否有内容
                else strcon = "where 书名 like '%" + textshuming.Text + "%'";//在strcon中没有内容的时候，说明本文本框中的文本为第一个搜索条件
            }
            if (textzuozhe.Text != "")
            {
                if (strcon != "") strcon += " and 作者 like '%" + textzuozhe.Text + "%'";
                else strcon = "where 作者 like '%" + textzuozhe.Text + "%'";
            }
            if (textBox1.Text != "")
            {
                if(strcon!="")strcon += " and 出版社 like '%" + textBox1.Text + "%'";
                else strcon = "where 出版社 like '%" + textBox1.Text + "%'";
            }
            comm.CommandText = "select * from books "+strcon;
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        //初始化界面时，将所有 的数据加载到GridView中
        private void books_Load(object sender, EventArgs e)
        {
            // 这行代码将数据加载到表“bookManageDataSet.books”中。您可以根据需要移动或删除它。
            this.booksTableAdapter.Fill(this.bookManageDataSet.books);

        }
        //重置搜索条件
        private void reset_Click(object sender, EventArgs e)
        {
            //让GridView中的数据回到初始化的时候
            textshuhao.Text = textshuming.Text = textBox1.Text = textzuozhe.Text = textweizhi.Text = "";
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "select * from books ";
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
        //借阅书籍的功能
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "select 书名 from books where 书号='" + textBox2.Text.Trim() +"'";
            SqlDataReader reader = comm.ExecuteReader();
            string datetime = DateTime.Now.ToLocalTime().ToString();
            if (reader.Read())
            {
                //同时操纵两张表的内容，实现线上借书的功能
                string name = reader.GetString(0);
                SqlConnection conn2 = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
                conn2.Open();
                SqlCommand comm2 = conn.CreateCommand();
                conn.Close();
                comm2 = conn2.CreateCommand();
                comm2.CommandText = "insert into borrow_record values ('"+this.stuno+"','"+this.user+"','"+textBox2.Text.Trim()+"','"+name+"','"+datetime+"')";
                comm2.ExecuteNonQuery();
                conn2.Close();
                SqlConnection conn3 = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
                SqlCommand comm3 = conn3.CreateCommand();
                comm3.CommandText = "";
                MessageBox.Show("借阅成功","借阅成功");
            }
            else return;
            conn.Close();
        }
    }
}
