using booksManage.manager;
using System;
using System.Threading;
using System.Windows.Forms;
//管理员的主操作界面
namespace booksManage
{
    public partial class managermainwin : Form
    {
        //使用构造函数记录当前的用户名
        string user;
        public managermainwin(string user)
        {
            this.user = user;
            InitializeComponent();
            label8.Text = user;
        }
        //调用学生信息管理功能
        private void button1_Click(object sender, EventArgs e)
        {
            userSearch user = new userSearch();
            user.ShowDialog();
        }
        //调用管理借阅记录的功能
        private void button2_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            record.ShowDialog();
        }
        //调用借阅制度的功能
        private void button5_Click(object sender, EventArgs e)
        {
            managerBorrowSet set = new managerBorrowSet();
            set.ShowDialog();
        }
        //调用搜索书籍的功能
        private void button3_Click(object sender, EventArgs e)
        {
            managerSearch search = new managerSearch();
            search.ShowDialog();
        }
        //调用管理员信息管理的功能
        private void button4_Click(object sender, EventArgs e)
        {
            managerMessage message = new managerMessage();
            message.ShowDialog();
        }
        //注销登录
        private void button6_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new Form2())).Start();
            this.Dispose();
            this.Close();
        }
    }
}
