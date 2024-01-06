
namespace TP_Integrados_Programacion
{
    partial class FormVisualizacionGeneral
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DG_Administrativo = new System.Windows.Forms.DataGridView();
            this.DG_Empleados = new System.Windows.Forms.DataGridView();
            this.DG_Peliculas = new System.Windows.Forms.DataGridView();
            this.DG_Sucursales = new System.Windows.Forms.DataGridView();
            this.BT_Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Administrativo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Empleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Peliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Sucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrativos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empleados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peliculas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sucursales";
            // 
            // DG_Administrativo
            // 
            this.DG_Administrativo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Administrativo.Location = new System.Drawing.Point(13, 41);
            this.DG_Administrativo.Name = "DG_Administrativo";
            this.DG_Administrativo.Size = new System.Drawing.Size(240, 207);
            this.DG_Administrativo.TabIndex = 4;
            // 
            // DG_Empleados
            // 
            this.DG_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Empleados.Location = new System.Drawing.Point(405, 41);
            this.DG_Empleados.Name = "DG_Empleados";
            this.DG_Empleados.Size = new System.Drawing.Size(240, 207);
            this.DG_Empleados.TabIndex = 5;
            // 
            // DG_Peliculas
            // 
            this.DG_Peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Peliculas.Location = new System.Drawing.Point(12, 283);
            this.DG_Peliculas.Name = "DG_Peliculas";
            this.DG_Peliculas.Size = new System.Drawing.Size(240, 207);
            this.DG_Peliculas.TabIndex = 6;
            // 
            // DG_Sucursales
            // 
            this.DG_Sucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Sucursales.Location = new System.Drawing.Point(405, 284);
            this.DG_Sucursales.Name = "DG_Sucursales";
            this.DG_Sucursales.Size = new System.Drawing.Size(240, 207);
            this.DG_Sucursales.TabIndex = 7;
            // 
            // BT_Volver
            // 
            this.BT_Volver.Location = new System.Drawing.Point(713, 12);
            this.BT_Volver.Name = "BT_Volver";
            this.BT_Volver.Size = new System.Drawing.Size(75, 23);
            this.BT_Volver.TabIndex = 17;
            this.BT_Volver.Text = "Volver";
            this.BT_Volver.UseVisualStyleBackColor = true;
            this.BT_Volver.Click += new System.EventHandler(this.BT_Volver_Click);
            // 
            // FormVisualizacionGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.BT_Volver);
            this.Controls.Add(this.DG_Sucursales);
            this.Controls.Add(this.DG_Peliculas);
            this.Controls.Add(this.DG_Empleados);
            this.Controls.Add(this.DG_Administrativo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVisualizacionGeneral";
            this.Text = "FormVisualizacionGeneral";
            ((System.ComponentModel.ISupportInitialize)(this.DG_Administrativo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Empleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Peliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Sucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DG_Administrativo;
        private System.Windows.Forms.DataGridView DG_Empleados;
        private System.Windows.Forms.DataGridView DG_Peliculas;
        private System.Windows.Forms.DataGridView DG_Sucursales;
        private System.Windows.Forms.Button BT_Volver;
    }
}