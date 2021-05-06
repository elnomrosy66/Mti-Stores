using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTI_Stores_Manager
{
    public partial class loginForm : MetroFramework.Forms.MetroForm
    {
        DAL.user user = new DAL.user();
        DAL.dbDataContext db = new DAL.dbDataContext();
        public loginForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string pass = txtpass.Text;
            if (userName == "" || pass == "")
            {
                MessageBox.Show("لم يتم إدخال اسم المستخدم او كلمة المرور");
            }
            user = new DAL.user();
            int exest = db.users.Where(i => i.user_name == userName).Where(s => s.pass == pass).Count();
            if (exest > 0)
            {
                //MessageBox.Show("تم تسجيل الدخول");
                user = db.users.Where(i => i.user_name == userName).Where(s => s.pass == pass).FirstOrDefault();
                Properties.Settings.Default.user_id = user.id;
                Properties.Settings.Default.Save();
                this.Hide();
                new Home_form().Show();
            }
            else
            {
                MessageBox.Show("خطاء في اسم المستخدم أو كلمة المرور");
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }
    }
}
