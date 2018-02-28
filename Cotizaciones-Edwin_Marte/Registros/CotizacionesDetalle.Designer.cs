namespace Cotizaciones_Edwin_Marte.Registros
{
    partial class CotizacionesDetalle
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
            this.AgregarButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FechaDetalleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.ArticuloId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.BuscarArtButton = new System.Windows.Forms.Button();
            this.BArtNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarDetalleButton = new System.Windows.Forms.Button();
            this.CotIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ImporteTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ArtNTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BArtNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CotIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(490, 82);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 39;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Importe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Precio";
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(343, 86);
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(66, 20);
            this.PrecioNumericUpDown.TabIndex = 35;
            this.PrecioNumericUpDown.ValueChanged += new System.EventHandler(this.PrecioNumericUpDown_ValueChanged);
            // 
            // CantidadNumericUpDown
            // 
            this.CantidadNumericUpDown.Location = new System.Drawing.Point(270, 86);
            this.CantidadNumericUpDown.Name = "CantidadNumericUpDown";
            this.CantidadNumericUpDown.Size = new System.Drawing.Size(66, 20);
            this.CantidadNumericUpDown.TabIndex = 34;
            this.CantidadNumericUpDown.ValueChanged += new System.EventHandler(this.CantidadNumericUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Cantidad";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 344);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "label5";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(467, 344);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Total";
            // 
            // FechaDetalleDateTimePicker
            // 
            this.FechaDetalleDateTimePicker.Location = new System.Drawing.Point(309, 31);
            this.FechaDetalleDateTimePicker.Name = "FechaDetalleDateTimePicker";
            this.FechaDetalleDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FechaDetalleDateTimePicker.TabIndex = 28;
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArticuloId,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Importe});
            this.DetalleDataGridView.Location = new System.Drawing.Point(24, 122);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.Size = new System.Drawing.Size(543, 202);
            this.DetalleDataGridView.TabIndex = 27;
            // 
            // ArticuloId
            // 
            this.ArticuloId.HeaderText = "Articulo Id";
            this.ArticuloId.Name = "ArticuloId";
            this.ArticuloId.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Fecha";
            // 
            // BuscarArtButton
            // 
            this.BuscarArtButton.Location = new System.Drawing.Point(147, 59);
            this.BuscarArtButton.Name = "BuscarArtButton";
            this.BuscarArtButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarArtButton.TabIndex = 25;
            this.BuscarArtButton.Text = "Buscar";
            this.BuscarArtButton.UseVisualStyleBackColor = true;
            this.BuscarArtButton.Click += new System.EventHandler(this.BuscarArtButton_Click);
            // 
            // BArtNumericUpDown
            // 
            this.BArtNumericUpDown.Location = new System.Drawing.Point(91, 61);
            this.BArtNumericUpDown.Name = "BArtNumericUpDown";
            this.BArtNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.BArtNumericUpDown.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Articulo Id";
            // 
            // BuscarDetalleButton
            // 
            this.BuscarDetalleButton.Location = new System.Drawing.Point(146, 28);
            this.BuscarDetalleButton.Name = "BuscarDetalleButton";
            this.BuscarDetalleButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarDetalleButton.TabIndex = 22;
            this.BuscarDetalleButton.Text = "Buscar";
            this.BuscarDetalleButton.UseVisualStyleBackColor = true;
            // 
            // CotIdNumericUpDown
            // 
            this.CotIdNumericUpDown.Location = new System.Drawing.Point(90, 29);
            this.CotIdNumericUpDown.Name = "CotIdNumericUpDown";
            this.CotIdNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.CotIdNumericUpDown.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Id";
            // 
            // ImporteTextBox
            // 
            this.ImporteTextBox.Location = new System.Drawing.Point(416, 85);
            this.ImporteTextBox.Name = "ImporteTextBox";
            this.ImporteTextBox.Size = new System.Drawing.Size(68, 20);
            this.ImporteTextBox.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Nombre Articulo ";
            // 
            // ArtNTextBox
            // 
            this.ArtNTextBox.Location = new System.Drawing.Point(121, 90);
            this.ArtNTextBox.Name = "ArtNTextBox";
            this.ArtNTextBox.Size = new System.Drawing.Size(100, 20);
            this.ArtNTextBox.TabIndex = 42;
            // 
            // CotizacionesDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 392);
            this.Controls.Add(this.ArtNTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ImporteTextBox);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PrecioNumericUpDown);
            this.Controls.Add(this.CantidadNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FechaDetalleDateTimePicker);
            this.Controls.Add(this.DetalleDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuscarArtButton);
            this.Controls.Add(this.BArtNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarDetalleButton);
            this.Controls.Add(this.CotIdNumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "CotizacionesDetalle";
            this.Text = "Cotizaciones Detalle";
            this.Load += new System.EventHandler(this.CotizacionesDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BArtNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CotIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.NumericUpDown CantidadNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FechaDetalleDateTimePicker;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BuscarArtButton;
        private System.Windows.Forms.NumericUpDown BArtNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuscarDetalleButton;
        private System.Windows.Forms.NumericUpDown CotIdNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ImporteTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticuloId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ArtNTextBox;
    }
}