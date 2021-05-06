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
    public partial class addUserForm : MetroFramework.Forms.MetroForm
    {
        DAL.dbDataContext db = new DAL.dbDataContext();
        DAL.user user;
        public addUserForm()
        {
            InitializeComponent();
        }
        void save()
        {
            if (txtName.Text.Trim() == string.Empty || txtPass.Text.Trim() == string.Empty || txtUser.Text.Trim() == string.Empty)
            {
                MessageBox.Show("الرجاء عدم ترك حقول فارغة");
                return;
            }
            
            if (user.id == 0)
            {
                db = new DAL.dbDataContext();
                db.users.InsertOnSubmit(user);
                SetData();
                db.SubmitChanges();
            }
            else
            {
                SetData();
                db.SubmitChanges();
            }
            
            MessageBox.Show("تم الحفظ بنجاح");
            dgvUsers.DataSource = db.users;
            New();
        }
        void GetData()
        {
            txtName.Text = user.name;
            txtPass.Text = user.pass;
            txtUser.Text = user.user_name;
            Cmb_Types.SelectedItem = user.type;
        }
        void SetData()
        {
            user.name = txtName.Text;
            user.pass = txtPass.Text;
            user.user_name =  txtUser.Text;
            user.type = Cmb_Types.SelectedItem.ToString();
        }
        void New()
        {
            user = new DAL.user();
            GetData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            New();
            btnDelete.Enabled = false;
        }

        private void addUserForm_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = db.users;
            dgvUsers.Columns["id"].Visible = false;
            dgvUsers.Columns["name"].HeaderText = "الاسم";
            New();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            if (dgvUsers.CurrentRow.Cells[0].Value != null)
            {
                id = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                user = db.users.Where(s => s.id == id).FirstOrDefault();
                btnDelete.Enabled = true;
                GetData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (dgvUsers.CurrentRow.Cells[0].Value != null)
            {
                id = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                user = db.users.Where(s => s.id == id).FirstOrDefault();
                DialogResult dialog = MessageBox.Show("هل تريد بالفعل حذف هذا المستخدم", "تحذير", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    db.users.DeleteOnSubmit(user);
                    db.SubmitChanges();
                    db = new DAL.dbDataContext();
                    dgvUsers.DataSource = db.users;
                    dgvUsers.Columns["id"].Visible = false;
                    dgvUsers.Columns["name"].HeaderText = "الاسم";
                    New();
                    btnDelete.Enabled = false;
                }

            }
        }
    }
}
