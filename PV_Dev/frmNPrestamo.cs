using DAL;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PV_Dev
{
    public partial class frmNPrestamo : DevExpress.XtraEditors.XtraForm
    {
        private int idPrestamo = 0;
        public frmNPrestamo()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public frmNPrestamo(int idPrestamo)
        {
            InitializeComponent();
            this.idPrestamo = idPrestamo;
            Prestamo prestamo = new Prestamo() { idPrestamo = this.idPrestamo }.GetById();
            CenterToScreen();
            cmbSocio.EditValue = prestamo.idSocio;
            txtMonto.Text = prestamo.monto.ToString();
            txtTasaInteres.Text = prestamo.tasaInteres.ToString();
            txtFecha.Text = prestamo.fecha.ToString();
        }

        private void frmNPrestamo_Load(object sender, EventArgs e)
        {
            socioBindingSource.DataSource = new Socio().GetAll();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbSocio.Text) || string.IsNullOrEmpty(txtMonto.Text) || string.IsNullOrEmpty(txtTasaInteres.Text))
            {

                XtraMessageBox.Show("Debe completar la informacion", "Error 404");

                return;
            }

            if (idPrestamo > 0)
            {
                if (new Prestamo()
                {
                    idPrestamo = idPrestamo,
                    idSocio = (int)cmbSocio.EditValue,
                    monto = decimal.Parse(txtMonto.Text),
                    tasaInteres = decimal.Parse(txtTasaInteres.Text),
                    fecha = DateTime.Parse(txtFecha.Text)

                }.Update() > 0)
                {
                    XtraMessageBox.Show("Prestamo modificado correctamente", "Prestamos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }
            else
            {
                if (new Prestamo()
                {
                    idSocio = (int)cmbSocio.EditValue,
                    monto = decimal.Parse(txtMonto.Text),
                    tasaInteres = decimal.Parse(txtTasaInteres.Text),
                    fecha = DateTime.Parse(txtFecha.Text)
                }.Add() > 0)
                {
                    XtraMessageBox.Show("Prestamo almacenado correctamente", "Prestamos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }
        }
        public void Clean()
        {
            cmbSocio.EditValue = "";
            txtMonto.Text = "";
            txtTasaInteres.Text = "";
            txtFecha.Text = "";
            txtMonto.Focus();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                XtraMessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtTasaInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                XtraMessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}