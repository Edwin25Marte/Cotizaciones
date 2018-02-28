namespace Cotizaciones_Edwin_Marte.Consultas
{
    partial class cCotizaciones
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
            this.CotizacionesDataGridView = new System.Windows.Forms.DataGridView();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.FiltrarComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImprimirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CotizacionesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CotizacionesDataGridView
            // 
            this.CotizacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CotizacionesDataGridView.Location = new System.Drawing.Point(23, 107);
            this.CotizacionesDataGridView.Name = "CotizacionesDataGridView";
            this.CotizacionesDataGridView.Size = new System.Drawing.Size(414, 169);
            this.CotizacionesDataGridView.TabIndex = 0;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(180, 62);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(176, 20);
            this.CriterioTextBox.TabIndex = 1;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(362, 61);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 2;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // FiltrarComboBox
            // 
            this.FiltrarComboBox.FormattingEnabled = true;
            this.FiltrarComboBox.Items.AddRange(new object[] {
            "Id ",
            "Comentario",
            "Monto"});
            this.FiltrarComboBox.Location = new System.Drawing.Point(23, 61);
            this.FiltrarComboBox.Name = "FiltrarComboBox";
            this.FiltrarComboBox.Size = new System.Drawing.Size(151, 21);
            this.FiltrarComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Campo a filtrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Criterio de busqueda";
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Location = new System.Drawing.Point(23, 292);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(75, 43);
            this.ImprimirButton.TabIndex = 6;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.UseVisualStyleBackColor = true;
            this.ImprimirButton.Click += new System.EventHandler(this.ImprimirButton_Click);
            // 
            // cCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 347);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrarComboBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.CotizacionesDataGridView);
            this.Name = "cCotizaciones";
            this.Text = "cCotizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.CotizacionesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CotizacionesDataGridView;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ComboBox FiltrarComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ImprimirButton;
    }
}