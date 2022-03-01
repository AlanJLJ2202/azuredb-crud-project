
namespace ViewL
{
    partial class frmNAhorro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSocio = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Socio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tasa de Interes";
            // 
            // cmbSocio
            // 
            this.cmbSocio.FormattingEnabled = true;
            this.cmbSocio.Location = new System.Drawing.Point(162, 24);
            this.cmbSocio.Name = "cmbSocio";
            this.cmbSocio.Size = new System.Drawing.Size(121, 28);
            this.cmbSocio.TabIndex = 3;
            // 
            // txtMonto
            // 
            this.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMonto.Location = new System.Drawing.Point(162, 71);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 26);
            this.txtMonto.TabIndex = 4;
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTasaInteres.Location = new System.Drawing.Point(162, 119);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(100, 26);
            this.txtTasaInteres.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(47, 173);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 41);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(162, 172);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 42);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmNAhorro
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(366, 256);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTasaInteres);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.cmbSocio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmNAhorro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Ahorro";
            this.Load += new System.EventHandler(this.frmNAhorro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSocio;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}