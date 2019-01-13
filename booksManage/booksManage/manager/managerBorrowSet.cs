using System;
using System.Data.SqlClient;
using System.Windows.Forms;
//借阅制度管理界面，管理员可以通过此页面制定借阅规则
namespace booksManage
{
    public partial class managerBorrowSet : Form
    {
        public managerBorrowSet()
        {
            InitializeComponent();
        }

        private void managerBorrowSet_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bookManageDataSet4.borrow_message”中。您可以根据需要移动或删除它。
            this.borrow_messageTableAdapter.Fill(this.bookManageDataSet4.borrow_message);

        }
        //用来显示数据的内容到GridView中
        private void show()
        {
            this.borrow_messageTableAdapter.Fill(this.bookManageDataSet4.borrow_message);
        }
        //添加新规则
        private void button1_Click(object sender, EventArgs e)
        {
            //所有的内容都要求为非空，一旦有数据为空，则发出提示，中断操作
            if (leibie.Text == "" || leib.Text == "" || shangxian.Text == "" || tianshu.Text == "")
            {
                MessageBox.Show("输入不完整", "输入不完整");
                return;
            }
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "insert into borrow_message values ('" + leibie.Text + "','" + leib.Text + "','"+shangxian.Text+"','"+tianshu.Text+"')";
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("添加成功", "添加成功");
            show();
        }
        //修改借阅制度
        private void button4_Click(object sender, EventArgs e)
        {
            //部分内容可以为空，修改非空的部分数据
            if (leibie.Text == "" || leib.Text == "" || shangxian.Text == "" || tianshu.Text == "")
            {
                MessageBox.Show("输入不完整", "输入不完整");
            }
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "update borrow_message set 学生类别='" + leib.Text +"',借阅上限='"+shangxian.Text+"', 借阅天数='"+tianshu.Text+ "' where 学生类别号='" + leibie.Text + "'";
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("修改成功", "修改成功");
            show();
        }
        //删除借阅功能，全码
        private void button3_Click(object sender, EventArgs e)
        {
            if (leibie.Text == "" || leib.Text == "" || shangxian.Text == "" || tianshu.Text == "")
            {
                MessageBox.Show("输入不完整", "输入不完整");
            }
            SqlConnection conn = new SqlConnection("server=DESKTOP-Q6HVTFK\\SQLEXPRESS;database=bookManage;uid=sa;pwd=weiming229.;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "delete from borrow_message where 学生类别号='" + leibie.Text + "'";
            comm.ExecuteNonQuery();
            MessageBox.Show("删除成功", "删除成功");
            show();
        }
    }
}
