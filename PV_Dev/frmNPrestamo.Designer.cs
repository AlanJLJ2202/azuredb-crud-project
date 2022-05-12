
namespace PV_Dev
{
    partial class frmNPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNPrestamo));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtCalendar = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtTasaInteres = new DevExpress.XtraEditors.TextEdit();
            this.txtMonto = new DevExpress.XtraEditors.TextEdit();
            this.cmbSocio = new DevExpress.XtraEditors.LookUpEdit();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.calendarControl = new DevExpress.XtraEditors.Controls.CalendarControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalendar.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalendar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaInteres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSocio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
<<<<<<< HEAD
            this.groupControl1.Controls.Add(this.txtCalendar);
=======
            this.groupControl1.Controls.Add(this.calendarControl);
            this.groupControl1.Controls.Add(this.txtFecha);
>>>>>>> 36be0efe60d949b0c686cdec8ea878e886347aaa
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.btnCancelar);
            this.groupControl1.Controls.Add(this.btnGuardar);
            this.groupControl1.Controls.Add(this.txtTasaInteres);
            this.groupControl1.Controls.Add(this.txtMonto);
            this.groupControl1.Controls.Add(this.cmbSocio);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
<<<<<<< HEAD
            this.groupControl1.Size = new System.Drawing.Size(410, 338);
=======
            this.groupControl1.Size = new System.Drawing.Size(752, 433);
>>>>>>> 36be0efe60d949b0c686cdec8ea878e886347aaa
            this.groupControl1.TabIndex = 0;
            // 
            // txtCalendar
            // 
<<<<<<< HEAD
            this.txtCalendar.EditValue = null;
            this.txtCalendar.Location = new System.Drawing.Point(183, 201);
            this.txtCalendar.Name = "txtCalendar";
            this.txtCalendar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCalendar.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCalendar.Size = new System.Drawing.Size(198, 26);
            this.txtCalendar.TabIndex = 9;
=======
            this.txtFecha.EditValue = "xxxx/xx/xx";
            this.txtFecha.Location = new System.Drawing.Point(486, 392);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFecha.Size = new System.Drawing.Size(154, 22);
            this.txtFecha.TabIndex = 4;
>>>>>>> 36be0efe60d949b0c686cdec8ea878e886347aaa
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
<<<<<<< HEAD
            this.labelControl4.Location = new System.Drawing.Point(24, 200);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
=======
            this.labelControl4.Location = new System.Drawing.Point(346, 89);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
>>>>>>> 36be0efe60d949b0c686cdec8ea878e886347aaa
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 24);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Fecha:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancelar.ImageOptions.SvgImage")));
<<<<<<< HEAD
            this.btnCancelar.Location = new System.Drawing.Point(225, 259);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 50);
=======
            this.btnCancelar.Location = new System.Drawing.Point(247, 220);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 54);
>>>>>>> 36be0efe60d949b0c686cdec8ea878e886347aaa
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuardar.ImageOptions.SvgImage")));
<<<<<<< HEAD
            this.btnGuardar.Location = new System.Drawing.Point(41, 259);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 50);
=======
            this.btnGuardar.Location = new System.Drawing.Point(52, 220);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 54);
>>>>>>> 36be0efe60d949b0c686cdec8ea878e886347aaa
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTasaInteres
            // 
<<<<<<< HEAD
            this.txtTasaInteres.Location = new System.Drawing.Point(183, 139);
            this.txtTasaInteres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
=======
            this.txtTasaInteres.Location = new System.Drawing.Point(142, 90);
            this.txtTasaInteres.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
>>>>>>> 36be0efe60d949b0c686cdec8ea878e886347aaa
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(198, 26);
            this.txtTasaInteres.TabIndex = 3;
            this.txtTasaInteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTasaInteres_KeyPress);
            // 
            // txtMonto
            // 
<<<<<<< HEAD
            this.txtMonto.Location = new System.Drawing.Point(183, 89);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(198, 26);
=======
            this.txtMonto.Location = new System.Drawing.Point(426, 34);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(299, 22);
>>>>>>> 36be0efe60d949b0c686cdec8ea878e886347aaa
            this.txtMonto.TabIndex = 2;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // cmbSocio
            // 
            this.cmbSocio.Location = new System.Drawing.Point(183, 40);
            this.cmbSocio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSocio.Name = "cmbSocio";
            this.cmbSocio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSocio.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idSocio", "id Socio", 69, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "nombre", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("apellido", "apellido", 68, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("edad", "edad", 48, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("direccion", "direccion", 76, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idSucursal", "id Sucursal", 90, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 54, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbSocio.Properties.DataSource = this.socioBindingSource;
            this.cmbSocio.Properties.DisplayMember = "nombre";
            this.cmbSocio.Properties.NullText = "";
            this.cmbSocio.Properties.ValueMember = "idSocio";
            this.cmbSocio.Size = new System.Drawing.Size(198, 26);
            this.cmbSocio.TabIndex = 1;
            // 
            // socioBindingSource
            // 
            this.socioBindingSource.DataSource = typeof(DAL.Socio);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
<<<<<<< HEAD
            this.labelControl3.Location = new System.Drawing.Point(24, 139);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
=======
            this.labelControl3.Location = new System.Drawing.Point(19, 90);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
>>>>>>> 36be0efe60d949b0c686cdec8ea878e886347aaa
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(133, 24);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tasa Interes:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
<<<<<<< HEAD
            this.labelControl2.Location = new System.Drawing.Point(24, 90);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
=======
            this.labelControl2.Location = new System.Drawing.Point(341, 33);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
>>>>>>> 36be0efe60d949b0c686cdec8ea878e886347aaa
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 24);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Monto:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 42);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Socio:";
            // 
            // calendarControl
            // 
            this.calendarControl.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl.Location = new System.Drawing.Point(426, 89);
            this.calendarControl.Name = "calendarControl";
            this.calendarControl.Size = new System.Drawing.Size(299, 282);
            this.calendarControl.TabIndex = 9;
            // 
            // frmNPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(436, 365);
=======
            this.ClientSize = new System.Drawing.Size(777, 455);
>>>>>>> 36be0efe60d949b0c686cdec8ea878e886347aaa
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmNPrestamo.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNPrestamo";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.frmNPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalendar.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalendar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaInteres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSocio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl.CalendarTimeProperties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.TextEdit txtTasaInteres;
        private DevExpress.XtraEditors.TextEdit txtMonto;
        private DevExpress.XtraEditors.LookUpEdit cmbSocio;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource socioBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl4;
<<<<<<< HEAD
        private DevExpress.XtraEditors.DateEdit txtCalendar;
=======
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl;
>>>>>>> 36be0efe60d949b0c686cdec8ea878e886347aaa
    }
}