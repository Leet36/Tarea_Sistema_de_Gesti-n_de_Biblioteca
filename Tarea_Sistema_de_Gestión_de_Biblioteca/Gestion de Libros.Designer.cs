
namespace Tarea_Sistema_de_Gestión_de_Biblioteca
{
    partial class Gestion_de_Libros
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
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.buttonAgregarLibro = new System.Windows.Forms.Button();
            this.buttonModificarDatos = new System.Windows.Forms.Button();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEditorial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAño = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEdicion = new System.Windows.Forms.TextBox();
            this.buttonEliminarLibro = new System.Windows.Forms.Button();
            this.buttonVolverMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "ISBN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(97, 52);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(100, 20);
            this.textBoxISBN.TabIndex = 31;
            this.textBoxISBN.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // buttonAgregarLibro
            // 
            this.buttonAgregarLibro.Location = new System.Drawing.Point(258, 49);
            this.buttonAgregarLibro.Name = "buttonAgregarLibro";
            this.buttonAgregarLibro.Size = new System.Drawing.Size(520, 23);
            this.buttonAgregarLibro.TabIndex = 35;
            this.buttonAgregarLibro.Text = "Agregar un Nuevo Libro";
            this.buttonAgregarLibro.UseVisualStyleBackColor = true;
            this.buttonAgregarLibro.Click += new System.EventHandler(this.buttonAgregarLibro_Click);
            // 
            // buttonModificarDatos
            // 
            this.buttonModificarDatos.Location = new System.Drawing.Point(258, 105);
            this.buttonModificarDatos.Name = "buttonModificarDatos";
            this.buttonModificarDatos.Size = new System.Drawing.Size(520, 23);
            this.buttonModificarDatos.TabIndex = 36;
            this.buttonModificarDatos.Text = "Modificar Datos";
            this.buttonModificarDatos.UseVisualStyleBackColor = true;
            this.buttonModificarDatos.Click += new System.EventHandler(this.buttonModificarDatos_Click);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(97, 98);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitulo.TabIndex = 37;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Titulo";
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(97, 136);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(100, 20);
            this.textBoxAutor.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Editorial";
            // 
            // textBoxEditorial
            // 
            this.textBoxEditorial.Location = new System.Drawing.Point(97, 174);
            this.textBoxEditorial.Name = "textBoxEditorial";
            this.textBoxEditorial.Size = new System.Drawing.Size(100, 20);
            this.textBoxEditorial.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Año";
            // 
            // textBoxAño
            // 
            this.textBoxAño.Location = new System.Drawing.Point(97, 211);
            this.textBoxAño.Name = "textBoxAño";
            this.textBoxAño.Size = new System.Drawing.Size(100, 20);
            this.textBoxAño.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Edicion";
            // 
            // textBoxEdicion
            // 
            this.textBoxEdicion.Location = new System.Drawing.Point(97, 257);
            this.textBoxEdicion.Name = "textBoxEdicion";
            this.textBoxEdicion.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdicion.TabIndex = 46;
            // 
            // buttonEliminarLibro
            // 
            this.buttonEliminarLibro.Location = new System.Drawing.Point(258, 152);
            this.buttonEliminarLibro.Name = "buttonEliminarLibro";
            this.buttonEliminarLibro.Size = new System.Drawing.Size(520, 23);
            this.buttonEliminarLibro.TabIndex = 47;
            this.buttonEliminarLibro.Text = "Eliminar un Libro";
            this.buttonEliminarLibro.UseVisualStyleBackColor = true;
            this.buttonEliminarLibro.Click += new System.EventHandler(this.buttonEliminarLibro_Click);
            // 
            // buttonVolverMenu
            // 
            this.buttonVolverMenu.Location = new System.Drawing.Point(258, 205);
            this.buttonVolverMenu.Name = "buttonVolverMenu";
            this.buttonVolverMenu.Size = new System.Drawing.Size(520, 22);
            this.buttonVolverMenu.TabIndex = 48;
            this.buttonVolverMenu.Text = "Volver al Menu";
            this.buttonVolverMenu.UseVisualStyleBackColor = true;
            this.buttonVolverMenu.Click += new System.EventHandler(this.buttonVolverMenu_Click);
            // 
            // Gestion_de_Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVolverMenu);
            this.Controls.Add(this.buttonEliminarLibro);
            this.Controls.Add(this.textBoxEdicion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAño);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEditorial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.buttonModificarDatos);
            this.Controls.Add(this.buttonAgregarLibro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxISBN);
            this.Name = "Gestion_de_Libros";
            this.Text = "Gestion_de_Libros";
            this.Load += new System.EventHandler(this.Gestion_de_Libros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Button buttonAgregarLibro;
        private System.Windows.Forms.Button buttonModificarDatos;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEditorial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAño;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEdicion;
        private System.Windows.Forms.Button buttonEliminarLibro;
        private System.Windows.Forms.Button buttonVolverMenu;
    }
}