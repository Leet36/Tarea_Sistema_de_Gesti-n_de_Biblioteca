
namespace Tarea_Sistema_de_Gestión_de_Biblioteca
{
    partial class Buscador
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
            this.radioButtonISBN = new System.Windows.Forms.RadioButton();
            this.radioButtonTitulo = new System.Windows.Forms.RadioButton();
            this.radioButtonAutor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBusquedaLibros = new System.Windows.Forms.Button();
            this.dataGridViewConsultaLibros = new System.Windows.Forms.DataGridView();
            this.textBoxBusquedaLibros = new System.Windows.Forms.TextBox();
            this.buttonConsultaGlobal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultaLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolverMenu
            // 
            this.buttonVolverMenu.Location = new System.Drawing.Point(534, 357);
            this.buttonVolverMenu.Name = "buttonVolverMenu";
            this.buttonVolverMenu.Size = new System.Drawing.Size(191, 62);
            this.buttonVolverMenu.TabIndex = 20;
            this.buttonVolverMenu.Text = "Volver al Menu";
            this.buttonVolverMenu.UseVisualStyleBackColor = true;
            this.buttonVolverMenu.Click += new System.EventHandler(this.buttonVolverMenu_Click);
            // 
            // radioButtonISBN
            // 
            this.radioButtonISBN.AutoSize = true;
            this.radioButtonISBN.Location = new System.Drawing.Point(12, 386);
            this.radioButtonISBN.Name = "radioButtonISBN";
            this.radioButtonISBN.Size = new System.Drawing.Size(50, 17);
            this.radioButtonISBN.TabIndex = 21;
            this.radioButtonISBN.TabStop = true;
            this.radioButtonISBN.Text = "ISBN";
            this.radioButtonISBN.UseVisualStyleBackColor = true;
            this.radioButtonISBN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonTitulo
            // 
            this.radioButtonTitulo.AutoSize = true;
            this.radioButtonTitulo.Location = new System.Drawing.Point(68, 386);
            this.radioButtonTitulo.Name = "radioButtonTitulo";
            this.radioButtonTitulo.Size = new System.Drawing.Size(51, 17);
            this.radioButtonTitulo.TabIndex = 22;
            this.radioButtonTitulo.TabStop = true;
            this.radioButtonTitulo.Text = "Titulo";
            this.radioButtonTitulo.UseVisualStyleBackColor = true;
            this.radioButtonTitulo.CheckedChanged += new System.EventHandler(this.radioButtonTitulo_CheckedChanged);
            // 
            // radioButtonAutor
            // 
            this.radioButtonAutor.AutoSize = true;
            this.radioButtonAutor.Location = new System.Drawing.Point(130, 386);
            this.radioButtonAutor.Name = "radioButtonAutor";
            this.radioButtonAutor.Size = new System.Drawing.Size(50, 17);
            this.radioButtonAutor.TabIndex = 23;
            this.radioButtonAutor.TabStop = true;
            this.radioButtonAutor.Text = "Autor";
            this.radioButtonAutor.UseVisualStyleBackColor = true;
            this.radioButtonAutor.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Seleccione la opcion, con la cual desea realizar la busqueda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonBusquedaLibros
            // 
            this.buttonBusquedaLibros.Location = new System.Drawing.Point(186, 360);
            this.buttonBusquedaLibros.Name = "buttonBusquedaLibros";
            this.buttonBusquedaLibros.Size = new System.Drawing.Size(116, 48);
            this.buttonBusquedaLibros.TabIndex = 25;
            this.buttonBusquedaLibros.Text = "Busqueda";
            this.buttonBusquedaLibros.UseVisualStyleBackColor = true;
            this.buttonBusquedaLibros.Click += new System.EventHandler(this.buttonBusquedaLibros_Click);
            // 
            // dataGridViewConsultaLibros
            // 
            this.dataGridViewConsultaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultaLibros.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewConsultaLibros.Name = "dataGridViewConsultaLibros";
            this.dataGridViewConsultaLibros.Size = new System.Drawing.Size(713, 304);
            this.dataGridViewConsultaLibros.TabIndex = 26;
            this.dataGridViewConsultaLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxBusquedaLibros
            // 
            this.textBoxBusquedaLibros.Location = new System.Drawing.Point(12, 360);
            this.textBoxBusquedaLibros.Name = "textBoxBusquedaLibros";
            this.textBoxBusquedaLibros.Size = new System.Drawing.Size(168, 20);
            this.textBoxBusquedaLibros.TabIndex = 27;
            this.textBoxBusquedaLibros.TextChanged += new System.EventHandler(this.textBoxBusquedaLibros_TextChanged);
            // 
            // buttonConsultaGlobal
            // 
            this.buttonConsultaGlobal.Location = new System.Drawing.Point(308, 357);
            this.buttonConsultaGlobal.Name = "buttonConsultaGlobal";
            this.buttonConsultaGlobal.Size = new System.Drawing.Size(220, 62);
            this.buttonConsultaGlobal.TabIndex = 28;
            this.buttonConsultaGlobal.Text = "Consulta Global";
            this.buttonConsultaGlobal.UseVisualStyleBackColor = true;
            this.buttonConsultaGlobal.Click += new System.EventHandler(this.button1_Click);
            // 
            // Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.buttonConsultaGlobal);
            this.Controls.Add(this.textBoxBusquedaLibros);
            this.Controls.Add(this.dataGridViewConsultaLibros);
            this.Controls.Add(this.buttonBusquedaLibros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonAutor);
            this.Controls.Add(this.radioButtonTitulo);
            this.Controls.Add(this.radioButtonISBN);
            this.Controls.Add(this.buttonVolverMenu);
            this.Name = "Buscador";
            this.Text = "Buscador";
            this.Load += new System.EventHandler(this.Buscador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultaLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolverMenu;
        private System.Windows.Forms.RadioButton radioButtonISBN;
        private System.Windows.Forms.RadioButton radioButtonTitulo;
        private System.Windows.Forms.RadioButton radioButtonAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBusquedaLibros;
        private System.Windows.Forms.DataGridView dataGridViewConsultaLibros;
        private System.Windows.Forms.TextBox textBoxBusquedaLibros;
        private System.Windows.Forms.Button buttonConsultaGlobal;
    }
}