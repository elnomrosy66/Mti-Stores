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
    public partial class Home_form : MetroFramework.Forms.MetroForm
    {
        DAL.user user = new DAL.user();
        DAL.dbDataContext db = new DAL.dbDataContext();
        public Home_form()
        {
            InitializeComponent();
        }

        private void Home_form_Load(object sender, EventArgs e)
        {
            int user_id = Properties.Settings.Default.user_id;
            user = db.users.Where(a => a.id == user_id).FirstOrDefault();
            if (user.type == "user")
            {
                إدارةالأصنافToolStripMenuItem.Enabled = false;
                إدارةالمخازنToolStripMenuItem.Enabled = false;
                واردToolStripMenuItem.Enabled = false;
                المستخدمونToolStripMenuItem.Enabled = false;
                التقاريرToolStripMenuItem.Enabled = false;
                المخازنToolStripMenuItem.Enabled = false;
            }
            if (user.type == "admin")
            {
                المستخدمونToolStripMenuItem.Enabled = false;
                واردToolStripMenuItem.Enabled = true;
                المخازنToolStripMenuItem.Enabled = true;
            }
            if (user.type == "superAdmin")
            {
                واردToolStripMenuItem.Enabled = true;
                المخازنToolStripMenuItem.Enabled = true;
            }
            if (user.type == "supervisor")
            {
            }
        }

        private void الأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Items_form frm = new Items_form();
            frm.ShowDialog();
        }

        private void المخازنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stores_form frm = new Stores_form();
            frm.ShowDialog();
        }

        private void الوحداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unites_form frm = new Unites_form();
            frm.ShowDialog();
        }

        private void واردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movements_form frm = new Movements_form();
            frm.ShowDialog();
        }

        private void عرضالأذوناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movements_show_form frm = new movements_show_form();
            frm.ShowDialog();
        }

        private void Home_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Home_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void المستخدمونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUserForm frm = new addUserForm();
            frm.ShowDialog();
        }

        private void الاصنافالنشطهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //reportItemsRate frm = new reportItemsRate();
            //    frm.ShowDialog();
            reports frm = new reports();
            getActiveItems rpt = new getActiveItems();
            //MvtRpt rpt2 = new MvtRpt();
            //rpt2.SetDataSource(db.mvtReport(2));
            // Set datasource first
            //rpt.SetParameterValue("@start", DateTime.Today);
            //rpt.SetParameterValue("@end", DateTime.Today);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void جردالمخازنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports frm = new reports();
            allStoresNoWatermark rpt = new allStoresNoWatermark();
            //MvtRpt rpt2 = new MvtRpt();
            //rpt2.SetDataSource(db.mvtReport(2));
            // Set datasource first
            //rpt2.SetParameterValue("@id", movement_header.id);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void تقريرجردمخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectStoreForm frm = new selectStoreForm();
            frm.ShowDialog();
        }

        private void تسجيلخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
            
        }

        private void الدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm frm = new loginForm();
            frm.ShowDialog();
        }
    }
}
