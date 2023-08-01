namespace Proyecto_Lenguaje_de_Programacion_III
{
    partial class FormPuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPuestos));
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPuesto = new System.Windows.Forms.Button();
            this.btnEliminarPuesto = new System.Windows.Forms.Button();
            this.btnModificarPuesto = new System.Windows.Forms.Button();
            this.btnAgregarPuesto = new System.Windows.Forms.Button();
            this.txtbDescripcionPuesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbNombrePuesto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNumeroPuesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPuestos
            // 
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Location = new System.Drawing.Point(12, 271);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.Size = new System.Drawing.Size(776, 197);
            this.dgvPuestos.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarPuesto);
            this.groupBox1.Controls.Add(this.btnEliminarPuesto);
            this.groupBox1.Controls.Add(this.btnModificarPuesto);
            this.groupBox1.Controls.Add(this.btnAgregarPuesto);
            this.groupBox1.Controls.Add(this.txtbDescripcionPuesto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbNombrePuesto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbNumeroPuesto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Puesto";
            // 
            // btnBuscarPuesto
            // 
            this.btnBuscarPuesto.Location = new System.Drawing.Point(334, 37);
            this.btnBuscarPuesto.Name = "btnBuscarPuesto";
            this.btnBuscarPuesto.Size = new System.Drawing.Size(80, 36);
            this.btnBuscarPuesto.TabIndex = 11;
            this.btnBuscarPuesto.Text = "Buscar";
            this.btnBuscarPuesto.UseVisualStyleBackColor = true;
            this.btnBuscarPuesto.Click += new System.EventHandler(this.btnBuscarPuesto_Click);
            // 
            // btnEliminarPuesto
            // 
            this.btnEliminarPuesto.Location = new System.Drawing.Point(229, 184);
            this.btnEliminarPuesto.Name = "btnEliminarPuesto";
            this.btnEliminarPuesto.Size = new System.Drawing.Size(87, 36);
            this.btnEliminarPuesto.TabIndex = 10;
            this.btnEliminarPuesto.Text = "Eliminar";
            this.btnEliminarPuesto.UseVisualStyleBackColor = true;
            this.btnEliminarPuesto.Click += new System.EventHandler(this.btnEliminarPuesto_Click);
            // 
            // btnModificarPuesto
            // 
            this.btnModificarPuesto.Location = new System.Drawing.Point(118, 184);
            this.btnModificarPuesto.Name = "btnModificarPuesto";
            this.btnModificarPuesto.Size = new System.Drawing.Size(87, 36);
            this.btnModificarPuesto.TabIndex = 9;
            this.btnModificarPuesto.Text = "Modificar";
            this.btnModificarPuesto.UseVisualStyleBackColor = true;
            this.btnModificarPuesto.Click += new System.EventHandler(this.btnModificarPuesto_Click);
            // 
            // btnAgregarPuesto
            // 
            this.btnAgregarPuesto.Location = new System.Drawing.Point(27, 184);
            this.btnAgregarPuesto.Name = "btnAgregarPuesto";
            this.btnAgregarPuesto.Size = new System.Drawing.Size(75, 36);
            this.btnAgregarPuesto.TabIndex = 8;
            this.btnAgregarPuesto.Text = "Agregar";
            this.btnAgregarPuesto.UseVisualStyleBackColor = true;
            this.btnAgregarPuesto.Click += new System.EventHandler(this.btnAgregarPuesto_Click);
            // 
            // txtbDescripcionPuesto
            // 
            this.txtbDescripcionPuesto.Location = new System.Drawing.Point(9, 133);
            this.txtbDescripcionPuesto.Name = "txtbDescripcionPuesto";
            this.txtbDescripcionPuesto.Size = new System.Drawing.Size(265, 20);
            this.txtbDescripcionPuesto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripción del Puesto:";
            // 
            // txtbNombrePuesto
            // 
            this.txtbNombrePuesto.Location = new System.Drawing.Point(9, 85);
            this.txtbNombrePuesto.Name = "txtbNombrePuesto";
            this.txtbNombrePuesto.Size = new System.Drawing.Size(265, 20);
            this.txtbNombrePuesto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de Puesto:";
            // 
            // txtbNumeroPuesto
            // 
            this.txtbNumeroPuesto.Location = new System.Drawing.Point(6, 46);
            this.txtbNumeroPuesto.Name = "txtbNumeroPuesto";
            this.txtbNumeroPuesto.Size = new System.Drawing.Size(265, 20);
            this.txtbNumeroPuesto.TabIndex = 3;
            this.txtbNumeroPuesto.TextChanged += new System.EventHandler(this.txtbNumeroPuesto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de Puesto:";
            // 
            // FormPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.dgvPuestos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPuestos";
            this.Text = "Menú Puestos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPuestos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarPuesto;
        private System.Windows.Forms.Button btnEliminarPuesto;
        private System.Windows.Forms.Button btnModificarPuesto;
        private System.Windows.Forms.Button btnAgregarPuesto;
        private System.Windows.Forms.TextBox txtbDescripcionPuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbNombrePuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbNumeroPuesto;
        private System.Windows.Forms.Label label1;
    }
}