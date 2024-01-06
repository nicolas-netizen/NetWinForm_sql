
namespace TP_Integrados_Programacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_RegistroAdmin = new System.Windows.Forms.Button();
            this.BT_Visualizar = new System.Windows.Forms.Button();
            this.BT_VentaDeBoletos = new System.Windows.Forms.Button();
            this.TB_RegistrarEmp = new System.Windows.Forms.Button();
            this.BT_IngresarPelicula = new System.Windows.Forms.Button();
            this.BT_IngresarSucursal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_RegistroAdmin
            // 
            this.BT_RegistroAdmin.Location = new System.Drawing.Point(204, 318);
            this.BT_RegistroAdmin.Name = "BT_RegistroAdmin";
            this.BT_RegistroAdmin.Size = new System.Drawing.Size(89, 41);
            this.BT_RegistroAdmin.TabIndex = 0;
            this.BT_RegistroAdmin.Text = "Registrar Administrador";
            this.BT_RegistroAdmin.UseVisualStyleBackColor = true;
            this.BT_RegistroAdmin.Click += new System.EventHandler(this.BT_RegistroAdmin_Click);
            // 
            // BT_Visualizar
            // 
            this.BT_Visualizar.Location = new System.Drawing.Point(204, 271);
            this.BT_Visualizar.Name = "BT_Visualizar";
            this.BT_Visualizar.Size = new System.Drawing.Size(89, 41);
            this.BT_Visualizar.TabIndex = 2;
            this.BT_Visualizar.Text = "Visualizacion General";
            this.BT_Visualizar.UseVisualStyleBackColor = true;
            this.BT_Visualizar.Click += new System.EventHandler(this.BT_Visualizar_Click);
            // 
            // BT_VentaDeBoletos
            // 
            this.BT_VentaDeBoletos.Location = new System.Drawing.Point(204, 83);
            this.BT_VentaDeBoletos.Name = "BT_VentaDeBoletos";
            this.BT_VentaDeBoletos.Size = new System.Drawing.Size(89, 41);
            this.BT_VentaDeBoletos.TabIndex = 3;
            this.BT_VentaDeBoletos.Text = "Venta De Boletos";
            this.BT_VentaDeBoletos.UseVisualStyleBackColor = true;
            this.BT_VentaDeBoletos.Click += new System.EventHandler(this.BT_VentaDeBoletos_Click);
            // 
            // TB_RegistrarEmp
            // 
            this.TB_RegistrarEmp.Location = new System.Drawing.Point(204, 130);
            this.TB_RegistrarEmp.Name = "TB_RegistrarEmp";
            this.TB_RegistrarEmp.Size = new System.Drawing.Size(89, 41);
            this.TB_RegistrarEmp.TabIndex = 4;
            this.TB_RegistrarEmp.Text = "Registrar Empleado";
            this.TB_RegistrarEmp.UseVisualStyleBackColor = true;
            this.TB_RegistrarEmp.Click += new System.EventHandler(this.TB_RegistrarEmp_Click);
            // 
            // BT_IngresarPelicula
            // 
            this.BT_IngresarPelicula.Location = new System.Drawing.Point(204, 224);
            this.BT_IngresarPelicula.Name = "BT_IngresarPelicula";
            this.BT_IngresarPelicula.Size = new System.Drawing.Size(89, 41);
            this.BT_IngresarPelicula.TabIndex = 5;
            this.BT_IngresarPelicula.Text = "Ingresar Pelicula";
            this.BT_IngresarPelicula.UseVisualStyleBackColor = true;
            this.BT_IngresarPelicula.Click += new System.EventHandler(this.BT_IngresarPelicula_Click);
            // 
            // BT_IngresarSucursal
            // 
            this.BT_IngresarSucursal.Location = new System.Drawing.Point(204, 177);
            this.BT_IngresarSucursal.Name = "BT_IngresarSucursal";
            this.BT_IngresarSucursal.Size = new System.Drawing.Size(89, 41);
            this.BT_IngresarSucursal.TabIndex = 6;
            this.BT_IngresarSucursal.Text = "Ingresar Sucursal";
            this.BT_IngresarSucursal.UseVisualStyleBackColor = true;
            this.BT_IngresarSucursal.Click += new System.EventHandler(this.BT_IngresarSucursal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 510);
            this.Controls.Add(this.BT_IngresarSucursal);
            this.Controls.Add(this.BT_IngresarPelicula);
            this.Controls.Add(this.TB_RegistrarEmp);
            this.Controls.Add(this.BT_VentaDeBoletos);
            this.Controls.Add(this.BT_Visualizar);
            this.Controls.Add(this.BT_RegistroAdmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_RegistroAdmin;
        private System.Windows.Forms.Button BT_Visualizar;
        private System.Windows.Forms.Button BT_VentaDeBoletos;
        private System.Windows.Forms.Button TB_RegistrarEmp;
        private System.Windows.Forms.Button BT_IngresarPelicula;
        private System.Windows.Forms.Button BT_IngresarSucursal;
    }
}

