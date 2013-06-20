namespace DBSystem.Windows
{
    partial class frmPedido
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
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label razonSocialLabel;
            System.Windows.Forms.Label rucDniLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label formaPagoIdLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.razonSocialTextBox = new System.Windows.Forms.TextBox();
            this.rucDniTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.formaPagoIdComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.productoDTODataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.detallePedidoDataGridView = new System.Windows.Forms.DataGridView();
            this.detallePedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            direccionLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            razonSocialLabel = new System.Windows.Forms.Label();
            rucDniLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            formaPagoIdLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoDTODataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(34, 70);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 6;
            direccionLabel.Text = "Direccion:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(43, 26);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 8;
            fechaLabel.Text = "Fecha:";
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.Location = new System.Drawing.Point(16, 44);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(73, 13);
            razonSocialLabel.TabIndex = 16;
            razonSocialLabel.Text = "Razon Social:";
            // 
            // rucDniLabel
            // 
            rucDniLabel.AutoSize = true;
            rucDniLabel.Location = new System.Drawing.Point(40, 22);
            rucDniLabel.Name = "rucDniLabel";
            rucDniLabel.Size = new System.Drawing.Size(49, 13);
            rucDniLabel.TabIndex = 18;
            rucDniLabel.Text = "Ruc Dni:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(23, 66);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(19, 13);
            label2.TabIndex = 14;
            label2.Text = "Id:";
            // 
            // formaPagoIdLabel
            // 
            formaPagoIdLabel.AutoSize = true;
            formaPagoIdLabel.Location = new System.Drawing.Point(16, 51);
            formaPagoIdLabel.Name = "formaPagoIdLabel";
            formaPagoIdLabel.Size = new System.Drawing.Size(67, 13);
            formaPagoIdLabel.TabIndex = 23;
            formaPagoIdLabel.Text = "Forma Pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(50, 74);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 13);
            label3.TabIndex = 20;
            label3.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(17, 22);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 13);
            label4.TabIndex = 20;
            label4.Text = "Criterio:";
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
            this.panel1.Size = new System.Drawing.Size(697, 47);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoDTOBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(95, 67);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(219, 20);
            this.direccionTextBox.TabIndex = 7;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pedidoDTOBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(89, 20);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(119, 20);
            this.fechaDateTimePicker.TabIndex = 9;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoDTOBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(48, 63);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 15;
            // 
            // razonSocialTextBox
            // 
            this.razonSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoDTOBindingSource, "RazonSocial", true));
            this.razonSocialTextBox.Location = new System.Drawing.Point(95, 45);
            this.razonSocialTextBox.Name = "razonSocialTextBox";
            this.razonSocialTextBox.Size = new System.Drawing.Size(219, 20);
            this.razonSocialTextBox.TabIndex = 17;
            // 
            // rucDniTextBox
            // 
            this.rucDniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoDTOBindingSource, "RucDni", true));
            this.rucDniTextBox.Location = new System.Drawing.Point(95, 19);
            this.rucDniTextBox.Name = "rucDniTextBox";
            this.rucDniTextBox.Size = new System.Drawing.Size(127, 20);
            this.rucDniTextBox.TabIndex = 19;
            this.rucDniTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rucDniTextBox_KeyDown);
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoDTOBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(90, 74);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(120, 20);
            this.totalTextBox.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rucDniTextBox);
            this.groupBox1.Controls.Add(rucDniLabel);
            this.groupBox1.Controls.Add(this.razonSocialTextBox);
            this.groupBox1.Controls.Add(direccionLabel);
            this.groupBox1.Controls.Add(razonSocialLabel);
            this.groupBox1.Controls.Add(this.direccionTextBox);
            this.groupBox1.Location = new System.Drawing.Point(17, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(formaPagoIdLabel);
            this.groupBox2.Controls.Add(this.fechaDateTimePicker);
            this.groupBox2.Controls.Add(this.formaPagoIdComboBox);
            this.groupBox2.Controls.Add(fechaLabel);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.totalTextBox);
            this.groupBox2.Location = new System.Drawing.Point(355, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 100);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pedido";
            // 
            // formaPagoIdComboBox
            // 
            this.formaPagoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pedidoDTOBindingSource, "FormaPagoId", true));
            this.formaPagoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formaPagoBindingSource, "Descripcion", true));
            this.formaPagoIdComboBox.DataSource = this.formaPagoBindingSource;
            this.formaPagoIdComboBox.DisplayMember = "Descripcion";
            this.formaPagoIdComboBox.FormattingEnabled = true;
            this.formaPagoIdComboBox.Location = new System.Drawing.Point(89, 48);
            this.formaPagoIdComboBox.Name = "formaPagoIdComboBox";
            this.formaPagoIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.formaPagoIdComboBox.TabIndex = 24;
            this.formaPagoIdComboBox.ValueMember = "Id";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtCriterio);
            this.groupBox3.Controls.Add(label4);
            this.groupBox3.Controls.Add(this.productoDTODataGridView);
            this.groupBox3.Location = new System.Drawing.Point(17, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(671, 181);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(494, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(412, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(65, 19);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(340, 20);
            this.txtCriterio.TabIndex = 21;
            // 
            // productoDTODataGridView
            // 
            this.productoDTODataGridView.AllowUserToAddRows = false;
            this.productoDTODataGridView.AutoGenerateColumns = false;
            this.productoDTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.productoDTODataGridView.DataSource = this.productoDTOBindingSource;
            this.productoDTODataGridView.Location = new System.Drawing.Point(9, 52);
            this.productoDTODataGridView.Name = "productoDTODataGridView";
            this.productoDTODataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.productoDTODataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.productoDTODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productoDTODataGridView.Size = new System.Drawing.Size(650, 112);
            this.productoDTODataGridView.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.detallePedidoDataGridView);
            this.groupBox4.Location = new System.Drawing.Point(17, 387);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(671, 196);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalle Pedido";
            // 
            // detallePedidoDataGridView
            // 
            this.detallePedidoDataGridView.AllowUserToAddRows = false;
            this.detallePedidoDataGridView.AutoGenerateColumns = false;
            this.detallePedidoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallePedidoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.Monto});
            this.detallePedidoDataGridView.DataSource = this.detallePedidoBindingSource;
            this.detallePedidoDataGridView.Location = new System.Drawing.Point(14, 19);
            this.detallePedidoDataGridView.Name = "detallePedidoDataGridView";
            this.detallePedidoDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.detallePedidoDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.detallePedidoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detallePedidoDataGridView.Size = new System.Drawing.Size(645, 145);
            this.detallePedidoDataGridView.TabIndex = 0;
            // 
            // detallePedidoBindingSource
            // 
            this.detallePedidoBindingSource.DataMember = "DetallePedido";
            this.detallePedidoBindingSource.DataSource = this.pedidoDTOBindingSource;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn9.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn10.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn11.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn12.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // pedidoDTOBindingSource
            // 
            this.pedidoDTOBindingSource.DataSource = typeof(DBSystem.BusinessEntities.PedidoDTO);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn2.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Stock";
            this.dataGridViewTextBoxColumn6.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // productoDTOBindingSource
            // 
            this.productoDTOBindingSource.DataSource = typeof(DBSystem.BusinessEntities.ProductoDTO);
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // formaPagoBindingSource
            // 
            this.formaPagoBindingSource.DataSource = typeof(DBSystem.BusinessEntities.FormaPago);
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 593);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(label2);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.panel1);
            this.Name = "frmPedido";
            this.Text = "frmPedido";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoDTODataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource pedidoDTOBindingSource;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox razonSocialTextBox;
        private System.Windows.Forms.TextBox rucDniTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox formaPagoIdComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.DataGridView productoDTODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource productoDTOBindingSource;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView detallePedidoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingSource detallePedidoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.BindingSource formaPagoBindingSource;
    }
}