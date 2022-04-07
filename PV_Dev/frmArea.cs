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
        private int idArea = 0;
        public frmArea()
        {
            InitializeComponent();
        }

        private void frmArea_Load(object sender, EventArgs e)
        {
            areaBindingSource.DataSource = new Area().GetAll();
            gvAreas.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmNArea))
                {
                    form.Activate();
                    return;
                }
            new frmNArea { Text = "Areas" }.Show();
            btnActualizar.PerformClick();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNArea((int)gvAreas.GetFocusedRowCellValue("idArea")) { Text = "Modificar area" }.ShowDialog();
            btnActualizar.PerformClick();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            areaBindingSource.DataSource = new Area().GetAll();
            gvAreas.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idArea = (int)gvAreas.GetFocusedRowCellValue("idArea");

            if (new Area()
            {
                idArea = idArea
            }.Delete() > 0)
            {
                XtraMessageBox.Show("Area eliminada correctamente", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnActualizar.PerformClick();
            }
            else
                XtraMessageBox.Show("No se eliminó correctamente", "Error 404",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmArea_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (XtraMessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //{
              //  e.Cancel = true;
            //}
        }
    }
}