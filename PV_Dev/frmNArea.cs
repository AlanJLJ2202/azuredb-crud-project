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
        }

        //crear otro constructor
        public frmNArea(int idArea) 
        {
            InitializeComponent();
            this.idArea = idArea;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idArea > 0)
            {
                if (new Area
                {
                    idArea = this.idArea,
                    nombre = txtNombre.Text,
                    descripcion = txtDescripcion.Text
                }.Update() > 0)
                {
                    XtraMessageBox.Show("Area Actualizada correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            else 
            {
                if (new Area
                {
                    nombre = txtNombre.Text,
                    descripcion = txtDescripcion.Text
                }.Add() > 0) 
                {
                    XtraMessageBox.Show("Area almacenada correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }
    }
}