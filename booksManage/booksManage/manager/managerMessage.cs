using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace booksManage
{
    //本界面实现的是对管理员账号的管理，任意管理员账号都可以为本系统添加一个管理员账号，或者删除和修改其他管理员账号的密码，
    public partial class managerMessage : Form
    {
        //构造函数
        public managerMessage()
        {
            InitializeComponent();
        }

        private void managerMessage_Load(object sender, EventArgs e)
        {
            // 这行代码将数据加载到表“bookManageDataSet3.manager_login_message”中。您可以根据需要移动或删除它。
            this.manager_login_messageTableAdapter.Fill(this.bookManageDataSet3.manager_login_message);

        }
        //用于将数据显示到GridView中，对数据进行修改后调用此方法即可刷新GridView中的数据显示
        private void show()
        {
            this.manager_login_messageTableAdapter.Fill(this.bookManageDataSet3.manager_login_message);
        }
        //添加数据，对应添加按钮
        private void button1_Click(object sender, EventArgs e)
        {
            //先获取文本框中的账户名和密码
            string name = textname.Text.Trim();
            string pass = textpass.Text.Trim();
            //设置连接字符串
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            //将数据插入数据表中
            comm.CommandText = "insert into manager_login_message values ('"+name+"','"+pass+"')";
            comm.ExecuteNonQuery();
            MessageBox.Show("添加成功","添加成功");
            show();
            conn.Close();
        }

        //搜索，对应搜索按钮，实现对现有用户的搜索与检索
        private void button2_Click(object sender, EventArgs e)
        {
            string name = textname.Text.Trim();
            string pass = textpass.Text.Trim();
            if (name.Equals("") && pass == "") return;
            //设置连接字符串
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            string strcon = "";
            if (!name.Equals("")) strcon = "where name like '%" + name + "%'";
            if (pass != "")
            {
                if (strcon != "") strcon += " and passwd like '%" + pass + "%'";
                else strcon = "where passwd like '%" + pass + "%'";
            }
            comm.CommandText = "select * from manager_login_message " + strcon;
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        //删除功能，每一个账户都可以删除其他的用户
        private void button3_Click(object sender, EventArgs e)
        {
            string name = textname.Text.Trim();
            string pass = textpass.Text.Trim();
            if (name.Equals("") && pass == "") return;
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "delete from manager_login_message where name='" + name+ "'";
            comm.ExecuteNonQuery();
            MessageBox.Show("删除成功","删除成功");
            show();
        }
        //修改，对应修改按钮
        private void button4_Click(object sender, EventArgs e)
        {
            string name = textname.Text.Trim();
            string pass = textpass.Text.Trim();
            if (name.Equals("") && pass == "") return;
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            //manager_login_message表中的主键是用户名，所以修改时只可能修改密码
            comm.CommandText = "update manager_login_message set passwd='" + pass + "' where name='"+name+"'";
            comm.ExecuteNonQuery();
            MessageBox.Show("修改成功", "修改成功");
            show();
            conn.Close();
        }
    }
}
