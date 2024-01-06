
namespace TP_Integrados_Programacion
{
    partial class FormVentaDeBoletos
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
            this.BT_Volver = new System.Windows.Forms.Button();
            this.TB_NombreCli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_EmpleadoAsig = new System.Windows.Forms.ComboBox();
            this.CB_PeliculasElegir = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_Venta = new System.Windows.Forms.Button();
            this.CB_SucursalVenta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_Volver
            // 
            this.BT_Volver.Location = new System.Drawing.Point(191, 10);
            this.BT_Volver.Name = "BT_Volver";
            this.BT_Volver.Size = new System.Drawing.Size(75, 23);
            this.BT_Volver.TabIndex = 16;
            this.BT_Volver.Text = "Volver";
            this.BT_Volver.UseVisualStyleBackColor = true;
            this.BT_Volver.Click += new System.EventHandler(this.BT_Volver_Click);
            // 
            // TB_NombreCli
            // 
            this.TB_NombreCli.Location = new System.Drawing.Point(12, 45);
            this.TB_NombreCli.Name = "TB_NombreCli";
            this.TB_NombreCli.Size = new System.Drawing.Size(158, 20);
            this.TB_NombreCli.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Emplado Que Lo atendio";
            // 
            // CB_EmpleadoAsig
            // 
            this.CB_EmpleadoAsig.FormattingEnabled = true;
            this.CB_EmpleadoAsig.Location = new System.Drawing.Point(12, 93);
            this.CB_EmpleadoAsig.Name = "CB_EmpleadoAsig";
            this.CB_EmpleadoAsig.Size = new System.Drawing.Size(158, 21);
            this.CB_EmpleadoAsig.TabIndex = 18;
            // 
            // CB_PeliculasElegir
            // 
            this.CB_PeliculasElegir.FormattingEnabled = true;
            this.CB_PeliculasElegir.Location = new System.Drawing.Point(12, 146);
            this.CB_PeliculasElegir.Name = "CB_PeliculasElegir";
            this.CB_PeliculasElegir.Size = new System.Drawing.Size(158, 21);
            this.CB_PeliculasElegir.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pelicula que eligio";
            // 
            // BT_Venta
            // 
            this.BT_Venta.Location = new System.Drawing.Point(49, 234);
            this.BT_Venta.Name = "BT_Venta";
            this.BT_Venta.Size = new System.Drawing.Size(75, 23);
            this.BT_Venta.TabIndex = 21;
            this.BT_Venta.Text = "Vender";
            this.BT_Venta.UseVisualStyleBackColor = true;
            this.BT_Venta.Click += new System.EventHandler(this.BT_Venta_Click);
            // 
            // CB_SucursalVenta
            // 
            this.CB_SucursalVenta.FormattingEnabled = true;
            this.CB_SucursalVenta.Location = new System.Drawing.Point(12, 196);
            this.CB_SucursalVenta.Name = "CB_SucursalVenta";
            this.CB_SucursalVenta.Size = new System.Drawing.Size(158, 21);
            this.CB_SucursalVenta.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Sucursal donde se vendio";
            // 
            // FormVentaDeBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 269);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_SucursalVenta);
            this.Controls.Add(this.BT_Venta);
            this.Controls.Add(this.CB_PeliculasElegir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_EmpleadoAsig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BT_Volver);
            this.Controls.Add(this.TB_NombreCli);
            this.Controls.Add(this.label1);
            this.Name = "FormVentaDeBoletos";
            this.Text = "FormVentaDeBoletos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Volver;
        private System.Windows.Forms.TextBox TB_NombreCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_EmpleadoAsig;
        private System.Windows.Forms.ComboBox CB_PeliculasElegir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_Venta;
        private System.Windows.Forms.ComboBox CB_SucursalVenta;
        private System.Windows.Forms.Label label4;
    }
}