namespace ProyectoFinal_RentCar.Forms
{
    partial class Inspeccion
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
            this.ChckEstado = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewInspeccion = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboVehiculo = new System.Windows.Forms.ComboBox();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.comboEmpleado = new System.Windows.Forms.ComboBox();
            this.comboCombustible = new System.Windows.Forms.ComboBox();
            this.checkRalladuras = new System.Windows.Forms.CheckBox();
            this.checkRepuesta = new System.Windows.Forms.CheckBox();
            this.checkGato = new System.Windows.Forms.CheckBox();
            this.checkCristal = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkIzFrontal = new System.Windows.Forms.CheckBox();
            this.checkIzTrasera = new System.Windows.Forms.CheckBox();
            this.checkDereFrontal = new System.Windows.Forms.CheckBox();
            this.checkDerTrasera = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInspeccion)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 854F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewInspeccion, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 175);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(862, 234);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // dataGridViewInspeccion
            // 
            this.dataGridViewInspeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInspeccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewInspeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInspeccion.Location = new System.Drawing.Point(11, 3);
            this.dataGridViewInspeccion.MultiSelect = false;
            this.dataGridViewInspeccion.Name = "dataGridViewInspeccion";
            this.dataGridViewInspeccion.ReadOnly = true;
            this.dataGridViewInspeccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInspeccion.Size = new System.Drawing.Size(848, 228);
            this.dataGridViewInspeccion.TabIndex = 10;
            this.dataGridViewInspeccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInspeccion_CellContentClick);
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
            this.tableLayoutPanel4.TabIndex = 28;
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
            this.label1.Text = "Vehiculo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboVehiculo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboCliente, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboEmpleado, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboCombustible, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkRalladuras, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkRepuesta, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkGato, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkCristal, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.61539F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(606, 169);
            this.tableLayoutPanel1.TabIndex = 26;
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 119);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(144, 47);
            this.tableLayoutPanel3.TabIndex = 30;
            // 
            // btnCrear
            // 
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Image = global::ProyectoFinal_RentCar.Properties.Resources.mas;
            this.btnCrear.Location = new System.Drawing.Point(3, 3);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(39, 39);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::ProyectoFinal_RentCar.Properties.Resources.lapiz;
            this.btnEditar.Location = new System.Drawing.Point(48, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(46, 39);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::ProyectoFinal_RentCar.Properties.Resources.bote_de_basura;
            this.btnEliminar.Location = new System.Drawing.Point(100, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(41, 39);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 45);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cant. Combustible";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label3.Text = "Empleado";
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
            this.label2.Text = "Cliente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboVehiculo
            // 
            this.comboVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVehiculo.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.comboVehiculo.FormattingEnabled = true;
            this.comboVehiculo.Location = new System.Drawing.Point(3, 56);
            this.comboVehiculo.Name = "comboVehiculo";
            this.comboVehiculo.Size = new System.Drawing.Size(144, 28);
            this.comboVehiculo.TabIndex = 19;
            // 
            // comboCliente
            // 
            this.comboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCliente.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(153, 56);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(144, 28);
            this.comboCliente.TabIndex = 21;
            // 
            // comboEmpleado
            // 
            this.comboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEmpleado.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.comboEmpleado.FormattingEnabled = true;
            this.comboEmpleado.Location = new System.Drawing.Point(303, 56);
            this.comboEmpleado.Name = "comboEmpleado";
            this.comboEmpleado.Size = new System.Drawing.Size(144, 28);
            this.comboEmpleado.TabIndex = 23;
            // 
            // comboCombustible
            // 
            this.comboCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCombustible.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.comboCombustible.FormattingEnabled = true;
            this.comboCombustible.Location = new System.Drawing.Point(453, 56);
            this.comboCombustible.Name = "comboCombustible";
            this.comboCombustible.Size = new System.Drawing.Size(144, 28);
            this.comboCombustible.TabIndex = 25;
            // 
            // checkRalladuras
            // 
            this.checkRalladuras.AutoSize = true;
            this.checkRalladuras.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.checkRalladuras.Location = new System.Drawing.Point(3, 92);
            this.checkRalladuras.Name = "checkRalladuras";
            this.checkRalladuras.Size = new System.Drawing.Size(98, 21);
            this.checkRalladuras.TabIndex = 1;
            this.checkRalladuras.Text = "Ralladuras";
            this.checkRalladuras.UseVisualStyleBackColor = true;
            // 
            // checkRepuesta
            // 
            this.checkRepuesta.AutoSize = true;
            this.checkRepuesta.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.checkRepuesta.Location = new System.Drawing.Point(153, 92);
            this.checkRepuesta.Name = "checkRepuesta";
            this.checkRepuesta.Size = new System.Drawing.Size(91, 21);
            this.checkRepuesta.TabIndex = 26;
            this.checkRepuesta.Text = "Repuesta";
            this.checkRepuesta.UseVisualStyleBackColor = true;
            // 
            // checkGato
            // 
            this.checkGato.AutoSize = true;
            this.checkGato.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.checkGato.Location = new System.Drawing.Point(303, 92);
            this.checkGato.Name = "checkGato";
            this.checkGato.Size = new System.Drawing.Size(60, 21);
            this.checkGato.TabIndex = 27;
            this.checkGato.Text = "Gato";
            this.checkGato.UseVisualStyleBackColor = true;
            // 
            // checkCristal
            // 
            this.checkCristal.AutoSize = true;
            this.checkCristal.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.checkCristal.Location = new System.Drawing.Point(453, 92);
            this.checkCristal.Name = "checkCristal";
            this.checkCristal.Size = new System.Drawing.Size(105, 21);
            this.checkCristal.TabIndex = 28;
            this.checkCristal.Text = "Cristal Roto";
            this.checkCristal.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 26);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // checkIzFrontal
            // 
            this.checkIzFrontal.AutoSize = true;
            this.checkIzFrontal.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.checkIzFrontal.Location = new System.Drawing.Point(3, 57);
            this.checkIzFrontal.Name = "checkIzFrontal";
            this.checkIzFrontal.Size = new System.Drawing.Size(100, 24);
            this.checkIzFrontal.TabIndex = 30;
            this.checkIzFrontal.Text = "Izq. Frontal";
            this.checkIzFrontal.UseVisualStyleBackColor = true;
            // 
            // checkIzTrasera
            // 
            this.checkIzTrasera.AutoSize = true;
            this.checkIzTrasera.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.checkIzTrasera.Location = new System.Drawing.Point(3, 111);
            this.checkIzTrasera.Name = "checkIzTrasera";
            this.checkIzTrasera.Size = new System.Drawing.Size(106, 24);
            this.checkIzTrasera.TabIndex = 31;
            this.checkIzTrasera.Text = "Izq. Trasera";
            this.checkIzTrasera.UseVisualStyleBackColor = true;
            // 
            // checkDereFrontal
            // 
            this.checkDereFrontal.AutoSize = true;
            this.checkDereFrontal.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.checkDereFrontal.Location = new System.Drawing.Point(117, 57);
            this.checkDereFrontal.Name = "checkDereFrontal";
            this.checkDereFrontal.Size = new System.Drawing.Size(105, 24);
            this.checkDereFrontal.TabIndex = 32;
            this.checkDereFrontal.Text = "Der. Frontal";
            this.checkDereFrontal.UseVisualStyleBackColor = true;
            // 
            // checkDerTrasera
            // 
            this.checkDerTrasera.AutoSize = true;
            this.checkDerTrasera.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.checkDerTrasera.Location = new System.Drawing.Point(117, 111);
            this.checkDerTrasera.Name = "checkDerTrasera";
            this.checkDerTrasera.Size = new System.Drawing.Size(111, 24);
            this.checkDerTrasera.TabIndex = 33;
            this.checkDerTrasera.Text = "Der. Trasera";
            this.checkDerTrasera.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.checkIzTrasera, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.checkIzFrontal, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.checkDereFrontal, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.checkDerTrasera, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.txtBuscar, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(603, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(256, 169);
            this.tableLayoutPanel5.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 54);
            this.label5.TabIndex = 0;
            this.label5.Text = "Estado Gomas";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBuscar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.txtBuscar.Location = new System.Drawing.Point(117, 21);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(128, 30);
            this.txtBuscar.TabIndex = 34;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // Inspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 461);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Inspeccion";
            this.Text = "Inspeccion";
            this.Load += new System.EventHandler(this.Inspeccion_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInspeccion)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ChckEstado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridViewInspeccion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.ComboBox comboEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboCombustible;
        private System.Windows.Forms.CheckBox checkRalladuras;
        private System.Windows.Forms.CheckBox checkRepuesta;
        private System.Windows.Forms.CheckBox checkGato;
        private System.Windows.Forms.CheckBox checkCristal;
        private System.Windows.Forms.CheckBox checkIzTrasera;
        private System.Windows.Forms.CheckBox checkIzFrontal;
        private System.Windows.Forms.CheckBox checkDereFrontal;
        private System.Windows.Forms.CheckBox checkDerTrasera;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}