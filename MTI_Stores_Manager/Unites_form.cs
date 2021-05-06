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
    public partial class Unites_form : MetroFramework.Forms.MetroForm
    {
        DAL.dbDataContext db = new DAL.dbDataContext();
        DAL.unite unit;
        public Unites_form()
        {
            InitializeComponent();
            New();
        }


        void save()
        {
            if (txt_name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("الرجاء عدم ترك حقل الاسم فارغ");
                return;
            }

            if (unit.id == 0)
            {
                db = new DAL.dbDataContext();
                db.unites.InsertOnSubmit(unit);
                SetData();
                db.SubmitChanges();
            }
            else
            {
                SetData();
                db.SubmitChanges();
            }
            MessageBox.Show("تم الحفظ بنجاح");
            DGV_stores.DataSource = db.unites;
            New();
        }

        void GetData()
        {
            
            txt_name.Text = unit.name;
            txt_name.Focus();

        }
        void SetData()
        {
            unit.name = txt_name.Text;
        }
        void New()
        {
            unit = new DAL.unite();
            DGV_stores.DataSource = db.unites;
            DGV_stores.Columns["id"].Visible = false;
            DGV_stores.Columns["name"].HeaderText = "الاسم";
            GetData();
        }

        private void Unites_form_Load(object sender, EventArgs e)
        {
            DGV_stores.DataSource = db.unites;
            DGV_stores.Columns["id"].Visible = false;
            DGV_stores.Columns["name"].HeaderText = "الاسم";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            New();
            btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void DGV_stores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            if (DGV_stores.CurrentRow.Cells[0].Value != null)
            {
                id = Convert.ToInt32(DGV_stores.CurrentRow.Cells[0].Value.ToString());
                unit = db.unites.Where(s => s.id == id).FirstOrDefault();
                GetData();
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            save();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            New();
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (DGV_stores.Rows.Count > 0)
            {
                if (DGV_stores.SelectedRows != null)
                {
                    int id = Convert.ToInt32(DGV_stores.CurrentRow.Cells[0].Value.ToString());

                    unit = db.unites.Where(u => u.id == id).FirstOrDefault();
                    if (unit.movements.Count > 0)
                    {

                        MessageBox.Show("لا يمكن حذف الوحدة حيث تم استخدامها في ععمليات من قبل ومسحها سيؤدي لتلف بعض البيانات");
                        return;
                    }
                    db.unites.DeleteOnSubmit(unit);
                    db.SubmitChanges();
                    New();
                    btnDelete.Enabled = false;
                    MessageBox.Show("تم حذف الوحدة بنجاح");
                     db = new DAL.dbDataContext();
                    DGV_stores.DataSource = db.unites;
                    DGV_stores.Columns["id"].Visible = false;
                    DGV_stores.Columns["name"].HeaderText = "الاسم";
                    return;
                }
            }
        }
    }
}
