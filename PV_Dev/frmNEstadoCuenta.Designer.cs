
namespace PV_Dev
{
    partial class frmNEstadoCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNEstadoCuenta));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtSucursal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtDireccionCompleta = new DevExpress.XtraEditors.LabelControl();
            this.txtEdad = new DevExpress.XtraEditors.LabelControl();
            this.txtApellido = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreCompleto = new DevExpress.XtraEditors.LabelControl();
            this.txtFecha = new DevExpress.XtraEditors.LabelControl();
            this.txtDireccion = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefono = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcAhorro = new DevExpress.XtraGrid.GridControl();
            this.ahorroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvAhorro = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidAhorro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidSocio1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltasaInteres1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcPrestamo = new DevExpress.XtraGrid.GridControl();
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvPrestamo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidPrestamo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidSocio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltasaInteres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.svgImageBox2 = new DevExpress.XtraEditors.SvgImageBox();
            this.txtAhorro = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAhorro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ahorroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAhorro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtSucursal);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtDireccionCompleta);
            this.groupControl1.Controls.Add(this.txtEdad);
            this.groupControl1.Controls.Add(this.txtApellido);
            this.groupControl1.Controls.Add(this.txtNombreCompleto);
            this.groupControl1.Controls.Add(this.txtFecha);
            this.groupControl1.Controls.Add(this.txtDireccion);
            this.groupControl1.Controls.Add(this.txtTelefono);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.txtNombre);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(393, 12);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(275, 245);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Informacion del Socio";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // txtSucursal
            // 
            this.txtSucursal.Location = new System.Drawing.Point(147, 210);
            this.txtSucursal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(82, 16);
            this.txtSucursal.TabIndex = 15;
            this.txtSucursal.Text = "labelControl10";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(68, 210);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(54, 16);
            this.labelControl9.TabIndex = 14;
            this.labelControl9.Text = "Sucursal:";
            // 
            // txtDireccionCompleta
            // 
            this.txtDireccionCompleta.Location = new System.Drawing.Point(147, 173);
            this.txtDireccionCompleta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDireccionCompleta.Name = "txtDireccionCompleta";
            this.txtDireccionCompleta.Size = new System.Drawing.Size(75, 16);
            this.txtDireccionCompleta.TabIndex = 13;
            this.txtDireccionCompleta.Text = "labelControl8";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(147, 134);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(75, 16);
            this.txtEdad.TabIndex = 12;
            this.txtEdad.Text = "labelControl7";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(147, 89);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(75, 16);
            this.txtApellido.TabIndex = 11;
            this.txtApellido.Text = "labelControl6";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(147, 49);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(75, 16);
            this.txtNombreCompleto.TabIndex = 10;
            this.txtNombreCompleto.Text = "labelControl3";
            this.txtNombreCompleto.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(147, 220);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(0, 16);
            this.txtFecha.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(147, 173);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(0, 16);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(147, 134);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(0, 16);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.Click += new System.EventHandler(this.txtTelefono_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(147, 89);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 16);
            this.txtId.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 49);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(0, 16);
            this.txtNombre.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(68, 173);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(57, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Direccion:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(87, 134);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Edad:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(78, 89);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Apellido:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 49);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nombre completo:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcAhorro);
            this.panelControl1.Location = new System.Drawing.Point(23, 282);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(488, 333);
            this.panelControl1.TabIndex = 1;
            // 
            // gcAhorro
            // 
            this.gcAhorro.DataSource = this.ahorroBindingSource;
            this.gcAhorro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAhorro.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcAhorro.Location = new System.Drawing.Point(2, 2);
            this.gcAhorro.MainView = this.gvAhorro;
            this.gcAhorro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcAhorro.Name = "gcAhorro";
            this.gcAhorro.Size = new System.Drawing.Size(484, 329);
            this.gcAhorro.TabIndex = 0;
            this.gcAhorro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAhorro});
            this.gcAhorro.Click += new System.EventHandler(this.gcAhorro_Click);
            // 
            // ahorroBindingSource
            // 
            this.ahorroBindingSource.DataSource = typeof(DAL.Ahorro);
            // 
            // gvAhorro
            // 
            this.gvAhorro.Appearance.Row.BackColor = System.Drawing.Color.Green;
            this.gvAhorro.Appearance.Row.BackColor2 = System.Drawing.Color.Black;
            this.gvAhorro.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvAhorro.Appearance.Row.Options.UseBackColor = true;
            this.gvAhorro.Appearance.Row.Options.UseBorderColor = true;
            this.gvAhorro.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidAhorro,
            this.colidSocio1,
            this.colfecha1,
            this.colmonto1,
            this.coltasaInteres1,
            this.colactivo1});
            this.gvAhorro.DetailHeight = 295;
            this.gvAhorro.GridControl = this.gcAhorro;
            this.gvAhorro.Name = "gvAhorro";
            this.gvAhorro.OptionsBehavior.Editable = false;
            this.gvAhorro.OptionsView.ShowGroupPanel = false;
            // 
            // colidAhorro
            // 
            this.colidAhorro.Caption = "ID";
            this.colidAhorro.FieldName = "idAhorro";
            this.colidAhorro.MinWidth = 25;
            this.colidAhorro.Name = "colidAhorro";
            this.colidAhorro.Visible = true;
            this.colidAhorro.VisibleIndex = 0;
            this.colidAhorro.Width = 58;
            // 
            // colidSocio1
            // 
            this.colidSocio1.FieldName = "idSocio";
            this.colidSocio1.MinWidth = 25;
            this.colidSocio1.Name = "colidSocio1";
            this.colidSocio1.Width = 58;
            // 
            // colfecha1
            // 
            this.colfecha1.Caption = "Fecha";
            this.colfecha1.FieldName = "fecha";
            this.colfecha1.MinWidth = 25;
            this.colfecha1.Name = "colfecha1";
            this.colfecha1.Visible = true;
            this.colfecha1.VisibleIndex = 1;
            this.colfecha1.Width = 58;
            // 
            // colmonto1
            // 
            this.colmonto1.Caption = "Monto";
            this.colmonto1.FieldName = "monto";
            this.colmonto1.MinWidth = 25;
            this.colmonto1.Name = "colmonto1";
            this.colmonto1.Visible = true;
            this.colmonto1.VisibleIndex = 2;
            this.colmonto1.Width = 58;
            // 
            // coltasaInteres1
            // 
            this.coltasaInteres1.Caption = "Tasa de Interes";
            this.coltasaInteres1.FieldName = "tasaInteres";
            this.coltasaInteres1.MinWidth = 25;
            this.coltasaInteres1.Name = "coltasaInteres1";
            this.coltasaInteres1.Visible = true;
            this.coltasaInteres1.VisibleIndex = 3;
            this.coltasaInteres1.Width = 58;
            // 
            // colactivo1
            // 
            this.colactivo1.FieldName = "activo";
            this.colactivo1.MinWidth = 25;
            this.colactivo1.Name = "colactivo1";
            this.colactivo1.Width = 58;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcPrestamo);
            this.panelControl2.Location = new System.Drawing.Point(541, 280);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(468, 337);
            this.panelControl2.TabIndex = 2;
            // 
            // gcPrestamo
            // 
            this.gcPrestamo.DataSource = this.prestamoBindingSource;
            this.gcPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPrestamo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcPrestamo.Location = new System.Drawing.Point(2, 2);
            this.gcPrestamo.MainView = this.gvPrestamo;
            this.gcPrestamo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcPrestamo.Name = "gcPrestamo";
            this.gcPrestamo.Size = new System.Drawing.Size(464, 333);
            this.gcPrestamo.TabIndex = 0;
            this.gcPrestamo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPrestamo});
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataSource = typeof(DAL.Prestamo);
            // 
            // gvPrestamo
            // 
            this.gvPrestamo.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gvPrestamo.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.Black;
            this.gvPrestamo.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gvPrestamo.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvPrestamo.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvPrestamo.Appearance.Row.BackColor = System.Drawing.Color.Red;
            this.gvPrestamo.Appearance.Row.BackColor2 = System.Drawing.Color.Black;
            this.gvPrestamo.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gvPrestamo.Appearance.Row.Options.UseBackColor = true;
            this.gvPrestamo.Appearance.Row.Options.UseBorderColor = true;
            this.gvPrestamo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidPrestamo,
            this.colidSocio,
            this.colfecha,
            this.colmonto,
            this.coltasaInteres,
            this.colactivo});
            this.gvPrestamo.DetailHeight = 295;
            this.gvPrestamo.GridControl = this.gcPrestamo;
            this.gvPrestamo.Name = "gvPrestamo";
            this.gvPrestamo.OptionsBehavior.Editable = false;
            this.gvPrestamo.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gvPrestamo.OptionsView.ShowGroupPanel = false;
            // 
            // colidPrestamo
            // 
            this.colidPrestamo.FieldName = "idPrestamo";
            this.colidPrestamo.MinWidth = 23;
            this.colidPrestamo.Name = "colidPrestamo";
            this.colidPrestamo.Visible = true;
            this.colidPrestamo.VisibleIndex = 0;
            this.colidPrestamo.Width = 87;
            // 
            // colidSocio
            // 
            this.colidSocio.Caption = "ID";
            this.colidSocio.FieldName = "idSocio";
            this.colidSocio.MinWidth = 23;
            this.colidSocio.Name = "colidSocio";
            this.colidSocio.Width = 87;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.MinWidth = 23;
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            this.colfecha.Width = 87;
            // 
            // colmonto
            // 
            this.colmonto.Caption = "Monto";
            this.colmonto.FieldName = "monto";
            this.colmonto.MinWidth = 23;
            this.colmonto.Name = "colmonto";
            this.colmonto.Visible = true;
            this.colmonto.VisibleIndex = 2;
            this.colmonto.Width = 87;
            // 
            // coltasaInteres
            // 
            this.coltasaInteres.Caption = "Tassa de Interes";
            this.coltasaInteres.FieldName = "tasaInteres";
            this.coltasaInteres.MinWidth = 23;
            this.coltasaInteres.Name = "coltasaInteres";
            this.coltasaInteres.Visible = true;
            this.coltasaInteres.VisibleIndex = 3;
            this.coltasaInteres.Width = 87;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 23;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 87;
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(138, 25);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(170, 167);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 3;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // svgImageBox2
            // 
            this.svgImageBox2.Location = new System.Drawing.Point(192, 198);
            this.svgImageBox2.Name = "svgImageBox2";
            this.svgImageBox2.Size = new System.Drawing.Size(57, 58);
            this.svgImageBox2.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.svgImageBox2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox2.SvgImage")));
            this.svgImageBox2.TabIndex = 4;
            this.svgImageBox2.Text = "svgImageBox2";
            // 
            // txtAhorro
            // 
            this.txtAhorro.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.txtAhorro.Appearance.Options.UseForeColor = true;
            this.txtAhorro.Location = new System.Drawing.Point(732, 25);
            this.txtAhorro.Name = "txtAhorro";
            this.txtAhorro.Size = new System.Drawing.Size(73, 16);
            this.txtAhorro.TabIndex = 5;
            this.txtAhorro.Text = "Ahorro total:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(713, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Prestamo total:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Linen;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(760, 61);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 16);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Interes:";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Linen;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(756, 164);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(45, 16);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Interes:";
            // 
            // frmNEstadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 629);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtAhorro);
            this.Controls.Add(this.svgImageBox2);
            this.Controls.Add(this.svgImageBox1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmNEstadoCuenta";
            this.Text = "Estado de cuenta";
            this.Load += new System.EventHandler(this.frmNEstadoCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAhorro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ahorroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAhorro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl txtFecha;
        private DevExpress.XtraEditors.LabelControl txtDireccion;
        private DevExpress.XtraEditors.LabelControl txtTelefono;
        private DevExpress.XtraEditors.LabelControl txtId;
        private DevExpress.XtraEditors.LabelControl txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl txtDireccionCompleta;
        private DevExpress.XtraEditors.LabelControl txtEdad;
        private DevExpress.XtraEditors.LabelControl txtApellido;
        private DevExpress.XtraEditors.LabelControl txtNombreCompleto;
        private DevExpress.XtraEditors.LabelControl txtSucursal;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcAhorro;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAhorro;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcPrestamo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrestamo;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidPrestamo;
        private DevExpress.XtraGrid.Columns.GridColumn colidSocio;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto;
        private DevExpress.XtraGrid.Columns.GridColumn coltasaInteres;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox2;
        private DevExpress.XtraEditors.LabelControl txtAhorro;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn colidAhorro;
        private DevExpress.XtraGrid.Columns.GridColumn colidSocio1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha1;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto1;
        private DevExpress.XtraGrid.Columns.GridColumn coltasaInteres1;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo1;
        private System.Windows.Forms.BindingSource ahorroBindingSource;
    }
}