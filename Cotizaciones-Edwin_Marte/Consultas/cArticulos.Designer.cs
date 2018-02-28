namespace Cotizaciones_Edwin_Marte.Consultas
{
    partial class cArticulos
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
            this.ArticulosDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrarComboBox = new System.Windows.Forms.ComboBox();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ArticulosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ArticulosDataGridView
            // 
            this.ArticulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArticulosDataGridView.Location = new System.Drawing.Point(32, 97);
            this.ArticulosDataGridView.Name = "ArticulosDataGridView";
            this.ArticulosDataGridView.Size = new System.Drawing.Size(342, 199);
            this.ArticulosDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Campo a filtrar";
            // 
            // FiltrarComboBox
            // 
            this.FiltrarComboBox.FormattingEnabled = true;
            this.FiltrarComboBox.Items.AddRange(new object[] {
            "Id",
            "Descripcion",
            "Precio"});
            this.FiltrarComboBox.Location = new System.Drawing.Point(32, 48);
            this.FiltrarComboBox.Name = "FiltrarComboBox";
            this.FiltrarComboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrarComboBox.TabIndex = 2;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(180, 49);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(101, 20);
            this.CriterioTextBox.TabIndex = 3;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(299, 49);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 4;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Location = new System.Drawing.Point(32, 313);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(75, 44);
            this.ImprimirButton.TabIndex = 5;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.UseVisualStyleBackColor = true;
            this.ImprimirButton.Click += new System.EventHandler(this.ImprimirButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Criterio de busqueda";
            // 
            // cArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 369);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.FiltrarComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArticulosDataGridView);
            this.Name = "cArticulos";
            this.Text = "cArticulos";
            this.Load += new System.EventHandler(this.cArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArticulosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ArticulosDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltrarComboBox;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.Label label2;
    }
}