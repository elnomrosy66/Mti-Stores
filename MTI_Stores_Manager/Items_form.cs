using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTI_Stores_Manager
{
    public partial class Items_form : MetroFramework.Forms.MetroForm
    {
        DAL.dbDataContext db = new DAL.dbDataContext();
        DAL.dbDataContext db2 = new DAL.dbDataContext();
        DAL.item item;
        DAL.item item2;
        DAL.unites_relation unit_relation;
        DataTable dtt = new DataTable();
        public Items_form()
        {
            InitializeComponent();
            this.Load += Items_form_Load;
            
        }

        private void Items_form_Load(object sender, EventArgs e)
        {
            Cmb_stores.DataSource = db.stores;
            Cmb_stores.ValueMember = "id";
            Cmb_stores.DisplayMember = "name";
            Cmb_unites.DataSource = db.unites;
            Cmb_unites.ValueMember = "id";
            Cmb_unites.DisplayMember = "name";
            refreshItems();
            if (dgvItems.Rows.Count > 0)
            dgvItems.Rows[0].Selected = true;
             db2 = new DAL.dbDataContext();
            Cmb_subUnit.DataSource = db2.unites;
            Cmb_subUnit.ValueMember = "id";
            Cmb_subUnit.DisplayMember = "name";
            New();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            New();
            btnDelete.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("الرجاء عدم ترك حقل الاسم فارغ");
                return;
            }
            if (Cmb_stores.SelectedValue == null)
            {
                MessageBox.Show("الرجاء اختيار مخزن");
                return;
            }
            if (Cmb_stores.SelectedValue == null)
            {
                MessageBox.Show("الرجاء اختيار وحدة رئيسية");
                return;
            }
                         
            if (item.id == 0)
            {
                db = new DAL.dbDataContext();
                db.items.InsertOnSubmit(item);
                unit_relation.item = item;
                unit_relation.sup_unit = Convert.ToInt32(Cmb_unites.SelectedValue.ToString());
                unit_relation.ratio = 1;
                db.unites_relations.InsertOnSubmit(unit_relation);
                SetData();
                db.SubmitChanges();
                foreach (DataGridViewRow row in dgv_subUnits.Rows)
                {
                    //unit_relation = new DAL.unites_relation();
                    //unit_relation.item_id = item.id;
                    //unit_relation.sup_unit = Convert.ToInt32(row.Cells["unit_id"].Value);
                    //unit_relation.ratio = Convert.ToInt32(row.Cells["ratioN"].Value);
                    //db.unites_relations.InsertOnSubmit(unit_relation);
                    //db.SubmitChanges();
                    
                }
            }
            else
            {
                unit_relation = db.unites_relations.Where(i => i.item_id == item.id).Where(i => i.ratio == 1).First();
                unit_relation.sup_unit = Convert.ToInt32(Cmb_unites.SelectedValue.ToString());
                SetData();
                db.SubmitChanges();
            }

            MessageBox.Show("تم إضافة الصنف بنجاح");
            refreshItems();
            New();
           

        }
        private void metroTextBox3_Enter(object sender, EventArgs e)
        {
            //if(Txt_locker.Text == "دولاب")
            //{
            //    Txt_locker.Text = "";
            //    Txt_locker.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            //}
           
        }

        private void Txt_row_Enter(object sender, EventArgs e)
        {
            //if (Txt_row.Text == "صف")
            //{
            //    Txt_row.Text = "";
            //    Txt_row.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            //}

        }

        private void Txt_cell_Enter(object sender, EventArgs e)
        {
            //if (Txt_cell.Text == "رف")
            //{
            //    Txt_cell.Text = "";
            //    Txt_cell.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            //}
        }

        private void Txt_locker_Leave(object sender, EventArgs e)
        {
            //if (Txt_locker.Text == "")
            //{
            //    Txt_locker.Text = "دولاب";
            //    Txt_locker.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            //}
        }

        private void Txt_row_Leave(object sender, EventArgs e)
        {
            //if (Txt_row.Text == "")
            //{
            //    Txt_row.Text = "صف";
            //    Txt_row.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            //}
        }

        private void Txt_cell_Leave(object sender, EventArgs e)
        {
            //if (Txt_cell.Text == "")
            //{
            //    Txt_cell.Text = "رف";
            //    Txt_cell.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            //}
        }

        void refreshItems()
        {
            var i = (from a in db.items
                     from c in db.unites_relations.Where( x => x.ratio == 1 ).Where(x => x.item_id == a.id)
                     join b in db.stores on a.store_id equals b.id
                     join d in db.unites on c.sup_unit equals d.id
                     select new
                     {
                         id = a.id,
                         الاسم = a.name,
                         الوحدة = d.name,
                         المخزن = b.name,
                         حد_الطلب = a.requestLimit,
                         دولاب = a.locker,
                         صف = a.row,
                          رف = a.cell


        }
                ).ToList();
            dgvItems.DataSource = i;
            dgvItems.Columns[0].Visible = false;
            foreach(DataGridViewRow r in dgvItems.Rows)
            {
                decimal In = 0;
                decimal Out = 0;
                decimal initial = 0;
                item2 = db.items.Where(t => t.id == Convert.ToInt32(r.Cells[0].Value.ToString())).FirstOrDefault();
                if (item2.movements.Where(cc => cc.movements_header.type == "وارد").Count() > 0)
                {
                    In = db.movements.Where(cc => cc.item_id == item2.id).Where(cc => cc.movements_header.type == "وارد").Sum(a => a.qty);
                }
                if (item2.movements.Where(cc => cc.movements_header.type == "إفتتاحي").Count() > 0)
                {
                    initial = db.movements.Where(cc => cc.item_id == item2.id).Where(cc => cc.movements_header.type == "إفتتاحي").Sum(a => a.qty);
                }
                if (item2.movements.Where(cc => cc.movements_header.type == "صادر").Count() > 0)
                {
                    Out = db.movements.Where(cc => cc.item_id == item2.id).Where(cc => cc.movements_header.type == "صادر").Sum(a => a.qty);
                }


                if(((In + initial) - Out) <= item2.requestLimit)
                {
                    r.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        void GetData()
        {
            txtName.Text = item.name;
            Cmb_stores.SelectedValue = item.store_id;
            Txt_locker.Text = item.locker;
            Txt_row.Text = item.row;
            Txt_cell.Text = item.cell;
            txtName.Focus();
            txtRequestLimit.Value = item.requestLimit;
        }

        void SetData()
        {
            item.name = txtName.Text;
            int unit_id = Convert.ToInt32(Cmb_unites.SelectedValue.ToString());
            int store_id = Convert.ToInt32(Cmb_stores.SelectedValue.ToString());
            item.store = db.stores.Where(s => s.id == store_id).First();
            item.locker = Txt_locker.Text.ToString();
            item.row = Txt_row.Text.ToString();
            item.cell = Txt_cell.Text.ToString();
            item.requestLimit = Convert.ToInt32(txtRequestLimit.Value);
        }
        void New()
        {
            item = new DAL.item();
            unit_relation = new DAL.unites_relation();
            DataTable dt = new DataTable();
            dgv_subUnits.Columns[0].Visible = false;
            GetData();
            dtt.Clear();
            dgvMvt.DataSource = null;
            dgv_subUnits.DataSource = null;
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Cmb_unites_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lbl_nOfUnites.Text = "عدد الوحدات من وحدة " + Cmb_unites.Text;
        }

        private void Cmb_unites_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            Lbl_nOfUnites.Text = "عدد الوحدات من وحدة " + Cmb_unites.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(item.id ==0 )
            {
                MessageBox.Show("يجب حفظ الصنف اولاً قبل اضافة اي وحدات");
                return;
            }
            if(Cmb_subUnit.SelectedValue == null)
            {
                MessageBox.Show("الرجاء اختيار وحدة");
                return;
            }
            if (ratio.Value <= 0)
            {
                MessageBox.Show("عدد الوحدات لا يمكن ان يكون اقل من او يساوي الصفر");
            }
            int unit_id = Convert.ToInt32(Cmb_subUnit.SelectedValue);
            foreach(DataGridViewRow row in dgv_subUnits.Rows)
            {
                if(Convert.ToInt32(row.Cells[1].Value) == unit_id)
                {
                    MessageBox.Show("هذه الوحدة مضافة بالفعل");
                    return;
                }
            }
            string unit_name = Cmb_subUnit.Text.ToString();
            unit_relation = new DAL.unites_relation();
            unit_relation.item_id = item.id;
            unit_relation.sup_unit = Convert.ToInt32(Cmb_subUnit.SelectedValue.ToString());
            unit_relation.ratio = Convert.ToInt32(ratio.Value.ToString());
            db.unites_relations.InsertOnSubmit(unit_relation);
            db.SubmitChanges();

            int id = item.id;
            item = db.items.Where(s => s.id == id).FirstOrDefault();
            GetData();
            Cmb_unites.SelectedValue = db.unites_relations.Where(s => s.item_id == item.id).Where(r => r.ratio == 1).FirstOrDefault().sup_unit;

            var i = (from a in db.unites_relations.Where(x => x.ratio > 1).Where(x => x.item_id == item.id)
                     join b in db.unites on a.sup_unit equals b.id
                     select new
                     {
                         a.id,
                         a.sup_unit,
                         الوحدة = b.name,
                         عدد_الوحدات = a.ratio
                     }
           ).ToList();
            dgv_subUnits.DataSource = i;
            dgv_subUnits.Columns[1].Visible = false;

        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
       
        private void Items_form_Load_1(object sender, EventArgs e)
        {
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (dgv_subUnits.Rows.Count > 0)
            {
                int id = Convert.ToInt32(dgv_subUnits.CurrentRow.Cells[1].Value.ToString());
                unit_relation = db.unites_relations.Where(u => u.id == id).FirstOrDefault();
                db.unites_relations.DeleteOnSubmit(unit_relation);
                db.SubmitChanges();
                id = Convert.ToInt32(dgvItems.CurrentRow.Cells[0].Value.ToString());
                item = db.items.Where(s => s.id == id).FirstOrDefault();
                GetData();
                Cmb_unites.SelectedValue = db.unites_relations.Where(s => s.item_id == item.id).Where(r => r.ratio == 1).FirstOrDefault().sup_unit;
                var i = (from a in db.unites_relations.Where(x => x.ratio > 1).Where(x => x.item_id == item.id)
                         join b in db.unites on a.sup_unit equals b.id
                         select new
                         {
                             a.id,
                             a.sup_unit,
                             الوحدة = b.name,
                             عدد_الوحدات = a.ratio
                         }
               ).ToList();
                dgv_subUnits.DataSource = i;
                dgv_subUnits.Columns[0].Visible = false;
                dgv_subUnits.Columns[1].Visible = false;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count > 0)
            {
                if (dgvItems.SelectedRows != null)
                {
                    int id = Convert.ToInt32(dgvItems.CurrentRow.Cells[0].Value.ToString());

                    item = db.items.Where(u => u.id == id).FirstOrDefault();
                    if (item.movements.Count > 0)
                    {

                        MessageBox.Show("لا يمكن حذف الصنف حيث تم استخدامه في ععمليات من قبل ومسحه سيؤدي لتلف بعض البيانات");
                        return;
                    }
                    db.items.DeleteOnSubmit(item);
                    db.SubmitChanges();
                    refreshItems();
                    New();
                    btnDelete.Enabled = false;
                }
            }
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                var i = (from a in db.items
                         from c in db.unites_relations.Where(x => x.ratio == 1).Where(x => x.item_id == a.id)
                         join b in db.stores on a.store_id equals b.id
                         join d in db.unites on c.sup_unit equals d.id
                         select new
                         {
                             id = a.id,
                             الاسم = a.name,
                             الوحدة = d.name,
                             المخزن = b.name,
                            حد_الطلب = a.requestLimit,
                             دولاب = a.locker,
                             صف = a.row,
                             رف = a.cell
                         }
                ).ToList();
                dgvItems.DataSource = i;
                dgvItems.Columns[0].Visible = false;
            }
            else
            {
                var i = (from a in db.items
                         from c in db.unites_relations.Where(x => x.ratio == 1).Where(x => x.item_id == a.id)
                         join b in db.stores on a.store_id equals b.id
                         join d in db.unites on c.sup_unit equals d.id
                         where a.name.IndexOf(txtSearch.Text.ToString())>=0
                         select new
                         {
                             id = a.id,
                             الاسم = a.name,
                             الوحدة = d.name,
                             المخزن = b.name,
                             حد_الطلب = a.requestLimit,
                             دولاب = a.locker,
                             صف = a.row,
                             رف = a.cell


                         }
                ).ToList();
                dgvItems.DataSource = i;
                dgvItems.Columns[0].Visible = false;
            }
            foreach (DataGridViewRow r in dgvItems.Rows)
            {
                decimal In = 0;
                decimal Out = 0;
                decimal initial = 0;
                item2 = db.items.Where(t => t.id == Convert.ToInt32(r.Cells[0].Value.ToString())).FirstOrDefault();
                if (item2.movements.Where(cc => cc.movements_header.type == "وارد").Count() > 0)
                {
                    In = db.movements.Where(cc => cc.item_id == item2.id).Where(cc => cc.movements_header.type == "وارد").Sum(a => a.qty);
                }
                if (item2.movements.Where(cc => cc.movements_header.type == "إفتتاحي").Count() > 0)
                {
                    initial = db.movements.Where(cc => cc.item_id == item2.id).Where(cc => cc.movements_header.type == "إفتتاحي").Sum(a => a.qty);
                }
                if (item2.movements.Where(cc => cc.movements_header.type == "صادر").Count() > 0)
                {
                    Out = db.movements.Where(cc => cc.item_id == item2.id).Where(cc => cc.movements_header.type == "صادر").Sum(a => a.qty);
                }


                if (((In + initial) - Out) <= item2.requestLimit)
                {
                    r.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void dgvItems_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            int id = 0;
            if (dgvItems.CurrentRow != null)
            {
                id = Convert.ToInt32(dgvItems.CurrentRow.Cells[0].Value.ToString());
                item = db.items.Where(s => s.id == id).FirstOrDefault();
                GetData();
                Cmb_unites.SelectedValue = db.unites_relations.Where(s => s.item_id == item.id).Where(r => r.ratio == 1).FirstOrDefault().sup_unit;
                var i = (from a in db.unites_relations.Where(x => x.ratio > 1).Where(x => x.item_id == item.id)
                         join b in db.unites on a.sup_unit equals b.id
                         select new
                         {
                             a.id,
                             a.sup_unit,
                             الوحدة = b.name,
                             عدد_الوحدات = a.ratio
                         }
               ).ToList();
                dgv_subUnits.DataSource = i;
                dgv_subUnits.Columns[0].Visible = false;
                dgv_subUnits.Columns[1].Visible = false;
                dgv_subUnits.Columns[2].Visible = false;

                var m = (from a in db.movements.Where(mv => mv.item_id == id).Where(s=> s.movements_header.approved > 0)
                         join v in db.stores on a.movements_header.store_id equals v.id
                         orderby a.movements_header.type
                         select new
                         {
                             رقم_الإذن = a.movements_header.id,
                             الكمية = a.qty,
                             المخزن = v.name,
                             النوع = a.movements_header.type
                         }

                    ).ToList();
                dgvMvt.DataSource = m;
                if(item.movements.Count > 0 )
                {
                    decimal In = 0;
                    decimal Out = 0;
                    decimal initial = 0;
                    if (item.movements.Where(cc => cc.movements_header.type == "وارد").Where(s => s.movements_header.approved > 0).Count() > 0)
                    {
                         In = db.movements.Where(cc => cc.item_id == item.id).Where(cc => cc.movements_header.type == "وارد").Where(s => s.movements_header.approved > 0).Sum(a => a.qty);
                    }
                    if (item.movements.Where(cc => cc.movements_header.type == "إفتتاحي").Where(s => s.movements_header.approved > 0).Count() > 0)
                    {
                        initial = db.movements.Where(cc => cc.item_id == item.id).Where(cc => cc.movements_header.type == "إفتتاحي").Where(s => s.movements_header.approved > 0).Sum(a => a.qty);
                    }
                    if (item.movements.Where(cc => cc.movements_header.type == "صادر").Where(s => s.movements_header.approved > 0).Count() > 0)
                    {
                        Out = db.movements.Where(cc => cc.item_id == item.id).Where(cc => cc.movements_header.type == "صادر").Where(s => s.movements_header.approved > 0).Sum(a => a.qty);
                    }


                    lblQty.Text = ((In + initial) - Out).ToString();
                }
                else
                {
                    lblQty.Text = "0";
                }
            }
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvItems_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                //metroContextMenu1 m = new metroContextMenu1();
                //m.MenuItems.Add(new MenuItem("Cut"));
                //m.MenuItems.Add(new MenuItem("Copy"));
                //m.MenuItems.Add(new MenuItem("Paste"));
                ContextMenuStrip x = new ContextMenuStrip();
                int currentMouseOverRow = dgvItems.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow > 0)
                {
                    //MessageBox.Show(currentMouseOverRow.ToString());

                    //metroContextMenu1.Items.Add(string.Format("تعديل بيانات الصنف", currentMouseOverRow.ToString()));
                    metroContextMenu1.Show(dgvItems, new Point(e.X, e.Y));
                }
                else
                {
                    metroContextMenu1.Hide();
                }




            }
        }

        private void wToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("تعديل");
            getSelectedRows();
        }
        void getSelectedRows()
        {
            Int32 selectedRowCount =
            dgvItems.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    sb.Append("Row: ");
                    sb.Append(dgvItems.SelectedRows[i].Index.ToString());
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Total: " + selectedRowCount.ToString());
                MessageBox.Show(sb.ToString(), "Selected Rows");
            }
        }
    }

    
}
