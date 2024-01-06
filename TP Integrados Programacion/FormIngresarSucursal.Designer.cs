
namespace TP_Integrados_Programacion
{
    partial class FormIngresarSucursal
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
            this.BT_VolverAdmin = new System.Windows.Forms.Button();
            this.TB_NombreSucursal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Direccion = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.TB_HorarioS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_CrearSucursal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_VolverAdmin
            // 
            this.BT_VolverAdmin.Location = new System.Drawing.Point(157, 15);
            this.BT_VolverAdmin.Name = "BT_VolverAdmin";
            this.BT_VolverAdmin.Size = new System.Drawing.Size(75, 23);
            this.BT_VolverAdmin.TabIndex = 16;
            this.BT_VolverAdmin.Text = "Volver";
            this.BT_VolverAdmin.UseVisualStyleBackColor = true;
            this.BT_VolverAdmin.Click += new System.EventHandler(this.BT_VolverAdmin_Click);
            // 
            // TB_NombreSucursal
            // 
            this.TB_NombreSucursal.Location = new System.Drawing.Point(39, 54);
            this.TB_NombreSucursal.Name = "TB_NombreSucursal";
            this.TB_NombreSucursal.Size = new System.Drawing.Size(158, 20);
            this.TB_NombreSucursal.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // TB_Direccion
            // 
            this.TB_Direccion.Location = new System.Drawing.Point(39, 93);
            this.TB_Direccion.Name = "TB_Direccion";
            this.TB_Direccion.Size = new System.Drawing.Size(158, 20);
            this.TB_Direccion.TabIndex = 18;
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(39, 77);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(44, 13);
            this.Direccion.TabIndex = 17;
            this.Direccion.Text = "Nombre";
            // 
            // TB_HorarioS
            // 
            this.TB_HorarioS.Location = new System.Drawing.Point(39, 133);
            this.TB_HorarioS.Name = "TB_HorarioS";
            this.TB_HorarioS.Size = new System.Drawing.Size(158, 20);
            this.TB_HorarioS.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Horario De Apertura Y Cierre";
            // 
            // BT_CrearSucursal
            // 
            this.BT_CrearSucursal.Location = new System.Drawing.Point(93, 159);
            this.BT_CrearSucursal.Name = "BT_CrearSucursal";
            this.BT_CrearSucursal.Size = new System.Drawing.Size(75, 23);
            this.BT_CrearSucursal.TabIndex = 21;
            this.BT_CrearSucursal.Text = "Crear";
            this.BT_CrearSucursal.UseVisualStyleBackColor = true;
            this.BT_CrearSucursal.Click += new System.EventHandler(this.BT_CrearSucursal_Click);
            // 
            // FormIngresarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 188);
            this.Controls.Add(this.BT_CrearSucursal);
            this.Controls.Add(this.TB_HorarioS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Direccion);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.BT_VolverAdmin);
            this.Controls.Add(this.TB_NombreSucursal);
            this.Controls.Add(this.label1);
            this.Name = "FormIngresarSucursal";
            this.Text = "FormIngresarSucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_VolverAdmin;
        private System.Windows.Forms.TextBox TB_NombreSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Direccion;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.TextBox TB_HorarioS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_CrearSucursal;
    }
}