
namespace PV_Dev
{
    partial class frmSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSocio));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEstadoCuenta = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcSocio = new DevExpress.XtraGrid.GridControl();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvSocio = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidSocio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coledad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupSucursal = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSocio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSocio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
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
            this.btnEliminar,
            this.btnEstadoCuenta});
            this.barManager1.MaxItemId = 5;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEstadoCuenta, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // btnEstadoCuenta
            // 
            this.btnEstadoCuenta.Caption = "Estado de Cuenta";
            this.btnEstadoCuenta.Id = 4;
            this.btnEstadoCuenta.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnEstadoCuenta.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnEstadoCuenta.Name = "btnEstadoCuenta";
            this.btnEstadoCuenta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEstadoCuenta_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(909, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 514);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(909, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 480);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(909, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 480);
            // 
            // gcSocio
            // 
            this.gcSocio.DataSource = this.socioBindingSource;
            this.gcSocio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSocio.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSocio.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcSocio.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcSocio.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcSocio.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcSocio.Location = new System.Drawing.Point(0, 34);
            this.gcSocio.MainView = this.gvSocio;
            this.gcSocio.Margin = new System.Windows.Forms.Padding(4);
            this.gcSocio.MenuManager = this.barManager1;
            this.gcSocio.Name = "gcSocio";
            this.gcSocio.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlupSucursal});
            this.gcSocio.Size = new System.Drawing.Size(909, 480);
            this.gcSocio.TabIndex = 4;
            this.gcSocio.UseEmbeddedNavigator = true;
            this.gcSocio.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSocio});
            // 
            // socioBindingSource
            // 
            this.socioBindingSource.DataSource = typeof(DAL.Socio);
            // 
            // gvSocio
            // 
            this.gvSocio.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidSocio,
            this.colnombre,
            this.colapellido,
            this.coledad,
            this.coldireccion,
            this.colidSucursal,
            this.colactivo});
            this.gvSocio.DetailHeight = 416;
            this.gvSocio.GridControl = this.gcSocio;
            this.gvSocio.Name = "gvSocio";
            this.gvSocio.OptionsBehavior.Editable = false;
            this.gvSocio.OptionsView.ColumnAutoWidth = false;
            this.gvSocio.OptionsView.ShowAutoFilterRow = true;
            this.gvSocio.OptionsView.ShowGroupPanel = false;
            // 
            // colidSocio
            // 
            this.colidSocio.Caption = "ID";
            this.colidSocio.FieldName = "idSocio";
            this.colidSocio.MinWidth = 32;
            this.colidSocio.Name = "colidSocio";
            this.colidSocio.OptionsColumn.AllowMove = false;
            this.colidSocio.Visible = true;
            this.colidSocio.VisibleIndex = 0;
            this.colidSocio.Width = 121;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Socio";
            this.colnombre.FieldName = "nombre";
            this.colnombre.MinWidth = 32;
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowMove = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 121;
            // 
            // colapellido
            // 
            this.colapellido.Caption = "Apellido";
            this.colapellido.FieldName = "apellido";
            this.colapellido.MinWidth = 32;
            this.colapellido.Name = "colapellido";
            this.colapellido.OptionsColumn.AllowMove = false;
            this.colapellido.Visible = true;
            this.colapellido.VisibleIndex = 2;
            this.colapellido.Width = 121;
            // 
            // coledad
            // 
            this.coledad.Caption = "Edad";
            this.coledad.FieldName = "edad";
            this.coledad.MinWidth = 32;
            this.coledad.Name = "coledad";
            this.coledad.OptionsColumn.AllowMove = false;
            this.coledad.Visible = true;
            this.coledad.VisibleIndex = 3;
            this.coledad.Width = 121;
            // 
            // coldireccion
            // 
            this.coldireccion.Caption = "Dirección";
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.MinWidth = 32;
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.OptionsColumn.AllowMove = false;
            this.coldireccion.Visible = true;
            this.coldireccion.VisibleIndex = 4;
            this.coldireccion.Width = 121;
            // 
            // colidSucursal
            // 
            this.colidSucursal.Caption = "Sucursal";
            this.colidSucursal.ColumnEdit = this.rlupSucursal;
            this.colidSucursal.FieldName = "idSucursal";
            this.colidSucursal.MinWidth = 32;
            this.colidSucursal.Name = "colidSucursal";
            this.colidSucursal.OptionsColumn.AllowMove = false;
            this.colidSucursal.Visible = true;
            this.colidSucursal.VisibleIndex = 5;
            this.colidSucursal.Width = 121;
            // 
            // rlupSucursal
            // 
            this.rlupSucursal.AutoHeight = false;
            this.rlupSucursal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupSucursal.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idSucursal", "id Sucursal", 95, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "nombre", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("direccion", "direccion", 80, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("telefono", "telefono", 73, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 57, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlupSucursal.DataSource = this.sucursalBindingSource;
            this.rlupSucursal.DisplayMember = "nombre";
            this.rlupSucursal.Name = "rlupSucursal";
            this.rlupSucursal.ValueMember = "idSucursal";
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataSource = typeof(DAL.Sucursal);
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 32;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 121;
            // 
            // frmSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 514);
            this.Controls.Add(this.gcSocio);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmSocio.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSocio_FormClosing);
            this.Load += new System.EventHandler(this.frmSocio_Load);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.frmSocio_GiveFeedback);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSocio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSocio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcSocio;
        private System.Windows.Forms.BindingSource socioBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSocio;
        private DevExpress.XtraGrid.Columns.GridColumn colidSocio;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colapellido;
        private DevExpress.XtraGrid.Columns.GridColumn coledad;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colidSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupSucursal;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
        private DevExpress.XtraBars.BarButtonItem btnEstadoCuenta;
    }
}