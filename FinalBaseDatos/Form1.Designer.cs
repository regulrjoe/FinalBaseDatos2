﻿namespace FinalBaseDatos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tbAdmin = new System.Windows.Forms.TabPage();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.btnOkEditar = new System.Windows.Forms.Button();
            this.cmbPuestos = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnOkNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.tbPagos = new System.Windows.Forms.TabPage();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtInc = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEmpleado2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbReportes = new System.Windows.Forms.TabPage();
            this.dgvRep = new System.Windows.Forms.DataGridView();
            this.btnMonto = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnFecha = new System.Windows.Forms.Button();
            this.cmbEmpleado3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabCtrl.SuspendLayout();
            this.tbAdmin.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.tbPagos.SuspendLayout();
            this.tbReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRep)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tbAdmin);
            this.tabCtrl.Controls.Add(this.tbPagos);
            this.tabCtrl.Controls.Add(this.tbReportes);
            this.tabCtrl.Location = new System.Drawing.Point(12, 12);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(498, 247);
            this.tabCtrl.TabIndex = 0;
            // 
            // tbAdmin
            // 
            this.tbAdmin.Controls.Add(this.grpDatos);
            this.tbAdmin.Controls.Add(this.btnEliminar);
            this.tbAdmin.Controls.Add(this.btnEditar);
            this.tbAdmin.Controls.Add(this.btnNuevo);
            this.tbAdmin.Controls.Add(this.cmbEmpleado);
            this.tbAdmin.Controls.Add(this.lblEmpleado);
            this.tbAdmin.Location = new System.Drawing.Point(4, 22);
            this.tbAdmin.Name = "tbAdmin";
            this.tbAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tbAdmin.Size = new System.Drawing.Size(490, 221);
            this.tbAdmin.TabIndex = 0;
            this.tbAdmin.Text = "Administración";
            this.tbAdmin.UseVisualStyleBackColor = true;
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.btnOkEditar);
            this.grpDatos.Controls.Add(this.cmbPuestos);
            this.grpDatos.Controls.Add(this.txtEdad);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblEdad);
            this.grpDatos.Controls.Add(this.lblPuesto);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.btnOkNuevo);
            this.grpDatos.Location = new System.Drawing.Point(23, 115);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(356, 92);
            this.grpDatos.TabIndex = 5;
            this.grpDatos.TabStop = false;
            this.grpDatos.Visible = false;
            // 
            // btnOkEditar
            // 
            this.btnOkEditar.Location = new System.Drawing.Point(237, 58);
            this.btnOkEditar.Name = "btnOkEditar";
            this.btnOkEditar.Size = new System.Drawing.Size(75, 23);
            this.btnOkEditar.TabIndex = 11;
            this.btnOkEditar.Text = "Editar";
            this.btnOkEditar.UseVisualStyleBackColor = true;
            this.btnOkEditar.Click += new System.EventHandler(this.btnOkEditar_Click);
            // 
            // cmbPuestos
            // 
            this.cmbPuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuestos.FormattingEnabled = true;
            this.cmbPuestos.Location = new System.Drawing.Point(71, 60);
            this.cmbPuestos.Name = "cmbPuestos";
            this.cmbPuestos.Size = new System.Drawing.Size(146, 21);
            this.cmbPuestos.TabIndex = 6;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(275, 25);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(37, 20);
            this.txtEdad.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(234, 28);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 8;
            this.lblEdad.Text = "Edad:";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(18, 63);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(43, 13);
            this.lblPuesto.TabIndex = 7;
            this.lblPuesto.Text = "Puesto:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnOkNuevo
            // 
            this.btnOkNuevo.Location = new System.Drawing.Point(237, 59);
            this.btnOkNuevo.Name = "btnOkNuevo";
            this.btnOkNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnOkNuevo.TabIndex = 6;
            this.btnOkNuevo.Text = "Nuevo";
            this.btnOkNuevo.UseVisualStyleBackColor = true;
            this.btnOkNuevo.Click += new System.EventHandler(this.btnOkNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(260, 68);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(143, 68);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(23, 68);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(97, 17);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(238, 21);
            this.cmbEmpleado.TabIndex = 1;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(20, 20);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(57, 13);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // tbPagos
            // 
            this.tbPagos.Controls.Add(this.btnPagar);
            this.tbPagos.Controls.Add(this.txtInc);
            this.tbPagos.Controls.Add(this.txtDesc);
            this.tbPagos.Controls.Add(this.label3);
            this.tbPagos.Controls.Add(this.label2);
            this.tbPagos.Controls.Add(this.cmbEmpleado2);
            this.tbPagos.Controls.Add(this.label1);
            this.tbPagos.Location = new System.Drawing.Point(4, 22);
            this.tbPagos.Name = "tbPagos";
            this.tbPagos.Padding = new System.Windows.Forms.Padding(3);
            this.tbPagos.Size = new System.Drawing.Size(490, 221);
            this.tbPagos.TabIndex = 1;
            this.tbPagos.Text = "Pagos";
            this.tbPagos.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(248, 139);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 13;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtInc
            // 
            this.txtInc.Location = new System.Drawing.Point(269, 94);
            this.txtInc.Name = "txtInc";
            this.txtInc.Size = new System.Drawing.Size(54, 20);
            this.txtInc.TabIndex = 12;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(113, 94);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(54, 20);
            this.txtDesc.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Incentivos: $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descuento: $";
            // 
            // cmbEmpleado2
            // 
            this.cmbEmpleado2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado2.FormattingEnabled = true;
            this.cmbEmpleado2.Location = new System.Drawing.Point(113, 30);
            this.cmbEmpleado2.Name = "cmbEmpleado2";
            this.cmbEmpleado2.Size = new System.Drawing.Size(210, 21);
            this.cmbEmpleado2.TabIndex = 2;
            this.cmbEmpleado2.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleado2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empleado:";
            // 
            // tbReportes
            // 
            this.tbReportes.Controls.Add(this.dgvRep);
            this.tbReportes.Controls.Add(this.btnMonto);
            this.tbReportes.Controls.Add(this.btnEmpleado);
            this.tbReportes.Controls.Add(this.btnFecha);
            this.tbReportes.Controls.Add(this.cmbEmpleado3);
            this.tbReportes.Controls.Add(this.label4);
            this.tbReportes.Location = new System.Drawing.Point(4, 22);
            this.tbReportes.Name = "tbReportes";
            this.tbReportes.Size = new System.Drawing.Size(490, 221);
            this.tbReportes.TabIndex = 2;
            this.tbReportes.Text = "Reportes";
            this.tbReportes.UseVisualStyleBackColor = true;
            // 
            // dgvRep
            // 
            this.dgvRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRep.Location = new System.Drawing.Point(3, 42);
            this.dgvRep.Name = "dgvRep";
            this.dgvRep.Size = new System.Drawing.Size(484, 176);
            this.dgvRep.TabIndex = 17;
            // 
            // btnMonto
            // 
            this.btnMonto.Location = new System.Drawing.Point(405, 10);
            this.btnMonto.Name = "btnMonto";
            this.btnMonto.Size = new System.Drawing.Size(75, 23);
            this.btnMonto.TabIndex = 16;
            this.btnMonto.Text = "Monto";
            this.btnMonto.UseVisualStyleBackColor = true;
            this.btnMonto.Click += new System.EventHandler(this.btnMonto_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Location = new System.Drawing.Point(324, 10);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnEmpleado.TabIndex = 15;
            this.btnEmpleado.Text = "Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(243, 10);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(75, 23);
            this.btnFecha.TabIndex = 14;
            this.btnFecha.Text = "Fecha";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // cmbEmpleado3
            // 
            this.cmbEmpleado3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado3.FormattingEnabled = true;
            this.cmbEmpleado3.Location = new System.Drawing.Point(80, 12);
            this.cmbEmpleado3.Name = "cmbEmpleado3";
            this.cmbEmpleado3.Size = new System.Drawing.Size(144, 21);
            this.cmbEmpleado3.TabIndex = 4;
            this.cmbEmpleado3.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleado3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Empleado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 271);
            this.Controls.Add(this.tabCtrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabCtrl.ResumeLayout(false);
            this.tbAdmin.ResumeLayout(false);
            this.tbAdmin.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.tbPagos.ResumeLayout(false);
            this.tbPagos.PerformLayout();
            this.tbReportes.ResumeLayout(false);
            this.tbReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tbAdmin;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TabPage tbPagos;
        private System.Windows.Forms.TabPage tbReportes;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Button btnOkEditar;
        private System.Windows.Forms.ComboBox cmbPuestos;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnOkNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txtInc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEmpleado2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRep;
        private System.Windows.Forms.Button btnMonto;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.ComboBox cmbEmpleado3;
        private System.Windows.Forms.Label label4;
    }
}

