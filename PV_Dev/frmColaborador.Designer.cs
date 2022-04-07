
namespace PV_Dev
{
    partial class frmColaborador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColaborador));
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
            this.gcColaborador = new DevExpress.XtraGrid.GridControl();
            this.colaboradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvColaborador = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidColaborador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coledad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsueldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupArea = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colidSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupSucursal = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcColaborador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvColaborador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(605, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 410);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(605, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 380);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(605, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 380);
            // 
            // gcColaborador
            // 
            this.gcColaborador.DataSource = this.colaboradorBindingSource;
            this.gcColaborador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcColaborador.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcColaborador.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcColaborador.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcColaborador.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcColaborador.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcColaborador.Location = new System.Drawing.Point(0, 30);
            this.gcColaborador.MainView = this.gvColaborador;
            this.gcColaborador.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcColaborador.MenuManager = this.barManager1;
            this.gcColaborador.Name = "gcColaborador";
            this.gcColaborador.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlupArea,
            this.rlupSucursal});
            this.gcColaborador.Size = new System.Drawing.Size(605, 380);
            this.gcColaborador.TabIndex = 4;
            this.gcColaborador.UseEmbeddedNavigator = true;
            this.gcColaborador.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvColaborador});
            // 
            // colaboradorBindingSource
            // 
            this.colaboradorBindingSource.DataSource = typeof(DAL.Colaborador);
            // 
            // gvColaborador
            // 
            this.gvColaborador.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidColaborador,
            this.colnombre,
            this.colapellido,
            this.coledad,
            this.coldireccion,
            this.colsueldo,
            this.colidArea,
            this.colidSucursal,
            this.colactivo});
            this.gvColaborador.DetailHeight = 295;
            this.gvColaborador.GridControl = this.gcColaborador;
            this.gvColaborador.Name = "gvColaborador";
            this.gvColaborador.OptionsBehavior.Editable = false;
            this.gvColaborador.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gvColaborador.OptionsView.ColumnAutoWidth = false;
            this.gvColaborador.OptionsView.ShowAutoFilterRow = true;
            this.gvColaborador.OptionsView.ShowGroupPanel = false;
            // 
            // colidColaborador
            // 
            this.colidColaborador.Caption = "ID";
            this.colidColaborador.FieldName = "idColaborador";
            this.colidColaborador.MinWidth = 23;
            this.colidColaborador.Name = "colidColaborador";
            this.colidColaborador.OptionsColumn.AllowMove = false;
            this.colidColaborador.Visible = true;
            this.colidColaborador.VisibleIndex = 0;
            this.colidColaborador.Width = 87;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Colaborador";
            this.colnombre.FieldName = "nombre";
            this.colnombre.MinWidth = 23;
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowMove = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 87;
            // 
            // colapellido
            // 
            this.colapellido.Caption = "Apellido";
            this.colapellido.FieldName = "apellido";
            this.colapellido.MinWidth = 23;
            this.colapellido.Name = "colapellido";
            this.colapellido.OptionsColumn.AllowMove = false;
            this.colapellido.Visible = true;
            this.colapellido.VisibleIndex = 2;
            this.colapellido.Width = 87;
            // 
            // coledad
            // 
            this.coledad.Caption = "Edad";
            this.coledad.FieldName = "edad";
            this.coledad.MinWidth = 23;
            this.coledad.Name = "coledad";
            this.coledad.OptionsColumn.AllowMove = false;
            this.coledad.Visible = true;
            this.coledad.VisibleIndex = 3;
            this.coledad.Width = 87;
            // 
            // coldireccion
            // 
            this.coldireccion.Caption = "Direccion";
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.MinWidth = 23;
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.OptionsColumn.AllowMove = false;
            this.coldireccion.Visible = true;
            this.coldireccion.VisibleIndex = 4;
            this.coldireccion.Width = 87;
            // 
            // colsueldo
            // 
            this.colsueldo.Caption = "Sueldo";
            this.colsueldo.FieldName = "sueldo";
            this.colsueldo.MinWidth = 23;
            this.colsueldo.Name = "colsueldo";
            this.colsueldo.OptionsColumn.AllowMove = false;
            this.colsueldo.Visible = true;
            this.colsueldo.VisibleIndex = 5;
            this.colsueldo.Width = 87;
            // 
            // colidArea
            // 
            this.colidArea.Caption = "Area";
            this.colidArea.ColumnEdit = this.rlupArea;
            this.colidArea.FieldName = "idArea";
            this.colidArea.MinWidth = 23;
            this.colidArea.Name = "colidArea";
            this.colidArea.OptionsColumn.AllowMove = false;
            this.colidArea.Visible = true;
            this.colidArea.VisibleIndex = 6;
            this.colidArea.Width = 87;
            // 
            // rlupArea
            // 
            this.rlupArea.AutoHeight = false;
            this.rlupArea.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupArea.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idArea", "id Area", 50, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "nombre", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Area", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 42, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlupArea.DataSource = this.areaBindingSource;
            this.rlupArea.DisplayMember = "descripcion";
            this.rlupArea.Name = "rlupArea";
            this.rlupArea.ValueMember = "idArea";
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataSource = typeof(DAL.Area);
            // 
            // colidSucursal
            // 
            this.colidSucursal.Caption = "Sucursal";
            this.colidSucursal.ColumnEdit = this.rlupSucursal;
            this.colidSucursal.FieldName = "idSucursal";
            this.colidSucursal.MinWidth = 23;
            this.colidSucursal.Name = "colidSucursal";
            this.colidSucursal.OptionsColumn.AllowMove = false;
            this.colidSucursal.Visible = true;
            this.colidSucursal.VisibleIndex = 7;
            this.colidSucursal.Width = 87;
            // 
            // rlupSucursal
            // 
            this.rlupSucursal.AutoHeight = false;
            this.rlupSucursal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupSucursal.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idSucursal", "id Sucursal", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Sucursal", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("direccion", "direccion", 59, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("telefono", "telefono", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 42, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
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
            this.colactivo.MinWidth = 23;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 87;
            // 
            // frmColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 410);
            this.Controls.Add(this.gcColaborador);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colaboradores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmColaborador_FormClosing);
            this.Load += new System.EventHandler(this.frmColaborador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcColaborador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvColaborador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcColaborador;
        private DevExpress.XtraGrid.Views.Grid.GridView gvColaborador;
        private System.Windows.Forms.BindingSource colaboradorBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidColaborador;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colapellido;
        private DevExpress.XtraGrid.Columns.GridColumn coledad;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colsueldo;
        private DevExpress.XtraGrid.Columns.GridColumn colidArea;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupArea;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupSucursal;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
    }
}