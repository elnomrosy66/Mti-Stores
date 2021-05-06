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
    public partial class movements_show_form : MetroFramework.Forms.MetroForm
    {
        DAL.movement movement = new DAL.movement();
        DAL.movements_header movement_header = new DAL.movements_header();
        DAL.dbDataContext db = new DAL.dbDataContext();
        DAL.user user = new DAL.user();
        int approved =1;
        public movements_show_form()
        {
            InitializeComponent();
        }

        private void movements_show_form_Load(object sender, EventArgs e)
        {
            try
            {
                var i = (from a in db.movements_headers
                         join b in db.stores on a.store_id equals b.id
                         select new
                         {
                             id = a.id,
                             رقم_الإذن = a.number,
                             النوع = a.type,
                             المخزن = b.name,
                             الجهة = a.place,
                             الصارف = a.reciever,
                             التاريخ = a.date,
                             الحالة = a.approved
                         }
                );
                dgvMvtHeader.DataSource = i;
                Cmb_types.SelectedIndex = 0;
                dgvMvtHeader.Columns[0].Visible = false;
                dgvMvtHeader.Columns[1].Width = 60;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void dgvMvtHeader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = 0;
                if (dgvMvtHeader.CurrentRow.Cells[0].Value != null)
                {
                    id = Convert.ToInt32(dgvMvtHeader.CurrentRow.Cells[0].Value.ToString());
                    movement_header = db.movements_headers.Where(r => r.id == id).FirstOrDefault();
                    if (movement_header.approved == 0)
                    {
                        btnAccept.Enabled = true;
                    }
                    else
                    {
                        btnAccept.Enabled = false;
                    }
                }
                var m = (from a in db.movements.Where(x => x.mvt_id == id)
                         join b in db.unites on a.unit_id equals b.id
                         join c in db.items on a.item_id equals c.id
                         select new
                         {
                             الصنف = c.name,
                             الكمية = a.qty,
                             الوحدة = b.name
                         }
                    );
                dgvMovements.DataSource = m;
                btnPrint.Enabled = true;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int user_id = Properties.Settings.Default.user_id;
            user = db.users.Where(a => a.id == user_id).FirstOrDefault();
            if (user.type == "user")
            {
                if (dgvMovements.Rows.Count > 0)
                {
                    int id = 0;
                    if (dgvMvtHeader.CurrentRow.Cells[0].Value != null)
                    {
                        id = Convert.ToInt32(dgvMvtHeader.CurrentRow.Cells[0].Value.ToString());
                        movement_header.approved = 1;
                        movement_header.userApproved = user.id;
                        db.SubmitChanges();
                        MessageBox.Show("تم قبول الطلب بنجاح");
                        btnAccept.Enabled = false;
                    }
                }

            }
            else
            {
                MessageBox.Show("عفوا ! لا يمتلك هذا المستخدم صلاحية قبول الطلبات");
            }
           
        }

        private void Cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void place_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
           // set the null values

            int number = 0;
            if (txtSearch.Text.Trim() != string.Empty) //number exist
            {
                
                if (Cmb_types.SelectedItem.ToString() == "تحت الطلب")// تحت الطلب -  برقم الاذن
                {
                    number = Convert.ToInt32(txtSearch.Text.ToString());
                    var i = (from a in db.movements_headers.Where(u => u.number == number).Where(b => b.approved == approved).Where(f => f.date >= DFrom.Value).Where(o => o.date <= DTo.Value)
                             join b in db.stores on a.store_id equals b.id
                             select new
                             {
                                 id = a.id,
                                 رقم_الإذن = a.number,
                                 النوع = a.type,
                                 المخزن = b.name,
                                 الجهة = a.place,
                                 الصارف = a.reciever,
                                 التاريخ = a.date,
                                 الحالة = a.approved
                             }
                  );
                    dgvMvtHeader.DataSource = i;
                    dgvMvtHeader.Columns[0].Visible = false;
                    dgvMvtHeader.Columns[1].Width = 60;
                    if (dgvMvtHeader.Rows.Count == 0)
                    {
                        MessageBox.Show("لايوجد بيانات خلال هذه الفترة");
                    }
                    dgvMovements.DataSource = null;
                    return;
                }

                else // مش تحت الطلب -  برقم
                {
                    //MessageBox.Show(Cmb_types.SelectedItem.ToString());
                    //return;
                    number = Convert.ToInt32(txtSearch.Text.ToString());
                    var i = (from a in db.movements_headers.Where(u => u.number == number).Where(b => b.type == Cmb_types.SelectedItem.ToString()).Where(ap => ap.approved == approved).Where(f => f.date >= DFrom.Value).Where(o => o.date <= DTo.Value)
                             join b in db.stores on a.store_id equals b.id
                             select new
                             {
                                 id = a.id,
                                 رقم_الإذن = a.number,
                                 النوع = a.type,
                                 المخزن = b.name,
                                 الجهة = a.place,
                                 الصارف = a.reciever,
                                 التاريخ = a.date,
                                 الحالة = a.approved
                             }
                     );
                    dgvMvtHeader.DataSource = i;
                    dgvMvtHeader.Columns[0].Visible = false;
                    dgvMvtHeader.Columns[1].Width = 60;
                    if (dgvMvtHeader.Rows.Count == 0)
                    {
                        MessageBox.Show("لايوجد بيانات خلال هذه الفترة");
                    }
                    dgvMovements.DataSource = null;
                    return;
                }
        }

            
            else // no number exist
            {
                if (Cmb_types.SelectedItem.ToString() == "تحت الطلب")
                {
                    var i = (from a in db.movements_headers.Where(b => b.approved == approved).Where(f => f.date >= DFrom.Value).Where(o => o.date <= DTo.Value)
                             join b in db.stores on a.store_id equals b.id
                             select new
                             {
                                 id = a.id,
                                 رقم_الإذن = a.number,
                                 النوع = a.type,
                                 المخزن = b.name,
                                 الجهة = a.place,
                                 الصارف = a.reciever,
                                 التاريخ = a.date,
                                 الحالة = a.approved
                             });

                    dgvMvtHeader.DataSource = i;
                    dgvMvtHeader.Columns[0].Visible = false;
                    dgvMvtHeader.Columns[1].Width = 60;
                    if (dgvMvtHeader.Rows.Count == 0)
                    {
                        MessageBox.Show("لايوجد بيانات خلال هذه الفترة");
                    }
                    dgvMovements.DataSource = null;
                    return;
                }
                else
                {
                    var i = (from a in db.movements_headers.Where(b => b.type == Cmb_types.SelectedItem.ToString()).Where(ap => ap.approved == approved).Where(f => f.date >= DFrom.Value).Where(o => o.date <= DTo.Value)
                             join b in db.stores on a.store_id equals b.id
                             select new
                             {
                                 id = a.id,
                                 رقم_الإذن = a.number,
                                 النوع = a.type,
                                 المخزن = b.name,
                                 الجهة = a.place,
                                 الصارف = a.reciever,
                                 التاريخ = a.date,
                                 الحالة = a.approved
                             }
                        );
                    dgvMvtHeader.DataSource = i;
                    dgvMvtHeader.Columns[0].Visible = false;
                    dgvMvtHeader.Columns[1].Width = 60;
                    if (dgvMvtHeader.Rows.Count == 0)
                    {
                        MessageBox.Show("لايوجد بيانات خلال هذه الفترة");
                    }
                    dgvMovements.DataSource = null;
                    return;
                }
            }
            
        }
 

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            var i = (from a in db.movements_headers
                     join b in db.stores on a.store_id equals b.id
                     select new
                     {
                         id = a.id,
                         رقم_الإذن = a.number,
                         النوع = a.type,
                         المخزن = b.name,
                         الجهة = a.place,
                         الصارف = a.reciever,
                         التاريخ = a.date,
                         الحالة = a.approved
                     }
                );
            dgvMvtHeader.DataSource = i;
            Cmb_types.SelectedIndex = 0;
            dgvMvtHeader.Columns[0].Visible = false;
            dgvMvtHeader.Columns[1].Width = 60;
            if (dgvMvtHeader.Rows.Count == 0)
            {
                MessageBox.Show("لايوجد بيانات خلال هذه الفترة");
            }
            dgvMovements.DataSource = null;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            reports frm = new reports();
            MvtRpt rpt = new MvtRpt();
            MvtRpt rpt2 = new MvtRpt();
            //rpt2.SetDataSource(db.mvtReport(2));
            // Set datasource first
            rpt2.SetParameterValue("@id", movement_header.id);
            frm.crystalReportViewer1.ReportSource = rpt2;
            frm.ShowDialog();
            btnPrint.Enabled = false;
        }

        private void dgvMvtHeader_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex].Name == "الحالة" &&
                e.RowIndex >= 0 &&
                dgv["الحالة", e.RowIndex].Value is int)
            {
                switch ((int)dgv["الحالة", e.RowIndex].Value)
                {
                    case 0:
                        e.Value = "تحت لطلب";
                        e.FormattingApplied = true;
                        break;
                    case 1:
                        e.Value = "تم الصرف";
                        e.FormattingApplied = true;
                        break;
                }
            }
        }

        private void rbtAapproved_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtAapproved.Checked == true)
            {
                approved = 1;
            }
            if (rptPinding.Checked == true)
            {
                approved = 0;
            }
        }
        void getSelectedRows()
        {
            Int32 selectedRowCount =
            dgvMovements.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    sb.Append("Row: ");
                    sb.Append(dgvMovements.SelectedRows[i].Index.ToString());
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Total: " + selectedRowCount.ToString());
                MessageBox.Show(sb.ToString(), "Selected Rows");
            }
        }
    }
}
