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
    public partial class frmUsuario : DevExpress.XtraEditors.XtraForm
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = new Usuario().GetAll();
            gvUsuarios.BestFitColumns();
        }
    }
}