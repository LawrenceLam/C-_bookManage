using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
//学生登录界面
namespace booksManage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取用户框和密码框中输入的信息
            string user = stuno.Text.Trim();
            string password = passwd.Text.Trim();
            //先判断输入框中是否有为空
            if (user.Equals("") || password.Equals(""))
            {
                MessageBoxButtons yes = new MessageBoxButtons();
                MessageBox.Show( "请检查用户名和密码是否输入完整", "输入信息不完整", yes);
                return;
            }
            //设置mysql连接
            string constr = "server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True";
            SqlConnection mycon = new SqlConnection(constr);
            //打开数据库连接
            mycon.Open();
            //设置查询语句
            SqlCommand comm = mycon.CreateCommand();
            comm.CommandText = "Select * from student_login_message where stuno = '" + user + "' ";
            //执行查询语句
            SqlDataReader mReader = comm.ExecuteReader();
            //学号存在
            if (mReader.Read())
            {
                string pass = mReader.GetString(mReader.GetOrdinal("passwd"));
                //密码符合的时候跳转页面
                if (pass.Equals(password))
                {
                    mycon.Close();
                    new Thread(() => Application.Run(new mainWin(user))).Start();
                    this.Close();
                    return;
                }
                //密码不符合
                else
                {
                    MessageBoxButtons yes = new MessageBoxButtons();
                    MessageBox.Show("请检查用户名和密码是否输入正确", "输入信息错误", yes);
                    mycon.Close();
                    return;
                }
            }
            //学号不存在
            else
            {
                MessageBoxButtons yes = new MessageBoxButtons();
                MessageBox.Show("请检查用户名和密码是否输入正确", "输入信息错误", yes);
                mycon.Close();
                return;
            }
        }
        //按钮按下时，跳转到管理员登录界面
        private void button3_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new Form2())).Start();
            this.Close();
        }
    }
}
