using MySql.Data.MySqlClient;
using System;
using System.Threading;
using System.Windows.Forms;

//此界面为管理员登录界面
namespace booksManage
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取用户框和密码框中输入的信息
            string user = textBox1.Text;
            string password = textBox2.Text;
            //先判断输入框中是否有为空
            if (user.Equals("") || password.Equals(""))
            {
                MessageBoxButtons yes = new MessageBoxButtons();
                MessageBox.Show("请检查用户名和密码是否输入完整", "输入信息不完整", yes);
                return;
            }
            //设置mysql连接
            string constr = "server=localhost;port=3306;database=booksmanage;user = root;password=weiming229.;SslMode=none;Charset=utf8";
            MySqlConnection mycon = new MySqlConnection(constr);
            //打开数据库连接
            mycon.Open();
            //设置查询语句
            MySqlCommand comm = mycon.CreateCommand();
            comm.CommandText = "Select * from manager_login_message where name = '" + user + "' ";
            //执行查询语句
            MySqlDataReader mReader = comm.ExecuteReader();
            //管理员账号存在
            if (mReader.Read())
            {
                string pass = mReader.GetString(mReader.GetOrdinal("passwd"));
                //密码符合的时候跳转页面
                if (pass.Equals(password))
                {
                    //跳转到管理员的主界面
                    new Thread(() => Application.Run(new managermainwin(user))).Start();
                    this.Close();
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
        //跳转到学生登录界面
        private void button3_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new Form1())).Start();
            this.Close();
        }
    }
}
