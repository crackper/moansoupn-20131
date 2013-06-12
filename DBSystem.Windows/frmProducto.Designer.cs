namespace DBSystem.Windows
{
    partial class frmProducto
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label categoriaIdLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label descontinuadoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label stockLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.descontinuadoCheckBox = new System.Windows.Forms.CheckBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.categoriaIdComboBox = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.precioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            categoriaIdLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            descontinuadoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Location = new System.Drawing.Point(28, 100);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(67, 13);
            categoriaIdLabel.TabIndex = 6;
            categoriaIdLabel.Text = "Categoria Id:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(52, 48);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 2;
            codigoLabel.Text = "Codigo:";
            // 
            // descontinuadoLabel
            // 
            descontinuadoLabel.AutoSize = true;
            descontinuadoLabel.Location = new System.Drawing.Point(13, 181);
            descontinuadoLabel.Name = "descontinuadoLabel";
            descontinuadoLabel.Size = new System.Drawing.Size(82, 13);
            descontinuadoLabel.TabIndex = 12;
            descontinuadoLabel.Text = "Descontinuado:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(29, 74);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 4;
            descripcionLabel.Text = "Descripcion:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(27, 22);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(68, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Identificador:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(55, 124);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 8;
            precioLabel.Text = "Precio:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(57, 150);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(38, 13);
            stockLabel.TabIndex = 10;
            stockLabel.Text = "Stock:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 42);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(DBSystem.BusinessEntities.Producto);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(99, 45);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(217, 20);
            this.codigoTextBox.TabIndex = 3;
            // 
            // descontinuadoCheckBox
            // 
            this.descontinuadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productoBindingSource, "Descontinuado", true));
            this.descontinuadoCheckBox.Location = new System.Drawing.Point(99, 176);
            this.descontinuadoCheckBox.Name = "descontinuadoCheckBox";
            this.descontinuadoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.descontinuadoCheckBox.TabIndex = 13;
            this.descontinuadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(99, 71);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(217, 20);
            this.descripcionTextBox.TabIndex = 5;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(99, 19);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(104, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(278, 262);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // categoriaIdComboBox
            // 
            this.categoriaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "CategoriaId", true));
            this.categoriaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Descripcion", true));
            this.categoriaIdComboBox.DataSource = this.categoriaBindingSource;
            this.categoriaIdComboBox.DisplayMember = "Descripcion";
            this.categoriaIdComboBox.FormattingEnabled = true;
            this.categoriaIdComboBox.Location = new System.Drawing.Point(99, 97);
            this.categoriaIdComboBox.Name = "categoriaIdComboBox";
            this.categoriaIdComboBox.Size = new System.Drawing.Size(217, 21);
            this.categoriaIdComboBox.TabIndex = 7;
            this.categoriaIdComboBox.ValueMember = "Id";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(DBSystem.BusinessEntities.Categoria);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(stockLabel);
            this.groupBox1.Controls.Add(this.categoriaIdComboBox);
            this.groupBox1.Controls.Add(descontinuadoLabel);
            this.groupBox1.Controls.Add(this.stockNumericUpDown);
            this.groupBox1.Controls.Add(this.descontinuadoCheckBox);
            this.groupBox1.Controls.Add(categoriaIdLabel);
            this.groupBox1.Controls.Add(precioLabel);
            this.groupBox1.Controls.Add(this.precioNumericUpDown);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.codigoTextBox);
            this.groupBox1.Controls.Add(codigoLabel);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Location = new System.Drawing.Point(17, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // stockNumericUpDown
            // 
            this.stockNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productoBindingSource, "Stock", true));
            this.stockNumericUpDown.Location = new System.Drawing.Point(99, 150);
            this.stockNumericUpDown.Name = "stockNumericUpDown";
            this.stockNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.stockNumericUpDown.TabIndex = 11;
            // 
            // precioNumericUpDown
            // 
            this.precioNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productoBindingSource, "Precio", true));
            this.precioNumericUpDown.Location = new System.Drawing.Point(99, 124);
            this.precioNumericUpDown.Name = "precioNumericUpDown";
            this.precioNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.precioNumericUpDown.TabIndex = 9;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 298);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.CheckBox descontinuadoCheckBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox categoriaIdComboBox;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown stockNumericUpDown;
        private System.Windows.Forms.NumericUpDown precioNumericUpDown;
    }
}