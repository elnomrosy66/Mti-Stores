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
    public partial class Movements_form : MetroFramework.Forms.MetroForm
    {
        DAL.dbDataContext db = new DAL.dbDataContext();
        DAL.movement movement;
        DAL.movements_header movement_header;
        DAL.store store;
        DAL.item item;
        DAL.unite unit;
        public Movements_form()
        {
            InitializeComponent();
            New();
        }

        void GetData()
        {
            Cmb_stores.DataSource = db.stores;
            Cmb_stores.ValueMember = "id";
            Cmb_stores.DisplayMember = "name";
            Cmb_items.DataSource = db.items.Where(i => i.store_id == Convert.ToInt32(Cmb_stores.SelectedValue)).ToList();
            Cmb_items.ValueMember = "id";
            Cmb_items.DisplayMember = "name";
            var units = (from a in db.items.Where(s => s.id == Convert.ToInt32(Cmb_items.SelectedValue))
                     join b in db.unites_relations on a.id equals b.item_id
                     join c in db.unites on b.sup_unit equals c.id
                     select new
                     {
                         id = c.id,
                         name = c.name
                     }
                );
            Cmb_unites.DataSource = units;
            Cmb_unites.ValueMember = "id";
            Cmb_unites.DisplayMember = "name";
            if (db.movements.FirstOrDefault() == null)
            {
                Mvt_number.Text = "1";
            }
            else
            {
                Mvt_number.Text = (db.movements_headers.Max(u => u.id)).ToString();
            }
            
        }
        void New()
        {
            movement = new DAL.movement();
            movement_header = new DAL.movements_header();
            GetData();
            DataTable d = new DataTable();
            dgvItems.DataSource = d;
            dgvItems.DataSource = null;
            Cmb_type.SelectedIndex = 0;
            
        }

         void SetData()
        {
            movement_header.store_id = Convert.ToInt32(Cmb_stores.SelectedValue.ToString());
            movement_header.place = place.Text;
            movement_header.reciever = reciever.Text;
            movement_header.date = date.Value;
            movement_header.user_id = 3;
            movement_header.type = Cmb_type.SelectedItem.ToString();
            if (Cmb_type.SelectedItem.ToString() == "صادر")
            {
                if (db.movements_headers.Where(r => r.type == "صادر").Count() == 0)
                {
                    movement_header.number = 1;
                }
                else
                {
                    movement_header.number = (db.movements_headers.Where(r => r.type == "صادر").Max(p => p == null ? 0 : p.number)) + 1;
                }

            }
            if (Cmb_type.SelectedItem.ToString() == "وارد")
            {
                if (db.movements_headers.Where(r => r.type == "وارد").Count() == 0)
                {
                    movement_header.number = 1;
                }
                else
                {
                    movement_header.number = (db.movements_headers.Where(r => r.type == "وارد").Max(p => p == null ? 0 : p.number)) + 1;
                }

            }
            if (Cmb_type.SelectedItem.ToString() == "إفتتاحي")
            {
                if(db.movements_headers.Where(r => r.type == "إفتتاحي").Count() == 0)
                {
                    movement_header.number = 1;
                }
                else
                {
                    movement_header.number = (db.movements_headers.Where(r => r.type == "إفتتاحي").Max(p => p == null ? 0 : p.number)) + 1;
                }
            }
        }

        void save()
        {
            if (Cmb_stores.SelectedValue == null)
            {
                MessageBox.Show("الرجاء اختيار مخزن");
                return;
            }
             var db = new DAL.dbDataContext();

            if (movement_header.id == 0)
            {
                movement_header = new DAL.movements_header();
                db.movements_headers.InsertOnSubmit(movement_header);
                SetData();
                db.SubmitChanges();
            }
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                movement = new DAL.movement();
                movement.movements_header = movement_header;
                movement.item_id = Convert.ToInt32(row.Cells["item_id"].Value);
                movement.unit_id = Convert.ToInt32(row.Cells["unit_id"].Value);
                movement.qty = Convert.ToDecimal(row.Cells["qty"].Value);
                //movement.qty_unit = Convert.ToDecimal(row.Cells["unit_qty"].Value);
                db.movements.InsertOnSubmit(movement);
                db.SubmitChanges();
            }
            MessageBox.Show("تم الحفظ بنجاح");
            New();
        }
        private void Movements_form_Load(object sender, EventArgs e)
        {
            
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Mvt_number.Text.ToString() == "" || Cmb_stores.Text.ToString() == null || place.Text.ToString() == "" || reciever.Text.ToString() == "")
            {
                MessageBox.Show("لم يتم ادخال بيانات الأذن كاملة الرجاء مراجعة البيانات");
                return;
            }
            save();
        }

        private void Cmb_stores_SelectionChangeCommitted(object sender, EventArgs e)
        {


            Cmb_items.DataSource = db.items.Where(s => s.store.id == Convert.ToInt32(Cmb_stores.SelectedValue));
        }

        private void Cmb_items_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void Cmb_items_SelectedValueChanged(object sender, EventArgs e)
        {
            var i = (from a in db.items.Where(s => s.id == Convert.ToInt32(Cmb_items.SelectedValue))
                     join b in db.unites_relations on a.id equals b.item_id
                     join c in db.unites on b.sup_unit equals c.id
                     select new
                     {
                         id = c.id,
                         name = c.name
                     }
                );
            Cmb_unites.DataSource = i;

            //Cmb_unites.DisplayMember = "item_id";
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {

            if (Cmb_items.SelectedItem == null)
            {
                MessageBox.Show("لم يتم اختيار صنف محدد");
                return;
            }
            if (Cmb_stores.SelectedItem == null)
            {
                MessageBox.Show("لم يتم اختيار مخزن محدد");
                return;
            }

            if (Txt_qty.Value <= 0)
            {
                MessageBox.Show("الكمية يجب ان تكون اكبر من صفر");
                return;
            }
            item = db.items.Where(w => w.id == Convert.ToInt32(Cmb_items.SelectedValue.ToString())).FirstOrDefault() ;
            decimal unit_ratio = item.unites_relations.Where(a => a.sup_unit == Convert.ToInt32(Cmb_unites.SelectedValue.ToString())).FirstOrDefault().ratio;
            decimal In  = 0;
            decimal Out = 0;
            decimal old = 0;
            string item_id = "";
            string store_id = "";
            string unit_id = "";
            decimal qty = 0;
            if (item.movements.Where(cc => cc.movements_header.type == "وارد").Where(s => s.movements_header.approved > 0).Count() > 0)
            {
                In =Convert.ToDecimal(db.movements.Where(cc => cc.item_id == item.id).Where(cc => cc.movements_header.type == "وارد").Where(s => s.movements_header.approved > 0).Sum(a => a.qty ));
            }
            if (item.movements.Where(cc => cc.movements_header.type == "صادر").Where(s => s.movements_header.approved > 0).Count() > 0)
            {
                Out = db.movements.Where(cc => cc.item_id == item.id).Where(cc => cc.movements_header.type == "صادر").Where(s => s.movements_header.approved > 0).Sum(a => a.qty);
            }
            if (item.movements.Where(cc => cc.movements_header.type == "إفتتاحي").Where(s => s.movements_header.approved > 0).Count() > 0)
            {
                In += db.movements.Where(cc => cc.item_id == item.id).Where(cc => cc.movements_header.type == "إفتتاحي").Where(s => s.movements_header.approved > 0).Sum(a => a.qty);
            }
            decimal qtyExist = (In - Out);

            if ((Txt_qty.Value * unit_ratio) > qtyExist && Cmb_type.SelectedItem.ToString() == "صادر")
            {
                MessageBox.Show("الكمية المطلوبة غير متاحة في المخزن");
                return;
            }
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.Cells[3].Value.ToString() == Cmb_items.SelectedValue.ToString())
                {
                    DialogResult dialog = MessageBox.Show("تم إضافة هذا الصنف مسبقاً هل تريد تعديل الكمية المضافة", "", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes) //yes
                    {
                        item_id = Cmb_items.SelectedValue.ToString();
                        store_id = Cmb_stores.SelectedValue.ToString();
                        unit_id = Cmb_unites.SelectedValue.ToString();
                        qty = Txt_qty.Value;                        
                        row.Cells[0].Value = dgvItems.Rows.Count;
                        row.Cells["store_id"].Value = store_id;
                        row.Cells["unit_id"].Value = unit_id;
                        row.Cells["item_id"].Value = item_id;
                        row.Cells["item_name"].Value = Cmb_items.Text;
                        row.Cells["unit_name"].Value = Cmb_unites.Text;
                        row.Cells["qty"].Value = qty;
                        row.Cells["unit_qty"].Value = (qty * unit_ratio);
                        return;
                    }
                    else // no
                    {
                        return;
                    }
                    
                }

            }

             item_id = Cmb_items.SelectedValue.ToString();
             store_id = Cmb_stores.SelectedValue.ToString();
             unit_id = Cmb_unites.SelectedValue.ToString();
             qty = Txt_qty.Value;
            
            dgvItems.Rows.Add(1);
            int rowindex = dgvItems.Rows.Count - 1;
            dgvItems.Rows[rowindex].Cells[0].Value = dgvItems.Rows.Count;
            dgvItems.Rows[rowindex].Cells["store_id"].Value = store_id ;
            dgvItems.Rows[rowindex].Cells["unit_id"].Value = unit_id;
            dgvItems.Rows[rowindex].Cells["item_id"].Value = item_id;
            dgvItems.Rows[rowindex].Cells["item_name"].Value = Cmb_items.Text ;
            dgvItems.Rows[rowindex].Cells["unit_name"].Value = Cmb_unites.Text;
            dgvItems.Rows[rowindex].Cells["qty"].Value = qty;
            dgvItems.Rows[rowindex].Cells["unit_qty"].Value = (qty * unit_ratio);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count >= 1)
            {
                int index = dgvItems.SelectedRows[0].Index;

                dgvItems.Rows.RemoveAt(index);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            New();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (Mvt_number.Text.ToString() == "" || Cmb_stores.Text.ToString() == null || place.Text.ToString() == "" || reciever.Text.ToString() == "")
            {
                MessageBox.Show("لم يتم ادخال بيانات الأذن كاملة الرجاء مراجعة البيانات");
                return;
            }
            save();
            reports frm = new reports();
            MvtRpt rpt = new MvtRpt();
            MvtRpt rpt2 = new MvtRpt();
            //rpt2.SetDataSource(db.mvtReport(2));
            // Set datasource first
            rpt2.SetParameterValue("@id", movement_header.id);
            frm.crystalReportViewer1.ReportSource = rpt2;
            frm.ShowDialog();
           // btnPrint.Enabled = false;
        }
    }
}
