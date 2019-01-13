using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
//对学生信息的管理。可以增删改查
namespace booksManage
{
    public partial class userSearch : Form
    {
        public userSearch()
        {
            InitializeComponent();
        }
        //初始化界面的时候调用，将数据表的内容绑定到GridView中
        private void userSearch_Load(object sender, EventArgs e)
        {
            // 这行代码将数据加载到表“bookManageDataSet1.student_message”中。您可以根据需要移动或删除它。
            this.student_messageTableAdapter.Fill(this.bookManageDataSet1.student_message);

        }
        //显示数据，每次对数据进行操作后调用，实现刷新GridView中内容的效果
        private void show()
        {
            this.student_messageTableAdapter.Fill(this.bookManageDataSet1.student_message);
        }
        //搜索功能，搜索数据表中的用户，支持多条件查找，模糊查找
        private void search_Click(object sender, EventArgs e)
        {
            //当所有条件都为空的时候，无需进行查找操作
            if (leibie.Text.Equals("") && xuehao.Text.Equals("") && xingming.Text.Equals("") && zhuanye.Equals("") && nianji.Text.Equals("") && dizhi.Text == "" && dianhua.Text == "") return;
            //设置连接字符串
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();            
            string strcon = "";//用来将对应是搜索条件转换为搜索语句
            if (!leibie.Text.Equals("")) strcon = "where 学生类别号 like '%" + leibie.Text + "%'";//通过判断文本框是否为空判断哪些是搜索条件
            if (xuehao.Text != "")
            {//除了第一个文本框外，其余的都要判断strcon是否为空，以判断当前是不是第一个搜索条件
                if (strcon != "") strcon += " and 学号 like '%" + xuehao.Text + "%'";
                else strcon = "where 学号 like '%" + xuehao.Text + "%'";
            }
            if (xingming.Text != "")
            {
                if (strcon != "") strcon += " and 姓名 like '%" + xingming.Text + "%'";
                else strcon = "where 姓名 like '%" + xingming.Text + "%'";
            }
            if (zhuanye.Text != "")
            {
                if (strcon != "") strcon += " and 专业 like '%" + zhuanye.Text + "%'";
                else strcon = "where 专业 like '%" + zhuanye.Text + "%'";
            }
            if (nianji.Text != "")
            {
                if (strcon != "") strcon += " and 年级 like '%" + nianji.Text + "%'";
                else strcon = "where 年级 like '%" + nianji.Text + "%'";
            }
            if (dianhua.Text != "")
            {
                if (strcon != "") strcon += " and 联系电话 like '%" + dianhua.Text + "%'";
                else strcon = "where 联系电话 like '%" + dianhua.Text + "%'";
            }
            if (dizhi.Text != "")
            {
                if (strcon != "") strcon += " and 校内地址 like '%" + dizhi.Text + "%'";
                else strcon = "where 校内地址 like '%" + dizhi.Text + "%'";
            }
            comm.CommandText = "select * from student_message " + strcon;
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();//将搜索到的结果填充到DataSet中，再讲DataSet与GridView绑定
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        //删除操作，主键是学号
        private void button1_Click(object sender, EventArgs e)
        {
            string xuhao = delete.Text.Trim();
            if (xuehao.Text == "") return;//学号为空的情况下无需进行操作
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "delete from student_message where 学号='" + xuhao + "'";
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("删除成功","删除成功");
            show();
        }
        //添加操作，所有的条件都是非空
        private void add_Click(object sender, EventArgs e)
        {
            //当有条件为空的时候发出警告，中断添加操作
            if (leibie.Text == "" || xuehao.Text == "" || xingming.Text == "" || zhuanye.Text == "" || nianji.Text == ""||dianhua.Text==""||dizhi.Text=="")
            {
                MessageBox.Show("输入信息不完整", "输入信息不完整");
                return;
            }
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "insert into student_message values ('" + leibie.Text + "','" + xuehao.Text + "','" + xingming.Text + "','" + zhuanye.Text + "','" + nianji.Text +"','"+dianhua.Text+"','"+dizhi.Text+ "')";
            comm.ExecuteNonQuery();
            //主键是唯一的无法重复插入，当插入重复主键的内容会中断操作并发出警告
            MessageBox.Show("添加成功", "添加成功");
            show();
            conn.Close();
        }
        //修改,操作，学号是主码，除了学号外其余的都可以修改
        private void xiugai_Click(object sender, EventArgs e)
        {
            //学号为空的时候无需进行操作
            if (xuehao.Text == "")
            {
                MessageBox.Show("学号是必填项", "输入信息不完整");
                return;
            }
            string strcon="";//用来将修改条件转换为修改的语句
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            if (leibie.Text != "") strcon = " set 学生类别号='" + leibie.Text + "'";//通过文本框内容是否为空判断是否为修改的内容
            if (xingming.Text != "")
            {//除了第一个文本框外，其余的除了要判断自身文本框是否为空，还要判断strcon是否为空，以此确定什么时候是第一个条件
                if (strcon != "") strcon += ",set 姓名='" + xingming.Text +"'";
                else strcon+= "set 姓名 = '" + xingming.Text +"'";
            }
            if (zhuanye.Text != "")
            {
                if (strcon != "") strcon += " ,set 专业='" + zhuanye.Text +"'";
                else strcon+= "set 专业 = '" + zhuanye.Text +"'";
            }
            if (nianji.Text != "")
            {
                if(strcon!="")strcon+= " ,set 年级='" + nianji.Text + "'";
                else strcon+= "set 年级='" + nianji.Text + "'";
            }
            if (dianhua.Text != "")
            {
                if(strcon!="") strcon += " ,set 联系电话='" + dianhua.Text + "'";
                else strcon += "set 联系电话='" + dianhua.Text + "'";
            }
            if (dizhi.Text != "")
            {
                if(strcon!="") strcon += " ,set 校内地址='" + dizhi.Text + "'";
                else strcon += " set 校内地址='" + dizhi.Text + "'";
            }
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "update student_message "+strcon+" where 学号='" + xuehao.Text + "'";
            comm.ExecuteNonQuery();
            MessageBox.Show("修改成功", "修改成功");
            show();
            conn.Close();
        }
    }
}
