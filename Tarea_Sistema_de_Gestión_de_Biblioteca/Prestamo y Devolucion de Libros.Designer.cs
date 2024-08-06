
namespace Tarea_Sistema_de_Gestión_de_Biblioteca
{
    partial class Prestamo_y_Devolucion_de_Libros
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
            this.buttonPrestar = new System.Windows.Forms.Button();
            this.buttonDevolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCodigoAsociado = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxFE = new System.Windows.Forms.TextBox();
            this.textBoxFD = new System.Windows.Forms.TextBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPrestar
            // 
            this.buttonPrestar.Location = new System.Drawing.Point(43, 176);
            this.buttonPrestar.Name = "buttonPrestar";
            this.buttonPrestar.Size = new System.Drawing.Size(145, 23);
            this.buttonPrestar.TabIndex = 0;
            this.buttonPrestar.Text = "Prestar";
            this.buttonPrestar.UseVisualStyleBackColor = true;
            this.buttonPrestar.Click += new System.EventHandler(this.buttonPrestar_Click);
            // 
            // buttonDevolver
            // 
            this.buttonDevolver.Location = new System.Drawing.Point(253, 176);
            this.buttonDevolver.Name = "buttonDevolver";
            this.buttonDevolver.Size = new System.Drawing.Size(151, 23);
            this.buttonDevolver.TabIndex = 1;
            this.buttonDevolver.Text = "Devolver";
            this.buttonDevolver.UseVisualStyleBackColor = true;
            this.buttonDevolver.Click += new System.EventHandler(this.buttonDevolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo de Asociado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Entrega";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de Devolucion";
            // 
            // textBoxCodigoAsociado
            // 
            this.textBoxCodigoAsociado.Location = new System.Drawing.Point(167, 20);
            this.textBoxCodigoAsociado.Name = "textBoxCodigoAsociado";
            this.textBoxCodigoAsociado.Size = new System.Drawing.Size(237, 20);
            this.textBoxCodigoAsociado.TabIndex = 6;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(167, 61);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(237, 20);
            this.textBoxISBN.TabIndex = 7;
            this.textBoxISBN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxFE
            // 
            this.textBoxFE.Location = new System.Drawing.Point(167, 99);
            this.textBoxFE.Name = "textBoxFE";
            this.textBoxFE.Size = new System.Drawing.Size(237, 20);
            this.textBoxFE.TabIndex = 8;
            this.textBoxFE.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBoxFD
            // 
            this.textBoxFD.Location = new System.Drawing.Point(167, 140);
            this.textBoxFD.Name = "textBoxFD";
            this.textBoxFD.Size = new System.Drawing.Size(237, 20);
            this.textBoxFD.TabIndex = 9;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(43, 242);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(145, 23);
            this.buttonMenu.TabIndex = 10;
            this.buttonMenu.Text = "Volver al Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // Prestamo_y_Devolucion_de_Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.textBoxFD);
            this.Controls.Add(this.textBoxFE);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBoxCodigoAsociado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDevolver);
            this.Controls.Add(this.buttonPrestar);
            this.Name = "Prestamo_y_Devolucion_de_Libros";
            this.Text = "Prestamo_y_Devolucion_de_Libros";
            this.Load += new System.EventHandler(this.Prestamo_y_Devolucion_de_Libros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrestar;
        private System.Windows.Forms.Button buttonDevolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCodigoAsociado;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxFE;
        private System.Windows.Forms.TextBox textBoxFD;
        private System.Windows.Forms.Button buttonMenu;
    }
}