namespace Cotizaciones_Edwin_Marte.Registros
{
    partial class RegArticulos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ArticulosIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.BuscarAButton = new System.Windows.Forms.Button();
            this.NuevoAButton = new System.Windows.Forms.Button();
            this.GuardarAButton = new System.Windows.Forms.Button();
            this.EliminarAButton = new System.Windows.Forms.Button();
            this.CotizacionesDetalleButton = new System.Windows.Forms.Button();
            this.ConsultarAButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreArtTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ArticulosIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Articulo Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            // 
            // ArticulosIdNumericUpDown
            // 
            this.ArticulosIdNumericUpDown.Location = new System.Drawing.Point(109, 66);
            this.ArticulosIdNumericUpDown.Name = "ArticulosIdNumericUpDown";
            this.ArticulosIdNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.ArticulosIdNumericUpDown.TabIndex = 3;
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(109, 218);
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(202, 20);
            this.PrecioNumericUpDown.TabIndex = 4;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(109, 144);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(202, 63);
            this.DescripcionTextBox.TabIndex = 5;
            // 
            // BuscarAButton
            // 
            this.BuscarAButton.Location = new System.Drawing.Point(236, 63);
            this.BuscarAButton.Name = "BuscarAButton";
            this.BuscarAButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarAButton.TabIndex = 6;
            this.BuscarAButton.Text = "Buscar";
            this.BuscarAButton.UseVisualStyleBackColor = true;
            this.BuscarAButton.Click += new System.EventHandler(this.BuscarAButton_Click);
            // 
            // NuevoAButton
            // 
            this.NuevoAButton.Location = new System.Drawing.Point(58, 250);
            this.NuevoAButton.Name = "NuevoAButton";
            this.NuevoAButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoAButton.TabIndex = 7;
            this.NuevoAButton.Text = "Nuevo";
            this.NuevoAButton.UseVisualStyleBackColor = true;
            this.NuevoAButton.Click += new System.EventHandler(this.NuevoAButton_Click);
            // 
            // GuardarAButton
            // 
            this.GuardarAButton.Location = new System.Drawing.Point(144, 250);
            this.GuardarAButton.Name = "GuardarAButton";
            this.GuardarAButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarAButton.TabIndex = 8;
            this.GuardarAButton.Text = "Guardar";
            this.GuardarAButton.UseVisualStyleBackColor = true;
            this.GuardarAButton.Click += new System.EventHandler(this.GuardarAButton_Click);
            // 
            // EliminarAButton
            // 
            this.EliminarAButton.Location = new System.Drawing.Point(234, 250);
            this.EliminarAButton.Name = "EliminarAButton";
            this.EliminarAButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarAButton.TabIndex = 9;
            this.EliminarAButton.Text = "Eliminar";
            this.EliminarAButton.UseVisualStyleBackColor = true;
            this.EliminarAButton.Click += new System.EventHandler(this.EliminarAButton_Click);
            // 
            // CotizacionesDetalleButton
            // 
            this.CotizacionesDetalleButton.Location = new System.Drawing.Point(43, 23);
            this.CotizacionesDetalleButton.Name = "CotizacionesDetalleButton";
            this.CotizacionesDetalleButton.Size = new System.Drawing.Size(123, 23);
            this.CotizacionesDetalleButton.TabIndex = 10;
            this.CotizacionesDetalleButton.Text = "Cotizaciones detalle";
            this.CotizacionesDetalleButton.UseVisualStyleBackColor = true;
            this.CotizacionesDetalleButton.Click += new System.EventHandler(this.CotizacionesDetalleButton_Click);
            // 
            // ConsultarAButton
            // 
            this.ConsultarAButton.Location = new System.Drawing.Point(236, 23);
            this.ConsultarAButton.Name = "ConsultarAButton";
            this.ConsultarAButton.Size = new System.Drawing.Size(75, 23);
            this.ConsultarAButton.TabIndex = 11;
            this.ConsultarAButton.Text = "Consultar";
            this.ConsultarAButton.UseVisualStyleBackColor = true;
            this.ConsultarAButton.Click += new System.EventHandler(this.ConsultarAButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombre";
            // 
            // NombreArtTextBox
            // 
            this.NombreArtTextBox.Location = new System.Drawing.Point(109, 109);
            this.NombreArtTextBox.Name = "NombreArtTextBox";
            this.NombreArtTextBox.Size = new System.Drawing.Size(200, 20);
            this.NombreArtTextBox.TabIndex = 13;
            // 
            // RegArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 296);
            this.Controls.Add(this.NombreArtTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConsultarAButton);
            this.Controls.Add(this.CotizacionesDetalleButton);
            this.Controls.Add(this.EliminarAButton);
            this.Controls.Add(this.GuardarAButton);
            this.Controls.Add(this.NuevoAButton);
            this.Controls.Add(this.BuscarAButton);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.PrecioNumericUpDown);
            this.Controls.Add(this.ArticulosIdNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "RegArticulos";
            this.Text = "RegArticulos";
            this.Load += new System.EventHandler(this.RegArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArticulosIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ArticulosIdNumericUpDown;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Button BuscarAButton;
        private System.Windows.Forms.Button NuevoAButton;
        private System.Windows.Forms.Button GuardarAButton;
        private System.Windows.Forms.Button EliminarAButton;
        private System.Windows.Forms.Button CotizacionesDetalleButton;
        private System.Windows.Forms.Button ConsultarAButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NombreArtTextBox;
    }
}