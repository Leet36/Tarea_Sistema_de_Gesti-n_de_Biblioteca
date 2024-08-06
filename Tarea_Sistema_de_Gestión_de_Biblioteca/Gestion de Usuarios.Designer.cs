
namespace Tarea_Sistema_de_Gestión_de_Biblioteca
{
    partial class Gestion_de_Usuarios
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
            this.buttonVolverMenu = new System.Windows.Forms.Button();
            this.buttonModificarLibro = new System.Windows.Forms.Button();
            this.buttonEliminarUsuario = new System.Windows.Forms.Button();
            this.textBoxSegundoApellido = new System.Windows.Forms.TextBox();
            this.textBoxPrimerApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAgregarUsuario = new System.Windows.Forms.Button();
            this.textBoxCodigoAsociado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVolverMenu
            // 
            this.buttonVolverMenu.Location = new System.Drawing.Point(217, 201);
            this.buttonVolverMenu.Name = "buttonVolverMenu";
            this.buttonVolverMenu.Size = new System.Drawing.Size(520, 22);
            this.buttonVolverMenu.TabIndex = 29;
            this.buttonVolverMenu.Text = "Volver al Menu";
            this.buttonVolverMenu.UseVisualStyleBackColor = true;
            this.buttonVolverMenu.Click += new System.EventHandler(this.buttonVolverMenu_Click);
            // 
            // buttonModificarLibro
            // 
            this.buttonModificarLibro.Location = new System.Drawing.Point(217, 125);
            this.buttonModificarLibro.Name = "buttonModificarLibro";
            this.buttonModificarLibro.Size = new System.Drawing.Size(520, 23);
            this.buttonModificarLibro.TabIndex = 28;
            this.buttonModificarLibro.Text = "Modificar los Datos de un Usuario";
            this.buttonModificarLibro.UseVisualStyleBackColor = true;
            this.buttonModificarLibro.Click += new System.EventHandler(this.buttonModificarLibro_Click);
            // 
            // buttonEliminarUsuario
            // 
            this.buttonEliminarUsuario.Location = new System.Drawing.Point(217, 65);
            this.buttonEliminarUsuario.Name = "buttonEliminarUsuario";
            this.buttonEliminarUsuario.Size = new System.Drawing.Size(520, 23);
            this.buttonEliminarUsuario.TabIndex = 27;
            this.buttonEliminarUsuario.Text = "Eliminar Usuario";
            this.buttonEliminarUsuario.UseVisualStyleBackColor = true;
            this.buttonEliminarUsuario.Click += new System.EventHandler(this.buttonEliminarUsuario_Click);
            // 
            // textBoxSegundoApellido
            // 
            this.textBoxSegundoApellido.Location = new System.Drawing.Point(108, 96);
            this.textBoxSegundoApellido.Name = "textBoxSegundoApellido";
            this.textBoxSegundoApellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxSegundoApellido.TabIndex = 23;
            // 
            // textBoxPrimerApellido
            // 
            this.textBoxPrimerApellido.Location = new System.Drawing.Point(108, 65);
            this.textBoxPrimerApellido.Name = "textBoxPrimerApellido";
            this.textBoxPrimerApellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrimerApellido.TabIndex = 22;
            this.textBoxPrimerApellido.TextChanged += new System.EventHandler(this.textBoxSegundoApellido_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(108, 42);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 21;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(108, 17);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 20;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Identificacion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Primer Apellido";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Segundo Apellido";
            // 
            // buttonAgregarUsuario
            // 
            this.buttonAgregarUsuario.Location = new System.Drawing.Point(217, 12);
            this.buttonAgregarUsuario.Name = "buttonAgregarUsuario";
            this.buttonAgregarUsuario.Size = new System.Drawing.Size(520, 23);
            this.buttonAgregarUsuario.TabIndex = 34;
            this.buttonAgregarUsuario.Text = "Agregar un Nuevo Usuario";
            this.buttonAgregarUsuario.UseVisualStyleBackColor = true;
            this.buttonAgregarUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCodigoAsociado
            // 
            this.textBoxCodigoAsociado.Location = new System.Drawing.Point(108, 132);
            this.textBoxCodigoAsociado.Name = "textBoxCodigoAsociado";
            this.textBoxCodigoAsociado.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoAsociado.TabIndex = 39;
            this.textBoxCodigoAsociado.TextChanged += new System.EventHandler(this.textBoxCodigoAsociado_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Codigo de Asociado";
            // 
            // Gestion_de_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCodigoAsociado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonAgregarUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVolverMenu);
            this.Controls.Add(this.buttonModificarLibro);
            this.Controls.Add(this.buttonEliminarUsuario);
            this.Controls.Add(this.textBoxSegundoApellido);
            this.Controls.Add(this.textBoxPrimerApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxId);
            this.Name = "Gestion_de_Usuarios";
            this.Text = "Gestion_de_Usuarios";
            this.Load += new System.EventHandler(this.Gestion_de_Usuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolverMenu;
        private System.Windows.Forms.Button buttonModificarLibro;
        private System.Windows.Forms.Button buttonEliminarUsuario;
        private System.Windows.Forms.TextBox textBoxSegundoApellido;
        private System.Windows.Forms.TextBox textBoxPrimerApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAgregarUsuario;
        private System.Windows.Forms.TextBox textBoxCodigoAsociado;
        private System.Windows.Forms.Label label8;
    }
}