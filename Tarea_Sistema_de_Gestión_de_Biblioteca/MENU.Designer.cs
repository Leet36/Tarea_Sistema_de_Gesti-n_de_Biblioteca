
namespace Tarea_Sistema_de_Gestión_de_Biblioteca
{
    partial class MENU
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
            this.buttonLibros = new System.Windows.Forms.Button();
            this.buttonBusqueda = new System.Windows.Forms.Button();
            this.buttonPrestarDevolver = new System.Windows.Forms.Button();
            this.buttonGestionarUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLibros
            // 
            this.buttonLibros.Location = new System.Drawing.Point(179, 40);
            this.buttonLibros.Name = "buttonLibros";
            this.buttonLibros.Size = new System.Drawing.Size(456, 23);
            this.buttonLibros.TabIndex = 0;
            this.buttonLibros.Text = "Gestionar Libros";
            this.buttonLibros.UseVisualStyleBackColor = true;
            this.buttonLibros.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBusqueda
            // 
            this.buttonBusqueda.Location = new System.Drawing.Point(179, 78);
            this.buttonBusqueda.Name = "buttonBusqueda";
            this.buttonBusqueda.Size = new System.Drawing.Size(456, 23);
            this.buttonBusqueda.TabIndex = 1;
            this.buttonBusqueda.Text = "Buscar Libros";
            this.buttonBusqueda.UseVisualStyleBackColor = true;
            this.buttonBusqueda.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPrestarDevolver
            // 
            this.buttonPrestarDevolver.Location = new System.Drawing.Point(179, 119);
            this.buttonPrestarDevolver.Name = "buttonPrestarDevolver";
            this.buttonPrestarDevolver.Size = new System.Drawing.Size(456, 23);
            this.buttonPrestarDevolver.TabIndex = 2;
            this.buttonPrestarDevolver.Text = "Prestamo y Devolucion de Libros";
            this.buttonPrestarDevolver.UseVisualStyleBackColor = true;
            this.buttonPrestarDevolver.Click += new System.EventHandler(this.buttonPrestarDevolver_Click);
            // 
            // buttonGestionarUsuarios
            // 
            this.buttonGestionarUsuarios.Location = new System.Drawing.Point(179, 167);
            this.buttonGestionarUsuarios.Name = "buttonGestionarUsuarios";
            this.buttonGestionarUsuarios.Size = new System.Drawing.Size(456, 23);
            this.buttonGestionarUsuarios.TabIndex = 3;
            this.buttonGestionarUsuarios.Text = "Gestionar Usuarios";
            this.buttonGestionarUsuarios.UseVisualStyleBackColor = true;
            this.buttonGestionarUsuarios.Click += new System.EventHandler(this.buttonGestionarUsuarios_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 235);
            this.Controls.Add(this.buttonGestionarUsuarios);
            this.Controls.Add(this.buttonPrestarDevolver);
            this.Controls.Add(this.buttonBusqueda);
            this.Controls.Add(this.buttonLibros);
            this.Name = "MENU";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.MENU_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLibros;
        private System.Windows.Forms.Button buttonBusqueda;
        private System.Windows.Forms.Button buttonPrestarDevolver;
        private System.Windows.Forms.Button buttonGestionarUsuarios;
    }
}