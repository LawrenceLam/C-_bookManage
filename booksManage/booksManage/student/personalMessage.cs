using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
//学生编辑自己信息的界面，学生只能编辑自己的联系电话和校内住址
namespace booksManage
{
    public partial class PersonalMessage : Form
    {
        string sphonenumber;
        string slocation;
        MySqlConnection mconn;
        string uniqueNo;
        public PersonalMessage(string stuno)
        {
            this.uniqueNo = stuno;
            InitializeComponent();
            //设置Mysql连接,并且打开连接
            string information = "server=localhost;port=3306;database=booksmanage;user = root;password=weiming229.;SslMode=none;Charset=utf8";
            mconn = new MySqlConnection(information);
            mconn.Open();
            //设置SQL查询语句
            MySqlCommand mcomm = mconn.CreateCommand();
            mcomm.CommandText = "select * from student_message where 学号='" + stuno + "'";
            //执行SQL语句
            MySqlDataReader reader = mcomm.ExecuteReader();
            reader.Read();
            //将查询到的内容写入文本框中
            int num = reader.GetInt16("学生类别号");
            if (num == 1) type.Text = "本科生";
            if (num == 2) type.Text = "硕士研究生";
            if (num == 3) type.Text = "博士研究生";
            string no = reader.GetString("学号");
            string name = reader.GetString("姓名");
            string major = reader.GetString("专业");
            string grade = reader.GetString("年级");
            string nump = reader.GetString("联系电话");
            string stulocation = reader.GetString("校内住址");
            studentno.Text = no;
            studentname.Text = name;
            studentmajor.Text = major;
            studentgrade.Text = grade;
            phonenumber.Text = nump;
            location.Text = stulocation;
            reader.Close();
        }
        //设置可编辑，当按下编辑按钮的时候，数据才变为可编辑状态
        private void bianji_Click(object sender, EventArgs e)
        {
            //设置页面原有的按钮为不可视和不可编辑
            bianji.Visible = false;
            bianji.Enabled = false;
            //将页面的按钮都显示
            finish.Visible = true;
            finish.Enabled = true;
            quxiao.Visible = true;
            quxiao.Enabled = true;
            phonenumber.ReadOnly = false;
            location.ReadOnly = false;
            sphonenumber = phonenumber.Text;
            slocation = location.Text;
        }
        //取消编辑功能，还原
        private void quxiao_Click(object sender, EventArgs e)
        {
            //设置页面原有的按钮为可视和可编辑
            bianji.Visible = true;
            bianji.Enabled = true;
            //将页面的按钮都显示和可编辑
            finish.Visible = false;
            finish.Enabled = false;
            quxiao.Visible = false;
            quxiao.Enabled = false;
            phonenumber.ReadOnly = true;
            location.ReadOnly = true;
            location.Text = slocation;
            phonenumber.Text = sphonenumber;
        }
        //完成编辑功能，将修改后的内容写回数据库中
        private void finish_Click(object sender, EventArgs e)
        {
            slocation = location.Text;
            sphonenumber = phonenumber.Text;
            //将修改写回数据库
            MySqlCommand mcomm = mconn.CreateCommand();
            mcomm.CommandText = "update student_message set 校内住址='" + slocation + "',联系电话='" + sphonenumber + "' where 学号='"+uniqueNo+"'";
            mcomm.ExecuteNonQuery();
            //将页面原有的按钮恢复
            bianji.Visible = true;
            bianji.Enabled = true;
            location.ReadOnly = true;
            phonenumber.ReadOnly = true;
            finish.Enabled = false;
            finish.Visible = false;
            quxiao.Visible = false;
            quxiao.Enabled = false;
        }
    }
}
