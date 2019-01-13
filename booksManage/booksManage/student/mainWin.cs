using booksManage.student;
using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace booksManage
{
    public partial class mainWin : Form
    {
        string stuno;
        string user;
        public mainWin(string stuno)
        {
            this.stuno = stuno;
            string user;
            //初始化连接类
            SqlConnection mycnn = new SqlConnection();
            //设置连接属性
            mycnn.ConnectionString = "server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True";
            //连接数据库
            mycnn.Open();
            //设置SQL语句
            SqlCommand mcomm = mycnn.CreateCommand();
            mcomm.CommandText = "select 姓名 from student_message where 学号='"+stuno+"'";
            //执行查询语句
            SqlDataReader reader = mcomm.ExecuteReader();
            reader.Read();
            user = reader.GetString(reader.GetOrdinal("姓名"));
            this.user = user;
            InitializeComponent();
            label1.Text = "欢迎你，" + user + "同学"+this.stuno;
        }
        //调用学生个人信息管理的功能
        private void button1_Click(object sender, EventArgs e)
        {
            PersonalMessage message = new PersonalMessage(stuno);
            message.ShowDialog();
        }
        //调用查看本人借阅记录的功能
        private void button2_Click(object sender, EventArgs e)
        {
            Record record = new Record(this.stuno);
            record.ShowDialog();
        }
        //注销本次登录
        private void button4_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new Form1())).Start();
            this.Dispose();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            books book = new books(stuno,user);
            book.ShowDialog();
        }
    }
}
