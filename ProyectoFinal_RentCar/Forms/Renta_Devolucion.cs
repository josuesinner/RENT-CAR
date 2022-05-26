﻿using ProyectoFinal_RentCar.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_RentCar.Forms
{
    public partial class Renta_Devolucion : Form
    {
        public Renta_Devolucion()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtCantidadDias.Text = "";
            txtComentario.Text = "";
            txtMonto.Text = "";
            ChckEstado.Checked = false;
        }

        private void ComboVehiculo()
        {
            LLenarCombo datos = new LLenarCombo();

            var LstVehi = datos.ComboVehiculo();
            if (LstVehi.Count > 0)
            {
                comboVehiculo.DisplayMember = "Descripción";
                comboVehiculo.ValueMember = "Id_Vehiculo";
                comboVehiculo.DataSource = LstVehi;
            }
        }

        private void ComboCliente()
        {
            LLenarCombo datos = new LLenarCombo();

            var LstCli = datos.ComboCliente();
            if (LstCli.Count > 0)
            {
                comboCliente.DisplayMember = "Nombre";
                comboCliente.ValueMember = "Id_Cliente";
                comboCliente.DataSource = LstCli;
            }
        }

        private void ComboEmpleado()
        {
            LLenarCombo datos = new LLenarCombo();

            var LstEmp = datos.ComboEmpleado();
            if (LstEmp.Count > 0)
            {
                comboEmpleado.DisplayMember = "Nombre";
                comboEmpleado.ValueMember = "Id_Empleado";
                comboEmpleado.DataSource = LstEmp;
            }
        }

        private void Refresh()
        {
            using (BD_Context db = new BD_Context())
            {
                dataGridViewRentaDevo.DataSource = ModelMapperRentaDevo();
            }
        }

        private List<Renta_DevolucionViewModel> ModelMapperRentaDevo()
        {
            var list = new List<Renta_DevolucionViewModel>();

            using (BD_Context db = new BD_Context())
            {

                foreach (var item in db.Renta_Devolucions.ToList())
                {
                    list.Add(new Renta_DevolucionViewModel
                    {
                        No_Renta = item.No_Renta,
                        Empleado = db.Empleados.FirstOrDefault(x => x.Id_Empleado == item.EmpleadoId).Nombre,
                        Vehículo = db.Vehiculos.FirstOrDefault(x => x.Id_Vehiculo == item.VehiculoId).Descripción,
                        Cliente = db.Clientes.FirstOrDefault(x => x.Id_Cliente == item.ClienteId).Nombre,
                        Fecha_Renta = item.Fecha_Renta,
                        Fecha_Devolucion = item.Fecha_Devolucion,
                        Monto_Día = item.Monto_Día,
                        Cantidad_días = item.Cantidad_días,
                        Comentario = item.Comentario,
                        Estado = item.Estado
                    });
                }
            }

            return list;
        }

        private void Renta_Devolucion_Load(object sender, EventArgs e)
        {
            Refresh();
            ComboVehiculo();
            ComboCliente();
            ComboEmpleado();
        }

        private void dataGridViewRentaDevo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboEmpleado.Text = dataGridViewRentaDevo.CurrentRow.Cells[1].Value.ToString();
            comboVehiculo.Text = dataGridViewRentaDevo.CurrentRow.Cells[2].Value.ToString();
            comboCliente.Text = dataGridViewRentaDevo.CurrentRow.Cells[3].Value.ToString();
            dateTimePickerRenta.Text = DateTime.Parse(dataGridViewRentaDevo.CurrentRow.Cells[4].Value.ToString()).ToString();
            dateTimePickerDevo.Text = DateTime.Parse(dataGridViewRentaDevo.CurrentRow.Cells[5].Value.ToString()).ToString();
            txtMonto.Text = dataGridViewRentaDevo.CurrentRow.Cells[6].Value.ToString();
            txtCantidadDias.Text = dataGridViewRentaDevo.CurrentRow.Cells[7].Value.ToString();
            txtComentario.Text = dataGridViewRentaDevo.CurrentRow.Cells[8].Value.ToString();
            if (dataGridViewRentaDevo.CurrentRow.Cells[9].Value.ToString() == "INACTIVO")
            {
                ChckEstado.Checked = true;
            }
            else if (dataGridViewRentaDevo.CurrentRow.Cells[9].Value.ToString() == "ACTIVO")
            {
                ChckEstado.Checked = false;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                using (BD_Context db = new BD_Context())
                {
                    Class.Renta_Devolucion renta_Devolucion = new Class.Renta_Devolucion();

                    renta_Devolucion.VehiculoId = (int)comboVehiculo.SelectedValue;
                    renta_Devolucion.ClienteId = (int)comboCliente.SelectedValue;
                    renta_Devolucion.EmpleadoId = (int)comboEmpleado.SelectedValue;
                    renta_Devolucion.Fecha_Renta = DateTime.Parse(dateTimePickerRenta.Text.ToString());
                    renta_Devolucion.Fecha_Devolucion = DateTime.Parse(dateTimePickerDevo.Text.ToString());
                    renta_Devolucion.Cantidad_días = int.Parse(txtCantidadDias.Text);
                    renta_Devolucion.Monto_Día = txtCantidadDias.Text.ToString();
                    renta_Devolucion.Comentario = txtComentario.Text.ToString();
                    if (ChckEstado.Checked)
                    {
                        renta_Devolucion.Estado = "INACTIVO";
                    }
                    else
                    {
                        renta_Devolucion.Estado = "ACTIVO";
                    }

                    db.Renta_Devolucions.Add(renta_Devolucion);

                    db.SaveChanges();
                }

                MessageBox.Show("Renta del Vehiculo " + comboVehiculo.Text.ToString() + " para el Cliente "
                    + comboCliente.Text.ToString() + " creado satisfactoriamente!", "RENT-CAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Refresh();
                LimpiarCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                using (BD_Context db = new BD_Context())
                {
                    int id = int.Parse(dataGridViewRentaDevo.CurrentRow.Cells[1].Value.ToString());

                    Class.Renta_Devolucion renta_Devolucion = db.Renta_Devolucions.FirstOrDefault(x => x.No_Renta == id);

                    renta_Devolucion.VehiculoId = (int)comboVehiculo.SelectedValue;
                    renta_Devolucion.ClienteId = (int)comboCliente.SelectedValue;
                    renta_Devolucion.EmpleadoId = (int)comboEmpleado.SelectedValue;
                    renta_Devolucion.Fecha_Renta = DateTime.Parse(dateTimePickerRenta.Text.ToString());
                    renta_Devolucion.Fecha_Devolucion = DateTime.Parse(dateTimePickerDevo.Text.ToString());
                    renta_Devolucion.Cantidad_días = int.Parse(txtCantidadDias.Text);
                    renta_Devolucion.Monto_Día = txtCantidadDias.Text.ToString();
                    renta_Devolucion.Comentario = txtComentario.Text.ToString();
                    if (ChckEstado.Checked)
                    {
                        renta_Devolucion.Estado = "INACTIVO";
                    }
                    else
                    {
                        renta_Devolucion.Estado = "ACTIVO";
                    }
                    
                    db.SaveChanges();
                }

                MessageBox.Show("Renta del vehiculo " + comboVehiculo.Text.ToString() + " editado Satisfactoriamente", "RENT-CAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


                Refresh();
                LimpiarCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (BD_Context db = new BD_Context())
                {
                    int id = int.Parse(dataGridViewRentaDevo.CurrentRow.Cells[1].Value.ToString());

                    Class.Renta_Devolucion renta_Devolucion = db.Renta_Devolucions.FirstOrDefault(x => x.No_Renta == id);

                    db.Renta_Devolucions.Remove(renta_Devolucion);

                    if (MessageBox.Show("Esta seguro que quiere borrar este registro?", "RENT-CAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.SaveChanges();
                    }
                }

                Refresh();
                LimpiarCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
