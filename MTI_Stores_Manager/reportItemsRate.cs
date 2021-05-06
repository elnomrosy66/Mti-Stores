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
    public partial class reportItemsRate : MetroFramework.Forms.MetroForm
    {
        DAL.dbDataContext db = new DAL.dbDataContext();
        DAL.item item;
        DAL.movement movement;
        public reportItemsRate()
        {
            InitializeComponent();
        }

        private void reportItemsRate_Load(object sender, EventArgs e)
        {
            var i = db.movements.GroupBy(r => r.item_id).Select(g => new
            {
                id = g.Key,
                qty = g.Sum(t => t.qty)

            }).OrderByDescending(y => y.qty).ToList();

            var x = from m in db.movements
                    join n in db.items on m.item_id equals n.id
                    orderby m descending
                    group m by m.item into g 

                    select new
                    {
                        id = g.Key.id,
                        qty = g.Where(o => o.movements_header.type == "وارد").Sum(u => (double?)u.qty),
                        name = g.Select(r => r.item.name).First()
                       
                    };
            foreach(var obj in x)
            {
                if(obj.qty == null)
                {
                    double y = 0;
                   // obj.qty = y;
                }
            }
            dgvItems.DataSource = x;
            this.reportViewer1.RefreshReport();
        }
    }
}
