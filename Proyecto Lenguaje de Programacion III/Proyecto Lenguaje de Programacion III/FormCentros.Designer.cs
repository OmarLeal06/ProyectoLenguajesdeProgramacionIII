namespace Proyecto_Lenguaje_de_Programacion_III
{
    partial class FormCentros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCentros));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCentro = new System.Windows.Forms.Button();
            this.btnEliminarCentro = new System.Windows.Forms.Button();
            this.btnModificarCentro = new System.Windows.Forms.Button();
            this.btnAgregarCentro = new System.Windows.Forms.Button();
            this.txtbCiudad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbNombreCentro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNumeroCentro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCentros = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarCentro);
            this.groupBox1.Controls.Add(this.btnEliminarCentro);
            this.groupBox1.Controls.Add(this.btnModificarCentro);
            this.groupBox1.Controls.Add(this.btnAgregarCentro);
            this.groupBox1.Controls.Add(this.txtbCiudad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbNombreCentro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbNumeroCentro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Centro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBuscarCentro
            // 
            this.btnBuscarCentro.Location = new System.Drawing.Point(334, 37);
            this.btnBuscarCentro.Name = "btnBuscarCentro";
            this.btnBuscarCentro.Size = new System.Drawing.Size(80, 36);
            this.btnBuscarCentro.TabIndex = 11;
            this.btnBuscarCentro.Text = "Buscar";
            this.btnBuscarCentro.UseVisualStyleBackColor = true;
            this.btnBuscarCentro.Click += new System.EventHandler(this.btnBuscarCentro_Click);
            // 
            // btnEliminarCentro
            // 
            this.btnEliminarCentro.Location = new System.Drawing.Point(229, 184);
            this.btnEliminarCentro.Name = "btnEliminarCentro";
            this.btnEliminarCentro.Size = new System.Drawing.Size(87, 36);
            this.btnEliminarCentro.TabIndex = 10;
            this.btnEliminarCentro.Text = "Eliminar";
            this.btnEliminarCentro.UseVisualStyleBackColor = true;
            this.btnEliminarCentro.Click += new System.EventHandler(this.btnEliminarCentro_Click);
            // 
            // btnModificarCentro
            // 
            this.btnModificarCentro.Location = new System.Drawing.Point(118, 184);
            this.btnModificarCentro.Name = "btnModificarCentro";
            this.btnModificarCentro.Size = new System.Drawing.Size(87, 36);
            this.btnModificarCentro.TabIndex = 9;
            this.btnModificarCentro.Text = "Modificar";
            this.btnModificarCentro.UseVisualStyleBackColor = true;
            this.btnModificarCentro.Click += new System.EventHandler(this.btnModificarCentro_Click);
            // 
            // btnAgregarCentro
            // 
            this.btnAgregarCentro.Location = new System.Drawing.Point(27, 184);
            this.btnAgregarCentro.Name = "btnAgregarCentro";
            this.btnAgregarCentro.Size = new System.Drawing.Size(75, 36);
            this.btnAgregarCentro.TabIndex = 8;
            this.btnAgregarCentro.Text = "Agregar";
            this.btnAgregarCentro.UseVisualStyleBackColor = true;
            this.btnAgregarCentro.Click += new System.EventHandler(this.btnAgregarCentro_Click);
            // 
            // txtbCiudad
            // 
            this.txtbCiudad.Location = new System.Drawing.Point(9, 133);
            this.txtbCiudad.Name = "txtbCiudad";
            this.txtbCiudad.Size = new System.Drawing.Size(265, 20);
            this.txtbCiudad.TabIndex = 7;
            this.txtbCiudad.TextChanged += new System.EventHandler(this.txtbCiudad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ciudad:";
            // 
            // txtbNombreCentro
            // 
            this.txtbNombreCentro.Location = new System.Drawing.Point(9, 85);
            this.txtbNombreCentro.Name = "txtbNombreCentro";
            this.txtbNombreCentro.Size = new System.Drawing.Size(265, 20);
            this.txtbNombreCentro.TabIndex = 5;
            this.txtbNombreCentro.TextChanged += new System.EventHandler(this.txtbNombreCentro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de Centro:";
            // 
            // txtbNumeroCentro
            // 
            this.txtbNumeroCentro.Location = new System.Drawing.Point(6, 46);
            this.txtbNumeroCentro.Name = "txtbNumeroCentro";
            this.txtbNumeroCentro.Size = new System.Drawing.Size(265, 20);
            this.txtbNumeroCentro.TabIndex = 3;
            this.txtbNumeroCentro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de Centro:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvCentros
            // 
            this.dgvCentros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCentros.Location = new System.Drawing.Point(12, 276);
            this.dgvCentros.Name = "dgvCentros";
            this.dgvCentros.Size = new System.Drawing.Size(776, 197);
            this.dgvCentros.TabIndex = 1;
            // 
            // FormCentros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.dgvCentros);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCentros";
            this.Text = "Menú Centros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCentros;
        private System.Windows.Forms.TextBox txtbNumeroCentro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbCiudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbNombreCentro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarCentro;
        private System.Windows.Forms.Button btnEliminarCentro;
        private System.Windows.Forms.Button btnModificarCentro;
        private System.Windows.Forms.Button btnAgregarCentro;
    }
}