using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmUsuario))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando detalles de Usuarios...");
            new frmUsuario { MdiParent = this }.Show();
            SplashScreenManager.CloseForm();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSucursal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmSucursal))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando detalles de Sucursales...");
            new frmSucursal { MdiParent = this }.Show();
            SplashScreenManager.CloseForm();
        }

        private void btnSocio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmSocio))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando detalles de Socios...");
            new frmSocio { MdiParent = this }.Show();
            SplashScreenManager.CloseForm();


        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAhorro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmAhorro))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando detalles de Ahorros...");
            new frmAhorro { MdiParent = this }.Show();
            SplashScreenManager.CloseForm();
        }

        private void btnArea_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmArea))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando detalles de Areas...");
            new frmArea { MdiParent = this }.Show();
            SplashScreenManager.CloseForm();
        }

        private void btnColaborador_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmColaborador))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando detalles de Colaboradores...");
            new frmColaborador { MdiParent = this }.Show();
            SplashScreenManager.CloseForm();
        }

        private void btnPrestamo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmPrestamo))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando detalles de Prestamos...");
            new frmPrestamo { MdiParent = this }.Show();
            SplashScreenManager.CloseForm();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
              e.Cancel = true;
            }
        }
    }
}