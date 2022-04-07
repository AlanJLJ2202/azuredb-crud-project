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
    public partial class frmNArea : DevExpress.XtraEditors.XtraForm
    {
        private int idArea = 0;
        public frmNArea()
        {
            InitializeComponent();
            CenterToScreen();
        }

        //crear otro constructor
        public frmNArea(int idArea) 
        {
            InitializeComponent();
            this.idArea = idArea;
            Area area = new Area() { idArea = this.idArea }.GetById();
            CenterToScreen();
            txtNombre.Text = area.nombre;
            txtDescripcion.Text = area.descripcion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }

            if (idArea > 0)
            {
                if (new Area()
                {
                    idArea = idArea,
                    nombre = txtNombre.Text,
                    descripcion = txtDescripcion.Text
                }.Update() > 0)
                {
                    XtraMessageBox.Show("Area actualizada correctamente", "Areas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (new Area()
                {
                    nombre = txtNombre.Text,
                    descripcion = txtDescripcion.Text
                }.Add() > 0)
                {
                    XtraMessageBox.Show("Area almacenada correctamente", "Areas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                    //Close();
                }
            }
        }

        public void Clean()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Focus();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                XtraMessageBox.Show("Solo se permiten letras", "Precaucion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                XtraMessageBox.Show("Solo se permiten letras", "Precaucion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}