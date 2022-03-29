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
    public partial class frmSucursal : DevExpress.XtraEditors.XtraForm
    {
        public frmSucursal()
        {
            InitializeComponent();
        }

        private void frmSucursal_Load(object sender, EventArgs e)
        {
            sucursalBindingSource.DataSource = new Sucursal().GetAll();
            gvSucursal.BestFitColumns();
        }
    }
}