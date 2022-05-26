namespace ProyectoFinal_RentCar.Forms
{
    partial class Renta_Devolucion
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
            this.checkBoxDevuelto = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboVehiculo = new System.Windows.Forms.ComboBox();
            this.ChckEstado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewRentaDevo = new System.Windows.Forms.DataGridView();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.comboEmpleado = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dateTimePickerDevo = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerRenta = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidadDias = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentaDevo)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxDevuelto
            // 
            this.checkBoxDevuelto.AutoSize = true;
            this.checkBoxDevuelto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBoxDevuelto.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.checkBoxDevuelto.Location = new System.Drawing.Point(239, 142);
            this.checkBoxDevuelto.Name = "checkBoxDevuelto";
            this.checkBoxDevuelto.Size = new System.Drawing.Size(124, 24);
            this.checkBoxDevuelto.TabIndex = 30;
            this.checkBoxDevuelto.Text = "Devuelto";
            this.checkBoxDevuelto.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBoxDevuelto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 45);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cliente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 45);
            this.label2.TabIndex = 20;
            this.label2.Text = "Vehiculo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboVehiculo
            // 
            this.comboVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVehiculo.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.comboVehiculo.FormattingEnabled = true;
            this.comboVehiculo.Location = new System.Drawing.Point(153, 56);
            this.comboVehiculo.Name = "comboVehiculo";
            this.comboVehiculo.Size = new System.Drawing.Size(144, 28);
            this.comboVehiculo.TabIndex = 19;
            // 
            // ChckEstado
            // 
            this.ChckEstado.AutoSize = true;
            this.ChckEstado.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.ChckEstado.Location = new System.Drawing.Point(11, 3);
            this.ChckEstado.Name = "ChckEstado";
            this.ChckEstado.Size = new System.Drawing.Size(74, 24);
            this.ChckEstado.TabIndex = 0;
            this.ChckEstado.Text = "Estado";
            this.ChckEstado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 854F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewRentaDevo, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 175);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(862, 234);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // dataGridViewRentaDevo
            // 
            this.dataGridViewRentaDevo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRentaDevo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewRentaDevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRentaDevo.Location = new System.Drawing.Point(11, 3);
            this.dataGridViewRentaDevo.MultiSelect = false;
            this.dataGridViewRentaDevo.Name = "dataGridViewRentaDevo";
            this.dataGridViewRentaDevo.ReadOnly = true;
            this.dataGridViewRentaDevo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRentaDevo.Size = new System.Drawing.Size(848, 228);
            this.dataGridViewRentaDevo.TabIndex = 10;
            this.dataGridViewRentaDevo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRentaDevo_CellContentClick);
            // 
            // comboCliente
            // 
            this.comboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCliente.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(303, 56);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(144, 28);
            this.comboCliente.TabIndex = 21;
            // 
            // comboEmpleado
            // 
            this.comboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEmpleado.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.comboEmpleado.FormattingEnabled = true;
            this.comboEmpleado.Location = new System.Drawing.Point(3, 56);
            this.comboEmpleado.Name = "comboEmpleado";
            this.comboEmpleado.Size = new System.Drawing.Size(144, 28);
            this.comboEmpleado.TabIndex = 23;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(3, 3);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(39, 39);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "C";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(48, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(46, 39);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "E";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.Controls.Add(this.btnCrear, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnEditar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnEliminar, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 118);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(144, 47);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(100, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(41, 39);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "D";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dateTimePickerDevo
            // 
            this.dateTimePickerDevo.CustomFormat = "";
            this.dateTimePickerDevo.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDevo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDevo.Location = new System.Drawing.Point(303, 118);
            this.dateTimePickerDevo.Name = "dateTimePickerDevo";
            this.dateTimePickerDevo.Size = new System.Drawing.Size(144, 26);
            this.dateTimePickerDevo.TabIndex = 29;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboEmpleado, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboCliente, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboVehiculo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerDevo, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerRenta, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.61539F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(487, 169);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 30;
            this.label4.Text = "Fecha Renta";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(303, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 26);
            this.label6.TabIndex = 31;
            this.label6.Text = "Fecha Devolucion";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerRenta
            // 
            this.dateTimePickerRenta.CustomFormat = "";
            this.dateTimePickerRenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRenta.Location = new System.Drawing.Point(153, 118);
            this.dateTimePickerRenta.Name = "dateTimePickerRenta";
            this.dateTimePickerRenta.Size = new System.Drawing.Size(144, 26);
            this.dateTimePickerRenta.TabIndex = 32;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 866F));
            this.tableLayoutPanel4.Controls.Add(this.ChckEstado, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 412);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.30612F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.69388F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(874, 49);
            this.tableLayoutPanel4.TabIndex = 32;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtCantidadDias, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtMonto, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.checkBoxDevuelto, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.txtComentario, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(493, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(369, 169);
            this.tableLayoutPanel5.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 50);
            this.label5.TabIndex = 39;
            this.label5.Text = "Comentario";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCantidadDias
            // 
            this.txtCantidadDias.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.txtCantidadDias.Location = new System.Drawing.Point(3, 53);
            this.txtCantidadDias.Multiline = true;
            this.txtCantidadDias.Name = "txtCantidadDias";
            this.txtCantidadDias.Size = new System.Drawing.Size(123, 33);
            this.txtCantidadDias.TabIndex = 38;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.txtMonto.Location = new System.Drawing.Point(132, 53);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(101, 33);
            this.txtMonto.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(132, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 50);
            this.label7.TabIndex = 34;
            this.label7.Text = "Monto por Dia";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtComentario
            // 
            this.txtComentario.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.txtComentario.Location = new System.Drawing.Point(239, 53);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(124, 33);
            this.txtComentario.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 50);
            this.label8.TabIndex = 35;
            this.label8.Text = "Cantidad de Dias";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Renta_Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 461);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "Renta_Devolucion";
            this.Text = "Renta_Devolucion";
            this.Load += new System.EventHandler(this.Renta_Devolucion_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentaDevo)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxDevuelto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboVehiculo;
        private System.Windows.Forms.CheckBox ChckEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridViewRentaDevo;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.ComboBox comboEmpleado;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker dateTimePickerDevo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerRenta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtCantidadDias;
        private System.Windows.Forms.Label label5;
    }
}