using ProyectoFinal_RentCar.Class;
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
            txtCantidadDias.Text = "0";
        }

        public bool VehicleIsInspected(int idVehicle, int idClient, DateTime inspectionDate)
        {
            BD_Context bd = new BD_Context();

            var exists = bd.Inspeccions
                            .FirstOrDefault(x => x.VehículoId == idVehicle && x.ClienteId == idClient
                                            && x.Fecha == inspectionDate);
            return exists != null;
        }

        public void exportarExcel(DataGridView tabla)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                int IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = col.Name;
                }
                int IndiceFila = 0;

                foreach (DataGridViewRow row in tabla.Rows)
                {
                    IndiceFila++;
                    IndiceColumna = 0;

                    foreach (DataGridViewColumn col in tabla.Columns)
                    {
                        IndiceColumna++;
                        excel.Cells[IndiceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                    }
                }
                excel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static bool soloNumeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }


        private void LimpiarCampos()
        {
            txtCantidadDias.Text = "";
            txtComentario.Text = "";
            txtMonto.Text = "";
            checkBoxDevuelto.Checked = false;
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

        private void CalcularDiferencia()
        {
            DateTime fechaInicio = dateTimePickerRenta.Value.Date;
            DateTime fechaFinal = dateTimePickerDevo.Value.Date;

            TimeSpan tSpan = fechaFinal - fechaInicio;

            int Dias = tSpan.Days;

            txtCantidadDias.Text = Dias.ToString();
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
                        Devolucion = item.Devolucion,
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

            if (dataGridViewRentaDevo.CurrentRow.Cells[9].Value.ToString() == "DEVOLUCION")
            {
                checkBoxDevuelto.Checked = true;
            }
            else if (dataGridViewRentaDevo.CurrentRow.Cells[9].Value.ToString() == "RENTA")
            {
                checkBoxDevuelto.Checked = false;
            }

            if (dataGridViewRentaDevo.CurrentRow.Cells[10].Value.ToString() == "INACTIVO")
            {
                ChckEstado.Checked = true;
            }
            else if (dataGridViewRentaDevo.CurrentRow.Cells[10].Value.ToString() == "ACTIVO")
            {
                ChckEstado.Checked = false;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMonto.Text == "" )
                {
                    MessageBox.Show("No puede haber campos vacios",
                            "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtMonto.Text != "" )
                {
                    var insp = VehicleIsInspected((int)comboVehiculo.SelectedValue, (int)comboCliente.SelectedValue, DateTime.Parse(dateTimePickerRenta.Text.ToString()));
                    if (insp == false)
                    {
                        MessageBox.Show("El vehiculo " + comboVehiculo.Text.ToString() + " necesita ser Inspeccionado "
                             , "RENT-CAR",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
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
                            renta_Devolucion.Monto_Día = txtMonto.Text.ToString();
                            renta_Devolucion.Comentario = txtComentario.Text.ToString();

                            if (checkBoxDevuelto.Checked)
                            {
                                renta_Devolucion.Devolucion = "DEVOLUCION";
                            }
                            else
                            {
                                renta_Devolucion.Devolucion = "RENTA";
                            }

                            if (ChckEstado.Checked)
                            {
                                renta_Devolucion.Estado = "INACTIVO";
                            }
                            else
                            {
                                renta_Devolucion.Estado = "ACTIVO";
                            }

                            var query = db.Renta_Devolucions.Where(x => x.VehiculoId == renta_Devolucion.VehiculoId && x.Devolucion == renta_Devolucion.Devolucion && (renta_Devolucion.Fecha_Renta >= x.Fecha_Renta &&
                    renta_Devolucion.Fecha_Devolucion <= x.Fecha_Devolucion || renta_Devolucion.Fecha_Renta >= x.Fecha_Renta && renta_Devolucion.Fecha_Devolucion <= x.Fecha_Devolucion)).Count();

                            if (query != 0)
                            {
                                MessageBox.Show("El vehiculo " + comboVehiculo.Text.ToString() + " esta rentado "
                             , "RENT-CAR",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                db.Renta_Devolucions.Add(renta_Devolucion);
                                db.SaveChanges();

                                MessageBox.Show("Renta del Vehiculo " + comboVehiculo.Text.ToString() + " para el Cliente "
                            + comboCliente.Text.ToString() + " creado satisfactoriamente!", "RENT-CAR",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }

                    Refresh();
                    LimpiarCampos();
                }
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
                    int id = int.Parse(dataGridViewRentaDevo.CurrentRow.Cells[0].Value.ToString());

                    Class.Renta_Devolucion renta_Devolucion = db.Renta_Devolucions.FirstOrDefault(x => x.No_Renta == id);

                    renta_Devolucion.VehiculoId = (int)comboVehiculo.SelectedValue;
                    renta_Devolucion.ClienteId = (int)comboCliente.SelectedValue;
                    renta_Devolucion.EmpleadoId = (int)comboEmpleado.SelectedValue;
                    renta_Devolucion.Fecha_Renta = DateTime.Parse(dateTimePickerRenta.Text.ToString());
                    renta_Devolucion.Fecha_Devolucion = DateTime.Parse(dateTimePickerDevo.Text.ToString());
                    renta_Devolucion.Cantidad_días = int.Parse(txtCantidadDias.Text);
                    renta_Devolucion.Monto_Día = txtMonto.Text.ToString();
                    renta_Devolucion.Comentario = txtComentario.Text.ToString();

                    if (checkBoxDevuelto.Checked)
                    {
                        renta_Devolucion.Devolucion = "DEVOLUCION";
                    }
                    else
                    {
                        renta_Devolucion.Devolucion = "RENTA";
                    }

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
                    int id = int.Parse(dataGridViewRentaDevo.CurrentRow.Cells[0].Value.ToString());

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

        private void dateTimePickerDevo_ValueChanged(object sender, EventArgs e)
        {
            CalcularDiferencia();
        }

        ErrorProvider errorP = new ErrorProvider();

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = soloNumeros(e);
            if (!validar)
                errorP.SetError(txtMonto, "Solo Numeros");
            else
                errorP.Clear();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BD_Context db = new BD_Context();
            if (txtBuscar.Text != "")
            {
                dataGridViewRentaDevo.CurrentCell = null;

                foreach (DataGridViewRow r in dataGridViewRentaDevo.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dataGridViewRentaDevo.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtBuscar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dataGridViewRentaDevo.DataSource = ModelMapperRentaDevo();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            exportarExcel(dataGridViewRentaDevo);

        }
    }
}
