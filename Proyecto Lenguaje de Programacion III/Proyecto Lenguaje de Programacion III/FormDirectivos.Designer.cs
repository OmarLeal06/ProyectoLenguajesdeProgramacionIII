namespace Proyecto_Lenguaje_de_Programacion_III
{
    partial class FormDirectivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDirectivos));
            this.dgvDirectivos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbNumeroEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarDirectivo = new System.Windows.Forms.Button();
            this.btnEliminarDirectivo = new System.Windows.Forms.Button();
            this.btnModificarDirectivo = new System.Windows.Forms.Button();
            this.btnAgregarDirectivo = new System.Windows.Forms.Button();
            this.txtbPrestacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbCentroSupervisado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNumeroDirectivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectivos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDirectivos
            // 
            this.dgvDirectivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectivos.Location = new System.Drawing.Point(14, 272);
            this.dgvDirectivos.Name = "dgvDirectivos";
            this.dgvDirectivos.Size = new System.Drawing.Size(776, 197);
            this.dgvDirectivos.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbNumeroEmpleado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBuscarDirectivo);
            this.groupBox1.Controls.Add(this.btnEliminarDirectivo);
            this.groupBox1.Controls.Add(this.btnModificarDirectivo);
            this.groupBox1.Controls.Add(this.btnAgregarDirectivo);
            this.groupBox1.Controls.Add(this.txtbPrestacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbCentroSupervisado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbNumeroDirectivo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Directivo";
            // 
            // txtbNumeroEmpleado
            // 
            this.txtbNumeroEmpleado.Location = new System.Drawing.Point(9, 174);
            this.txtbNumeroEmpleado.Name = "txtbNumeroEmpleado";
            this.txtbNumeroEmpleado.Size = new System.Drawing.Size(265, 20);
            this.txtbNumeroEmpleado.TabIndex = 13;
            this.txtbNumeroEmpleado.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Número de Empleado:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnBuscarDirectivo
            // 
            this.btnBuscarDirectivo.Location = new System.Drawing.Point(334, 37);
            this.btnBuscarDirectivo.Name = "btnBuscarDirectivo";
            this.btnBuscarDirectivo.Size = new System.Drawing.Size(80, 36);
            this.btnBuscarDirectivo.TabIndex = 11;
            this.btnBuscarDirectivo.Text = "Buscar";
            this.btnBuscarDirectivo.UseVisualStyleBackColor = true;
            this.btnBuscarDirectivo.Click += new System.EventHandler(this.btnBuscarDirectivo_Click);
            // 
            // btnEliminarDirectivo
            // 
            this.btnEliminarDirectivo.Location = new System.Drawing.Point(229, 201);
            this.btnEliminarDirectivo.Name = "btnEliminarDirectivo";
            this.btnEliminarDirectivo.Size = new System.Drawing.Size(87, 36);
            this.btnEliminarDirectivo.TabIndex = 10;
            this.btnEliminarDirectivo.Text = "Eliminar";
            this.btnEliminarDirectivo.UseVisualStyleBackColor = true;
            this.btnEliminarDirectivo.Click += new System.EventHandler(this.btnEliminarDirectivo_Click);
            // 
            // btnModificarDirectivo
            // 
            this.btnModificarDirectivo.Location = new System.Drawing.Point(119, 201);
            this.btnModificarDirectivo.Name = "btnModificarDirectivo";
            this.btnModificarDirectivo.Size = new System.Drawing.Size(87, 36);
            this.btnModificarDirectivo.TabIndex = 9;
            this.btnModificarDirectivo.Text = "Modificar";
            this.btnModificarDirectivo.UseVisualStyleBackColor = true;
            this.btnModificarDirectivo.Click += new System.EventHandler(this.btnModificarDirectivo_Click);
            // 
            // btnAgregarDirectivo
            // 
            this.btnAgregarDirectivo.Location = new System.Drawing.Point(18, 201);
            this.btnAgregarDirectivo.Name = "btnAgregarDirectivo";
            this.btnAgregarDirectivo.Size = new System.Drawing.Size(75, 36);
            this.btnAgregarDirectivo.TabIndex = 8;
            this.btnAgregarDirectivo.Text = "Agregar";
            this.btnAgregarDirectivo.UseVisualStyleBackColor = true;
            this.btnAgregarDirectivo.Click += new System.EventHandler(this.btnAgregarDirectivo_Click);
            // 
            // txtbPrestacion
            // 
            this.txtbPrestacion.Location = new System.Drawing.Point(9, 124);
            this.txtbPrestacion.Name = "txtbPrestacion";
            this.txtbPrestacion.Size = new System.Drawing.Size(265, 20);
            this.txtbPrestacion.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prestación:";
            // 
            // txtbCentroSupervisado
            // 
            this.txtbCentroSupervisado.Location = new System.Drawing.Point(9, 85);
            this.txtbCentroSupervisado.Name = "txtbCentroSupervisado";
            this.txtbCentroSupervisado.Size = new System.Drawing.Size(265, 20);
            this.txtbCentroSupervisado.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Centro Supervisado:";
            // 
            // txtbNumeroDirectivo
            // 
            this.txtbNumeroDirectivo.Location = new System.Drawing.Point(6, 46);
            this.txtbNumeroDirectivo.Name = "txtbNumeroDirectivo";
            this.txtbNumeroDirectivo.Size = new System.Drawing.Size(265, 20);
            this.txtbNumeroDirectivo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número del Directivo:";
            // 
            // FormDirectivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 476);
            this.Controls.Add(this.dgvDirectivos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDirectivos";
            this.Text = "Menú Directivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectivos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDirectivos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarDirectivo;
        private System.Windows.Forms.Button btnEliminarDirectivo;
        private System.Windows.Forms.Button btnModificarDirectivo;
        private System.Windows.Forms.Button btnAgregarDirectivo;
        private System.Windows.Forms.TextBox txtbPrestacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbCentroSupervisado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbNumeroDirectivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNumeroEmpleado;
        private System.Windows.Forms.Label label4;
    }
}