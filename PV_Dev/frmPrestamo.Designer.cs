
namespace PV_Dev
{
    partial class frmPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamo));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcPrestamo = new DevExpress.XtraGrid.GridControl();
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvPrestamo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidPrestamo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidSocio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupSocios = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltasaInteres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnActualizar,
            this.btnNuevo,
            this.btnModificar,
            this.btnEliminar});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnActualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnModificar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 0;
            this.btnActualizar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnActualizar.ImageOptions.SvgImage")));
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 1;
            this.btnNuevo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNuevo.ImageOptions.SvgImage")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Caption = "Modificar";
            this.btnModificar.Id = 2;
            this.btnModificar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnModificar.ImageOptions.SvgImage")));
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModificar_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 3;
            this.btnEliminar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEliminar.ImageOptions.SvgImage")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(663, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 409);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(663, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 379);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(663, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 379);
            // 
            // gcPrestamo
            // 
            this.gcPrestamo.DataSource = this.prestamoBindingSource;
            this.gcPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPrestamo.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcPrestamo.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcPrestamo.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcPrestamo.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcPrestamo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcPrestamo.Location = new System.Drawing.Point(0, 30);
            this.gcPrestamo.MainView = this.gvPrestamo;
            this.gcPrestamo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcPrestamo.MenuManager = this.barManager1;
            this.gcPrestamo.Name = "gcPrestamo";
            this.gcPrestamo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlupSocios});
            this.gcPrestamo.Size = new System.Drawing.Size(663, 379);
            this.gcPrestamo.TabIndex = 4;
            this.gcPrestamo.UseEmbeddedNavigator = true;
            this.gcPrestamo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPrestamo});
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataSource = typeof(DAL.Prestamo);
            // 
            // gvPrestamo
            // 
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
            this.gvPrestamo.OptionsView.ColumnAutoWidth = false;
            this.gvPrestamo.OptionsView.ShowAutoFilterRow = true;
            this.gvPrestamo.OptionsView.ShowGroupPanel = false;
            // 
            // colidPrestamo
            // 
            this.colidPrestamo.Caption = "ID";
            this.colidPrestamo.FieldName = "idPrestamo";
            this.colidPrestamo.MinWidth = 23;
            this.colidPrestamo.Name = "colidPrestamo";
            this.colidPrestamo.Visible = true;
            this.colidPrestamo.VisibleIndex = 0;
            this.colidPrestamo.Width = 87;
            // 
            // colidSocio
            // 
            this.colidSocio.Caption = "Socio";
            this.colidSocio.ColumnEdit = this.rlupSocios;
            this.colidSocio.FieldName = "idSocio";
            this.colidSocio.MinWidth = 23;
            this.colidSocio.Name = "colidSocio";
            this.colidSocio.Visible = true;
            this.colidSocio.VisibleIndex = 1;
            this.colidSocio.Width = 87;
            // 
            // rlupSocios
            // 
            this.rlupSocios.AutoHeight = false;
            this.rlupSocios.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupSocios.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idSocio", "id Socio", 54, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "socio", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("apellido", "apellido", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("edad", "edad", 37, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("direccion", "direccion", 59, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idSucursal", "id Sucursal", 70, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 42, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlupSocios.DataSource = this.socioBindingSource;
            this.rlupSocios.DisplayMember = "nombre";
            this.rlupSocios.Name = "rlupSocios";
            this.rlupSocios.ValueMember = "idSocio";
            // 
            // socioBindingSource
            // 
            this.socioBindingSource.DataSource = typeof(DAL.Socio);
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.MinWidth = 23;
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            this.colfecha.Width = 87;
            // 
            // colmonto
            // 
            this.colmonto.Caption = "Monto";
            this.colmonto.FieldName = "monto";
            this.colmonto.MinWidth = 23;
            this.colmonto.Name = "colmonto";
            this.colmonto.Visible = true;
            this.colmonto.VisibleIndex = 3;
            this.colmonto.Width = 87;
            // 
            // coltasaInteres
            // 
            this.coltasaInteres.Caption = "Tasa de Interes";
            this.coltasaInteres.FieldName = "tasaInteres";
            this.coltasaInteres.MinWidth = 23;
            this.coltasaInteres.Name = "coltasaInteres";
            this.coltasaInteres.Visible = true;
            this.coltasaInteres.VisibleIndex = 4;
            this.coltasaInteres.Width = 87;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 23;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 87;
            // 
            // frmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 409);
            this.Controls.Add(this.gcPrestamo);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f);
            this.Load += new System.EventHandler(this.frmPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnModificar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcPrestamo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrestamo;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidPrestamo;
        private DevExpress.XtraGrid.Columns.GridColumn colidSocio;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto;
        private DevExpress.XtraGrid.Columns.GridColumn coltasaInteres;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupSocios;
        private System.Windows.Forms.BindingSource socioBindingSource;
    }
}