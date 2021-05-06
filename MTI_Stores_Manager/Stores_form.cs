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
    public partial class Stores_form : MetroFramework.Forms.MetroForm
    {
        DAL.dbDataContext db = new DAL.dbDataContext();
        DAL.store store;
        public Stores_form()
        {
            InitializeComponent();
           
            New();
        }

        void save ()
        {
            if(txt_name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("الرجاء عدم ترك حقل الاسم فارغ");
                return;
            }
            if(store.id == 0)
            {
                db = new DAL.dbDataContext();
                db.stores.InsertOnSubmit(store);
                SetData();
                db.SubmitChanges();
            }
            else
            {
                SetData();
                db.SubmitChanges();
            }
            MessageBox.Show("تم الحفظ بنجاح");
            DGV_stores.DataSource = db.stores;
            New();
        }
        void GetData()
        {
            txt_name.Text = store.name;
            txt_name.Focus();
        }
        void SetData()
        {
            store.name = txt_name.Text;
        }
        void New()
        {
            store = new DAL.store();
            GetData();
        }

        private void Stores_form_Load(object sender, EventArgs e)
        {
            DGV_stores.DataSource = db.stores;
            DGV_stores.Columns["id"].Visible = false;
            DGV_stores.Columns["name"].HeaderText = "الاسم";
            New();
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
                store = db.stores.Where(s => s.id == id).FirstOrDefault();
                GetData();
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DGV_stores.Rows.Count > 0)
            {
                if (DGV_stores.SelectedRows != null)
                {
                    int id = Convert.ToInt32(DGV_stores.CurrentRow.Cells[0].Value.ToString());

                    store = db.stores.Where(u => u.id == id).FirstOrDefault();
                    if (store.items.Count > 0)
                    {

                        MessageBox.Show("لا يمكن حذف المخزن حيث تم استخدامه في ععمليات من قبل ومسحه سيؤدي لتلف بعض البيانات");
                        return;
                    }
                    db.stores.DeleteOnSubmit(store);
                    db.SubmitChanges();
                    New();
                    btnDelete.Enabled = false;
                    MessageBox.Show("تم حذف المخزن بنجاح");
                    db = new DAL.dbDataContext();
                    DGV_stores.DataSource = db.stores;
                    DGV_stores.Columns["id"].Visible = false;
                    DGV_stores.Columns["name"].HeaderText = "الاسم";
                    return;
                }
            }
        }
    }
    
}
