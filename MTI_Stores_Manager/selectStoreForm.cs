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
   
    public partial class selectStoreForm : MetroFramework.Forms.MetroForm
    {
        DAL.dbDataContext db = new DAL.dbDataContext();
        DAL.store store;
        public selectStoreForm()
        {
            InitializeComponent();
        }

        private void selectStoreForm_Load(object sender, EventArgs e)
        {
            Cmb_stores.DataSource = db.stores;
            Cmb_stores.ValueMember = "id";
            Cmb_stores.DisplayMember = "name";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            reports frm = new reports();
            storeItemNoWatermark rpt = new storeItemNoWatermark();
            //MvtRpt rpt2 = new MvtRpt();
            //rpt2.SetDataSource(db.mvtReport(2));
            // Set datasource first
            
            rpt.SetParameterValue("@store_id", Cmb_stores.SelectedValue);
            //rpt.Refresh();
            frm.crystalReportViewer1.ReportSource = rpt;
            //frm.crystalReportViewer1.RefreshReport();
            frm.ShowDialog();
        }
    }
}
