﻿namespace prySP3FerMoya
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mrcEstadisticas = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblAntiguo = new System.Windows.Forms.Label();
            this.lblCaracteres = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtAntiguo = new System.Windows.Forms.TextBox();
            this.txtCaracteres = new System.Windows.Forms.TextBox();
            this.nudAño = new System.Windows.Forms.NumericUpDown();
            this.mrcRegistro.SuspendLayout();
            this.mrcEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.Controls.Add(this.nudAño);
            this.mrcRegistro.Controls.Add(this.txtTitular);
            this.mrcRegistro.Controls.Add(this.txtDominio);
            this.mrcRegistro.Controls.Add(this.txtNumero);
            this.mrcRegistro.Controls.Add(this.lblTitular);
            this.mrcRegistro.Controls.Add(this.lblAño);
            this.mrcRegistro.Controls.Add(this.lblDominio);
            this.mrcRegistro.Controls.Add(this.lblNumero);
            this.mrcRegistro.Location = new System.Drawing.Point(36, 30);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Size = new System.Drawing.Size(403, 197);
            this.mrcRegistro.TabIndex = 0;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Registro de Turnos";
            this.mrcRegistro.Enter += new System.EventHandler(this.mrcRegistro_Enter);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(518, 51);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(518, 115);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // mrcEstadisticas
            // 
            this.mrcEstadisticas.Controls.Add(this.txtCaracteres);
            this.mrcEstadisticas.Controls.Add(this.txtAntiguo);
            this.mrcEstadisticas.Controls.Add(this.txtCantidad);
            this.mrcEstadisticas.Controls.Add(this.lblCaracteres);
            this.mrcEstadisticas.Controls.Add(this.lblAntiguo);
            this.mrcEstadisticas.Controls.Add(this.lblCantidad);
            this.mrcEstadisticas.Location = new System.Drawing.Point(36, 251);
            this.mrcEstadisticas.Name = "mrcEstadisticas";
            this.mrcEstadisticas.Size = new System.Drawing.Size(403, 154);
            this.mrcEstadisticas.TabIndex = 3;
            this.mrcEstadisticas.TabStop = false;
            this.mrcEstadisticas.Text = "Estadisticas";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(518, 319);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(25, 31);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(86, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero de turno";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(25, 67);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(45, 13);
            this.lblDominio.TabIndex = 1;
            this.lblDominio.Text = "Dominio";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(25, 104);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(96, 13);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Año de fabricacion";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(25, 134);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 3;
            this.lblTitular.Text = "Titular";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(133, 28);
            this.txtNumero.MaxLength = 7;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(133, 64);
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(100, 20);
            this.txtDominio.TabIndex = 5;
            this.txtDominio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDominio_KeyPress);
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(133, 131);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(100, 20);
            this.txtTitular.TabIndex = 7;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(28, 45);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(96, 13);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad de turnos";
            // 
            // lblAntiguo
            // 
            this.lblAntiguo.AutoSize = true;
            this.lblAntiguo.Location = new System.Drawing.Point(25, 78);
            this.lblAntiguo.Name = "lblAntiguo";
            this.lblAntiguo.Size = new System.Drawing.Size(103, 13);
            this.lblAntiguo.TabIndex = 1;
            this.lblAntiguo.Text = "Año del más antiguo";
            // 
            // lblCaracteres
            // 
            this.lblCaracteres.AutoSize = true;
            this.lblCaracteres.Location = new System.Drawing.Point(28, 113);
            this.lblCaracteres.Name = "lblCaracteres";
            this.lblCaracteres.Size = new System.Drawing.Size(186, 13);
            this.lblCaracteres.TabIndex = 2;
            this.lblCaracteres.Text = "Cantidad con dominio de 6 caracteres";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(133, 42);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // txtAntiguo
            // 
            this.txtAntiguo.Location = new System.Drawing.Point(133, 75);
            this.txtAntiguo.Name = "txtAntiguo";
            this.txtAntiguo.Size = new System.Drawing.Size(100, 20);
            this.txtAntiguo.TabIndex = 4;
            // 
            // txtCaracteres
            // 
            this.txtCaracteres.Location = new System.Drawing.Point(240, 110);
            this.txtCaracteres.Name = "txtCaracteres";
            this.txtCaracteres.Size = new System.Drawing.Size(100, 20);
            this.txtCaracteres.TabIndex = 5;
            // 
            // nudAño
            // 
            this.nudAño.Location = new System.Drawing.Point(133, 102);
            this.nudAño.Name = "nudAño";
            this.nudAño.Size = new System.Drawing.Size(72, 20);
            this.nudAño.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.mrcEstadisticas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mrcRegistro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
            this.mrcEstadisticas.ResumeLayout(false);
            this.mrcEstadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcRegistro;
        private System.Windows.Forms.NumericUpDown nudAño;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox mrcEstadisticas;
        private System.Windows.Forms.TextBox txtCaracteres;
        private System.Windows.Forms.TextBox txtAntiguo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCaracteres;
        private System.Windows.Forms.Label lblAntiguo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnConsultar;
    }
}

