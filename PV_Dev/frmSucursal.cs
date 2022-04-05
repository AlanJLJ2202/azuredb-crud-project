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
            CenterToScreen();
        }

        private void frmSucursal_Load(object sender, EventArgs e)
        {
            sucursalBindingSource.DataSource = new Sucursal().GetAll();
            gvSucursal.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sucursalBindingSource.DataSource = new Sucursal().GetAll();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmNSucursal))
                {
                    form.Activate();
                    return;
                }
            new frmNSucursal { Text = "Sucursales" }.Show();
            btnActualizar.PerformClick();
        }

        private void frmSucursal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNSucursal((int)gvSucursal.GetFocusedRowCellValue("idSucursal")) { Text = "Sucursales" }.ShowDialog();
            btnActualizar.PerformClick();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idSucursal = (int)gvSucursal.GetFocusedRowCellValue("idSucursal");

            if (new Sucursal()
            {
                idSucursal = idSucursal
            }.Delete() > 0)
            {
                XtraMessageBox.Show("Sucursal eliminada correctamente", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnActualizar.PerformClick();
            }
            else
                XtraMessageBox.Show("No se eliminó correctamente", "Error 404",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}