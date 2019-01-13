using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

//学生身份查看借阅记录，只能对自己的阅读记录进行查看和搜索
namespace booksManage.student
{
    public partial class Record : Form
    {
        string stuo;
        public Record(string stuno)
        {
            this.stuo = stuno;
            InitializeComponent();
        }
        //搜索功能
        private void button4_Click(object sender, EventArgs e)
        {
            //所有搜索条件都为空的情况下，不用进行搜索操作
            if (shuhao.Text.Equals("") && shuming.Text.Equals("") && shijian.Text.Equals(""))return;
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            string strcon = "";//用来将对应的条件转换为搜索语句
            if (!shuhao.Text.Equals("")) strcon = "where 借阅书籍书号 like '%" + shuhao.Text + "%'";//在搜索条件文本框不为空的情况下，才将条件加入搜索语句中
            if (shuming.Text != "")
            {
                if (strcon != "") strcon += " and 借阅书籍书名 like '%" + shuming.Text + "%'";//除去第一个文本框外，其余的文本框除了需要确定是否为空，还需要判断stricon字符串是否为空
                else strcon = "where 借阅书籍书名 like '%" + shuming.Text + "%'";
            }
            if (shijian.Text != "")
            {
                if (strcon != "") strcon += " and 借阅时间 like '%" + shijian.Text + "%'";
                else strcon = "where 借阅时间 like '%" + shijian.Text + "%'";
            }
            //搜索条件可以有部分为空，支持多条件查找，模糊查找
            comm.CommandText = "select * from borrow_record " + strcon;
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }
        //加载界面，界面刚启动时将数据加载到GridView中
        private void Record_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bookManageDataSet5.borrow_record”中。您可以根据需要移动或删除它。
            this.borrow_recordTableAdapter.Fill(this.bookManageDataSet5.borrow_record);
            // TODO: 这行代码将数据加载到表“bookManageDataSet4.borrow_message”中。您可以根据需要移动或删除它。
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");

        }
    }
}
