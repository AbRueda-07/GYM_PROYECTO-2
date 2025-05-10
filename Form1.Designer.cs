namespace GYM_Proyecto2_Forms_Ext.Forms
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMiembros = new System.Windows.Forms.Button();
            this.btnClases = new System.Windows.Forms.Button();
            this.btnInstructores = new System.Windows.Forms.Button();
            this.btnMembresias = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(125, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(388, 39);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "---- MENÚ PRINCIPAL ----";
            // 
            // btnMiembros
            // 
            this.btnMiembros.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMiembros.Location = new System.Drawing.Point(113, 126);
            this.btnMiembros.Name = "btnMiembros";
            this.btnMiembros.Size = new System.Drawing.Size(400, 40);
            this.btnMiembros.TabIndex = 8;
            this.btnMiembros.Text = "Gestión de Miembros";
            this.btnMiembros.UseVisualStyleBackColor = true;
            // 
            // btnClases
            // 
            this.btnClases.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnClases.Location = new System.Drawing.Point(113, 186);
            this.btnClases.Name = "btnClases";
            this.btnClases.Size = new System.Drawing.Size(400, 40);
            this.btnClases.TabIndex = 9;
            this.btnClases.Text = "Gestión de Clases";
            this.btnClases.UseVisualStyleBackColor = true;
            // 
            // btnInstructores
            // 
            this.btnInstructores.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnInstructores.Location = new System.Drawing.Point(113, 246);
            this.btnInstructores.Name = "btnInstructores";
            this.btnInstructores.Size = new System.Drawing.Size(400, 40);
            this.btnInstructores.TabIndex = 10;
            this.btnInstructores.Text = "Gestión de Instructores";
            this.btnInstructores.UseVisualStyleBackColor = true;
            // 
            // btnMembresias
            // 
            this.btnMembresias.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMembresias.Location = new System.Drawing.Point(113, 306);
            this.btnMembresias.Name = "btnMembresias";
            this.btnMembresias.Size = new System.Drawing.Size(400, 40);
            this.btnMembresias.TabIndex = 11;
            this.btnMembresias.Text = "Gestión de Membresías";
            this.btnMembresias.UseVisualStyleBackColor = true;
            // 
            // btnReservas
            // 
            this.btnReservas.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnReservas.Location = new System.Drawing.Point(113, 366);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(400, 40);
            this.btnReservas.TabIndex = 12;
            this.btnReservas.Text = "Gestión de Reservas";
            this.btnReservas.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(113, 426);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(400, 40);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 521);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnMiembros);
            this.Controls.Add(this.btnClases);
            this.Controls.Add(this.btnInstructores);
            this.Controls.Add(this.btnMembresias);
            this.Controls.Add(this.btnReservas);
            this.Controls.Add(this.btnSalir);
            this.Name = "Form1";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMiembros;
        private System.Windows.Forms.Button btnClases;
        private System.Windows.Forms.Button btnInstructores;
        private System.Windows.Forms.Button btnMembresias;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnSalir;
    }
}