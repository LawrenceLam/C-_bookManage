using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

//本界面是管理员身份的书籍管理界面，管理员可以对书籍进行增删改查的操作
namespace booksManage
{
    public partial class managerSearch : Form
    {
        public managerSearch()
        {
            InitializeComponent();
        }

        private void managerSearch_Load(object sender, EventArgs e)
        {
            // 这行代码将数据加载到表“bookManageDataSet.books”中。您可以根据需要移动或删除它。
            this.booksTableAdapter.Fill(this.bookManageDataSet.books);

        }
        //实现将数据集添加到GridView控件中，让数据可视化
        private void show()
        {
            this.booksTableAdapter.Fill(this.bookManageDataSet.books);
        }
        //搜索按钮
        private void search_Click(object sender, EventArgs e)
        {
            //设置连接数据库以及SQL语句
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            //判断文本框是否都为空，都为空的时候不需要进行搜索操作
            if (searchshuhao.Text.Equals("") && searchshuming.Text.Equals("") && searchzuozhe.Text.Equals("") && searchchubanshe.Text.Equals("") && searchweizhi.Text.Equals("")) return;
            string strcon = "";//用来设置查询语句，当文本框中有文本内容，就将需要搜索的对应条件添加到查询语句中
            if (!searchshuhao.Text.Equals("")) strcon = "where 书号 like '%" + searchshuhao.Text + "%'";// 当文本框中有文本内容，就将需要搜索的对应条件添加到查询语句中
            if (searchshuming.Text != "")
            {
                if (strcon != "") strcon += " and 书名 like '%" + searchshuming.Text + "%'";//除了第一个文本框外，在确定查询语句的时候需要确定当前是不是第一个查询条件
                else strcon = "where 书名 like '%" + searchshuming.Text + "%'";//当strcon为空，表示当前的条件为第一个查询条件
            }
            if (searchzuozhe.Text != "")
            {
                if (strcon != "") strcon += " and 作者 like '%" + searchzuozhe.Text + "%'";
                else strcon = "where 作者 like '%" + searchzuozhe.Text + "%'";
            }
            if (searchchubanshe.Text != "")
            {
                if (strcon != "") strcon += " and 出版社 like '%" + searchchubanshe.Text + "%'";
                else strcon = "where 出版社 like '%" + searchchubanshe.Text + "%'";
            }
            comm.CommandText = "select * from books " + strcon;
            SqlDataAdapter sda = new SqlDataAdapter(comm);//使用adapter类直接利用DataSet类，将查询到的数据填充到dataset中，再添加到GridView中
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        //添加数据
        private void button2_Click(object sender, EventArgs e)
        {
            if (editshuhao.Text == "" || editshuming.Text == "" || editzuozhe.Text == "" || editchubanshe.Text == "" || editweizhi.Text == "" || editnum.Text == "")
            {
                MessageBox.Show("信息不完整", "信息不完整");
                return;
            }//本添加功能中所有数据的内容必须为非空
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "insert into books values ('"+editshuhao.Text+"'"+",'"+editshuming.Text+"','"+editzuozhe.Text+"','"+editchubanshe.Text+"','"+editnum.Text+"','"+editweizhi.Text+"')";
            comm.ExecuteNonQuery();
            MessageBox.Show("添加成功","添加成功");
            conn.Close();
            show();
        }
        //修改功能
        private void button4_Click(object sender, EventArgs e)
        {
            if (altershuhao.Text == "")
            {
                return;//修改功能以书籍号为主键，书籍号无法修改，而且必须填写
            }
            string strcon = "";//与搜索功能类似，修改功能可以只修改其中部分内容，所以需要确定哪些条件的文本框有内容，即需要修改的项
            if (altershuming.Text != "")
            {
                strcon = " set 书名 = '" + altershuming.Text + "'";
            }
            if (alterzuozhe.Text != "")
            {
                if (strcon != "") strcon += " , 作者 = '" + alterzuozhe.Text + "'";
                else strcon = "set 作者 = '" + alterzuozhe.Text + "'";
            }
            if (alterchubanshe.Text != "")
            {
                if (strcon != "") strcon += " , 出版社 = '" + alterchubanshe.Text + "'";
                else strcon = " set 出版社= '" + alterchubanshe.Text + "'";
            }
            if (alternum.Text != "")
            {
                if (strcon != "") strcon += ", 在库数量='" + alternum.Text + "'";
                else strcon = "set 在库数量='" + alternum.Text + "'";
            }
            if (alterweizhi.Text != "")
            {
                if (strcon != "") strcon += ", 位置='" + alterweizhi.Text + "'";
                else strcon = "set 位置='" + alterweizhi.Text + "'";
            }
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "update books "+strcon+" where 书号='"+altershuhao.Text+"'";
            comm.ExecuteNonQuery();
            MessageBox.Show("修改成功","修改成功");
            conn.Close();
            show();
        }
        //删除功能
        private void button5_Click(object sender, EventArgs e)
        {
            //删除功能比较简单，只需将要删除的书号填写即可删除对应的数据
            string delete = deleteshuhao.Text.Trim();
            if (delete == "") return;
            string command = "delete from books where 书号='" + delete +"'";
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = command;
            comm.ExecuteNonQuery();
            MessageBox.Show("删除成功","删除成功");
            conn.Close();
            show();
        }
    }
}
