using DAL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV_Dev
{
    public partial class frmArea : DevExpress.XtraEditors.XtraForm
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void frmArea_Load(object sender, EventArgs e)
        {
            areaBindingSource.DataSource = new Area().GetAll();
            gvAreas.BestFitColumns();
        }
    }
}