
namespace TP_Integrados_Programacion
{
    partial class FormIngresarPelicula
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
            this.BT_VolverPeli = new System.Windows.Forms.Button();
            this.TB_NombrePelicula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Duracion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Genero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Idioma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_Subtitulos = new System.Windows.Forms.ComboBox();
            this.BT_CrearPeli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_VolverPeli
            // 
            this.BT_VolverPeli.Location = new System.Drawing.Point(191, 20);
            this.BT_VolverPeli.Name = "BT_VolverPeli";
            this.BT_VolverPeli.Size = new System.Drawing.Size(75, 23);
            this.BT_VolverPeli.TabIndex = 16;
            this.BT_VolverPeli.Text = "Volver";
            this.BT_VolverPeli.UseVisualStyleBackColor = true;
            this.BT_VolverPeli.Click += new System.EventHandler(this.BT_VolverPeli_Click);
            // 
            // TB_NombrePelicula
            // 
            this.TB_NombrePelicula.Location = new System.Drawing.Point(12, 55);
            this.TB_NombrePelicula.Name = "TB_NombrePelicula";
            this.TB_NombrePelicula.Size = new System.Drawing.Size(158, 20);
            this.TB_NombrePelicula.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // TB_Duracion
            // 
            this.TB_Duracion.Location = new System.Drawing.Point(12, 100);
            this.TB_Duracion.Name = "TB_Duracion";
            this.TB_Duracion.Size = new System.Drawing.Size(158, 20);
            this.TB_Duracion.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Duracion";
            // 
            // TB_Genero
            // 
            this.TB_Genero.Location = new System.Drawing.Point(12, 145);
            this.TB_Genero.Name = "TB_Genero";
            this.TB_Genero.Size = new System.Drawing.Size(158, 20);
            this.TB_Genero.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Genero";
            // 
            // TB_Idioma
            // 
            this.TB_Idioma.Location = new System.Drawing.Point(12, 195);
            this.TB_Idioma.Name = "TB_Idioma";
            this.TB_Idioma.Size = new System.Drawing.Size(158, 20);
            this.TB_Idioma.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Idioma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Subtitulos";
            // 
            // CB_Subtitulos
            // 
            this.CB_Subtitulos.AutoCompleteCustomSource.AddRange(new string[] {
            "Yes",
            "No"});
            this.CB_Subtitulos.FormattingEnabled = true;
            this.CB_Subtitulos.Location = new System.Drawing.Point(12, 246);
            this.CB_Subtitulos.Name = "CB_Subtitulos";
            this.CB_Subtitulos.Size = new System.Drawing.Size(158, 21);
            this.CB_Subtitulos.TabIndex = 25;
            // 
            // BT_CrearPeli
            // 
            this.BT_CrearPeli.Location = new System.Drawing.Point(49, 273);
            this.BT_CrearPeli.Name = "BT_CrearPeli";
            this.BT_CrearPeli.Size = new System.Drawing.Size(75, 23);
            this.BT_CrearPeli.TabIndex = 26;
            this.BT_CrearPeli.Text = "Crear";
            this.BT_CrearPeli.UseVisualStyleBackColor = true;
            this.BT_CrearPeli.Click += new System.EventHandler(this.BT_CrearPeli_Click);
            // 
            // FormIngresarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_CrearPeli);
            this.Controls.Add(this.CB_Subtitulos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Idioma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Genero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Duracion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BT_VolverPeli);
            this.Controls.Add(this.TB_NombrePelicula);
            this.Controls.Add(this.label1);
            this.Name = "FormIngresarPelicula";
            this.Text = "FormIngresarPelicula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_VolverPeli;
        private System.Windows.Forms.TextBox TB_NombrePelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Duracion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Genero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Idioma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_Subtitulos;
        private System.Windows.Forms.Button BT_CrearPeli;
    }
}