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
    public partial class frmColaborador : DevExpress.XtraEditors.XtraForm
    {
        public frmColaborador()
        {
            InitializeComponent();
        }

        private void frmColaborador_Load(object sender, EventArgs e)
        {
           colaboradorBindingSource.DataSource = new Colaborador().GetAll();
           areaBindingSource.DataSource = new Area().GetAll();
           sucursalBindingSource.DataSource = new Sucursal().GetAll();
           gvColaborador.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            areaBindingSource.DataSource = new Area().GetAll();
            sucursalBindingSource.DataSource = new Sucursal().GetAll();
            colaboradorBindingSource.DataSource = new Colaborador().GetAll();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmNColaborador))
                {
                    form.Activate();
                    return;
                }
            new frmNColaborador { Text = "Colaboradores" }.Show();
            btnActualizar.PerformClick();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNColaborador((int)gvColaborador.GetFocusedRowCellValue("idColaborador")) { Text = "Colaboradores" }.ShowDialog();
            btnActualizar.PerformClick();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idColaborador = (int)gvColaborador.GetFocusedRowCellValue("idColaborador");

            if (new Colaborador()
            {
                idColaborador = idColaborador
            }.Delete() > 0)
            {
                XtraMessageBox.Show("Colaborador eliminado correctamente", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnActualizar.PerformClick();
            }
            else
                XtraMessageBox.Show("No se eliminó correctamente", "Error 404",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmColaborador_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (XtraMessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //{
              //  e.Cancel = true;
            //}
        }
    }
}