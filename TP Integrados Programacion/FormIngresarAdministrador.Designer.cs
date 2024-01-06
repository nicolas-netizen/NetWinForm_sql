
namespace TP_Integrados_Programacion
{
    partial class FormIngresarAdministrador
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
            this.TB_CrearAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_NombreAdmin = new System.Windows.Forms.TextBox();
            this.TB_ApellidoAdmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_CuilAdmin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_EdadAdmin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_HorarioAdmin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Sector = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BT_VolverAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_CrearAdmin
            // 
            this.TB_CrearAdmin.Location = new System.Drawing.Point(49, 282);
            this.TB_CrearAdmin.Name = "TB_CrearAdmin";
            this.TB_CrearAdmin.Size = new System.Drawing.Size(75, 23);
            this.TB_CrearAdmin.TabIndex = 0;
            this.TB_CrearAdmin.Text = "Crear";
            this.TB_CrearAdmin.UseVisualStyleBackColor = true;
            this.TB_CrearAdmin.Click += new System.EventHandler(this.TB_CrearAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // TB_NombreAdmin
            // 
            this.TB_NombreAdmin.Location = new System.Drawing.Point(12, 47);
            this.TB_NombreAdmin.Name = "TB_NombreAdmin";
            this.TB_NombreAdmin.Size = new System.Drawing.Size(158, 20);
            this.TB_NombreAdmin.TabIndex = 2;
            // 
            // TB_ApellidoAdmin
            // 
            this.TB_ApellidoAdmin.Location = new System.Drawing.Point(12, 86);
            this.TB_ApellidoAdmin.Name = "TB_ApellidoAdmin";
            this.TB_ApellidoAdmin.Size = new System.Drawing.Size(158, 20);
            this.TB_ApellidoAdmin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // TB_CuilAdmin
            // 
            this.TB_CuilAdmin.Location = new System.Drawing.Point(12, 125);
            this.TB_CuilAdmin.Name = "TB_CuilAdmin";
            this.TB_CuilAdmin.Size = new System.Drawing.Size(158, 20);
            this.TB_CuilAdmin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cuil";
            // 
            // TB_EdadAdmin
            // 
            this.TB_EdadAdmin.Location = new System.Drawing.Point(12, 164);
            this.TB_EdadAdmin.Name = "TB_EdadAdmin";
            this.TB_EdadAdmin.Size = new System.Drawing.Size(158, 20);
            this.TB_EdadAdmin.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edad";
            // 
            // TB_HorarioAdmin
            // 
            this.TB_HorarioAdmin.Location = new System.Drawing.Point(12, 203);
            this.TB_HorarioAdmin.Name = "TB_HorarioAdmin";
            this.TB_HorarioAdmin.Size = new System.Drawing.Size(158, 20);
            this.TB_HorarioAdmin.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Horario De Trabajo";
            // 
            // TB_Sector
            // 
            this.TB_Sector.Location = new System.Drawing.Point(12, 242);
            this.TB_Sector.Name = "TB_Sector";
            this.TB_Sector.Size = new System.Drawing.Size(158, 20);
            this.TB_Sector.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sector Que Administra";
            // 
            // BT_VolverAdmin
            // 
            this.BT_VolverAdmin.Location = new System.Drawing.Point(191, 12);
            this.BT_VolverAdmin.Name = "BT_VolverAdmin";
            this.BT_VolverAdmin.Size = new System.Drawing.Size(75, 23);
            this.BT_VolverAdmin.TabIndex = 13;
            this.BT_VolverAdmin.Text = "Volver";
            this.BT_VolverAdmin.UseVisualStyleBackColor = true;
            this.BT_VolverAdmin.Click += new System.EventHandler(this.BT_VolverAdmin_Click);
            // 
            // FormIngresarAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 327);
            this.Controls.Add(this.BT_VolverAdmin);
            this.Controls.Add(this.TB_Sector);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_HorarioAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_EdadAdmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_CuilAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_ApellidoAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_NombreAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_CrearAdmin);
            this.Name = "FormIngresarAdministrador";
            this.Text = "FormIngresarAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TB_CrearAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_NombreAdmin;
        private System.Windows.Forms.TextBox TB_ApellidoAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_CuilAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_EdadAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_HorarioAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Sector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_VolverAdmin;
    }
}