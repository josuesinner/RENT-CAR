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
    public partial class Inspeccion : Form
    {
        public Inspeccion()
        {
            InitializeComponent();
            comboCombustible.Items.Add("1/4");
            comboCombustible.Items.Add("1/2");
            comboCombustible.Items.Add("3/4");
            comboCombustible.Items.Add("FULL");

        }

        private List<InspeccionViewModel> ModelMapperInspeccion()
        {
            var list = new List<InspeccionViewModel>();

            using (BD_Context db = new BD_Context())
            {

                foreach (var item in db.Inspeccions.ToList())
                {
                    list.Add(new InspeccionViewModel
                    {
                        Id_Transacción = item.Id_Transacción,
                        Vehículo = db.Vehiculos.FirstOrDefault(x => x.Id_Vehiculo == item.VehículoId).Descripción,
                        Cedula = db.Clientes.FirstOrDefault(x => x.Id_Cliente == item.ClienteId).Cedula,
                        Cliente = db.Clientes.FirstOrDefault(x => x.Id_Cliente == item.ClienteId).Nombre,
                        Tiene_Ralladuras = item.Tiene_Ralladuras,
                        Cantidad_Combustible = item.Cantidad_Combustible,
                        Goma_respuesta = item.Goma_respuesta,
                        Tiene_Gato = item.Tiene_Gato,
                        roturas_cristal = item.roturas_cristal,
                        Estado_gomas = item.Estado_gomas,
                        Etc = item.Etc,
                        Fecha = item.Fecha,
                        Empleado = db.Empleados.FirstOrDefault(x => x.Id_Empleado == item.EmpleadoId).Nombre,
                        Estado = item.Estado
                    });
                }
            }

            return list;
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

        private void ComboCombustible()
        {
            LLenarCombo datos = new LLenarCombo();

            var LstComb = datos.ComboCombustible();
            if (LstComb.Count > 0)
            {
                comboCombustible.DisplayMember = "Descripcion";
                comboCombustible.ValueMember = "Id_Combustible";
                comboCombustible.DataSource = LstComb;
            }
        }

        private void Refresh()
        {
            using (BD_Context db = new BD_Context())
            {
                dataGridViewInspeccion.DataSource = ModelMapperInspeccion();
            }
        }

        private void LimpiarCampos()
        {
            checkRalladuras.Checked = false;
            checkRepuesta.Checked = false;
            checkGato.Checked = false;
            checkCristal.Checked = false;
            checkIzFrontal.Checked = false;
            checkDereFrontal.Checked = false;
            checkDerTrasera.Checked = false;
            checkIzTrasera.Checked = false;
            ChckEstado.Checked = false;
        }

        private void Inspeccion_Load(object sender, EventArgs e)
        {
            Refresh();
            ComboVehiculo();
            ComboCliente();
            ComboEmpleado();
            //ComboCombustible();
        }

        private void dataGridViewInspeccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewInspeccion.CurrentRow.Cells[0].Value.ToString();
            comboVehiculo.Text = dataGridViewInspeccion.CurrentRow.Cells[1].Value.ToString();
            comboCliente.Text = dataGridViewInspeccion.CurrentRow.Cells[3].Value.ToString();
            comboEmpleado.Text = dataGridViewInspeccion.CurrentRow.Cells[12].Value.ToString();
            comboCombustible.Text = dataGridViewInspeccion.CurrentRow.Cells[5].Value.ToString();

            if (dataGridViewInspeccion.CurrentRow.Cells[4].Value.ToString() == "SI")
            {
                checkRalladuras.Checked = true;
            }
            else if (dataGridViewInspeccion.CurrentRow.Cells[4].Value.ToString() == "NO")
            {
                checkRalladuras.Checked = false;
            }

            if (dataGridViewInspeccion.CurrentRow.Cells[6].Value.ToString() == "SI")
            {
                checkRepuesta.Checked = true;
            }
            else if (dataGridViewInspeccion.CurrentRow.Cells[6].Value.ToString() == "NO")
            {
                checkRepuesta.Checked = false;
            }

            if (dataGridViewInspeccion.CurrentRow.Cells[7].Value.ToString() == "SI")
            {
                checkGato.Checked = true;
            }
            else if (dataGridViewInspeccion.CurrentRow.Cells[7].Value.ToString() == "NO")
            {
                checkGato.Checked = false;
            }

            if (dataGridViewInspeccion.CurrentRow.Cells[8].Value.ToString() == "SI")
            {
                checkCristal.Checked = true;
            }
            else if (dataGridViewInspeccion.CurrentRow.Cells[8].Value.ToString() == "NO")
            {
                checkCristal.Checked = false;
            }

            if (dataGridViewInspeccion.CurrentRow.Cells[9].Value.ToString() == "Las 4 gomas estan bien")
            {
                checkDereFrontal.Checked = true;
                checkDerTrasera.Checked = true;
                checkIzFrontal.Checked = true;
                checkIzTrasera.Checked = true;
            }

            dateTimePicker1.Text = DateTime.Parse( dataGridViewInspeccion.CurrentRow.Cells[11].Value.ToString()).ToString();



            if (dataGridViewInspeccion.CurrentRow.Cells[13].Value.ToString() == "INACTIVO")
            {
                ChckEstado.Checked = true;
            }
            else if (dataGridViewInspeccion.CurrentRow.Cells[13].Value.ToString() == "ACTIVO")
            {
                ChckEstado.Checked = false;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BD_Context db = new BD_Context();
            if (txtBuscar.Text != "")
            {
                dataGridViewInspeccion.CurrentCell = null;

                foreach (DataGridViewRow r in dataGridViewInspeccion.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dataGridViewInspeccion.Rows)
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
                dataGridViewInspeccion.DataSource = ModelMapperInspeccion();
            }
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (BD_Context db = new BD_Context())
                {
                    Class.Inspeccion inspeccion = new Class.Inspeccion();

                    inspeccion.VehículoId = (int)comboVehiculo.SelectedValue;
                    inspeccion.ClienteId = (int)comboCliente.SelectedValue;
                    inspeccion.EmpleadoId = (int)comboEmpleado.SelectedValue;
                    inspeccion.Cantidad_Combustible = comboCombustible.Text.ToString();
                    inspeccion.Cedula = db.Clientes.FirstOrDefault(x => x.Id_Cliente == inspeccion.ClienteId).Cedula;
                    inspeccion.Etc = "N/A";
                    inspeccion.Fecha = DateTime.Parse(dateTimePicker1.Text.ToString());

                    if (ChckEstado.Checked)
                    {
                        inspeccion.Estado = "INACTIVO";
                    }
                    else
                    {
                        inspeccion.Estado = "ACTIVO";
                    }

                    if (checkRalladuras.Checked)
                    {
                        inspeccion.Tiene_Ralladuras = "SI";
                    }
                    else
                    {
                        inspeccion.Tiene_Ralladuras = "NO";
                    }

                    if (checkRepuesta.Checked)
                    {
                        inspeccion.Goma_respuesta = "SI";
                    }
                    else
                    {
                        inspeccion.Goma_respuesta = "NO";
                    }

                    if (checkGato.Checked)
                    {
                        inspeccion.Tiene_Gato = "SI";
                    }
                    else
                    {
                        inspeccion.Tiene_Gato = "NO";
                    }

                    if (checkCristal.Checked)
                    {
                        inspeccion.roturas_cristal = "SI";
                    }
                    else
                    {
                        inspeccion.roturas_cristal = "NO";
                    }

                    if (checkIzFrontal.Checked && checkDereFrontal.Checked && checkIzTrasera.Checked && checkDerTrasera.Checked)
                    {
                        inspeccion.Estado_gomas = "Las 4 gomas estan bien";
                    }

                    db.Inspeccions.Add(inspeccion);

                    db.SaveChanges();
                }

                MessageBox.Show("Inspeccion del " + comboVehiculo.Text.ToString() + " para el Cliente "
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

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (BD_Context db = new BD_Context())
                {
                    int id = int.Parse(dataGridViewInspeccion.CurrentRow.Cells[0].Value.ToString());

                    Class.Inspeccion inspeccion = db.Inspeccions.FirstOrDefault(x => x.Id_Transacción == id);

                    inspeccion.VehículoId = (int)comboVehiculo.SelectedValue;
                    inspeccion.ClienteId = (int)comboCliente.SelectedValue;
                    inspeccion.EmpleadoId = (int)comboEmpleado.SelectedValue;
                    inspeccion.Cantidad_Combustible = comboCombustible.Text.ToString();
                    inspeccion.Cedula = db.Clientes.FirstOrDefault(x => x.Id_Cliente == inspeccion.ClienteId).Cedula;
                    inspeccion.Etc = "N/A";
                    inspeccion.Fecha = DateTime.Parse(dateTimePicker1.Text.ToString());

                    if (ChckEstado.Checked)
                    {
                        inspeccion.Estado = "INACTIVO";
                    }
                    else
                    {
                        inspeccion.Estado = "ACTIVO";
                    }

                    if (checkRalladuras.Checked)
                    {
                        inspeccion.Tiene_Ralladuras = "SI";
                    }
                    else
                    {
                        inspeccion.Tiene_Ralladuras = "NO";
                    }

                    if (checkRepuesta.Checked)
                    {
                        inspeccion.Goma_respuesta = "SI";
                    }
                    else
                    {
                        inspeccion.Goma_respuesta = "NO";
                    }

                    if (checkGato.Checked)
                    {
                        inspeccion.Tiene_Gato = "SI";
                    }
                    else
                    {
                        inspeccion.Tiene_Gato = "NO";
                    }

                    if (checkCristal.Checked)
                    {
                        inspeccion.roturas_cristal = "SI";
                    }
                    else
                    {
                        inspeccion.roturas_cristal = "NO";
                    }

                    if (checkIzFrontal.Checked && checkDereFrontal.Checked && checkIzTrasera.Checked && checkDerTrasera.Checked)
                    {
                        inspeccion.Estado_gomas = "Las 4 gomas estan bien";
                    }
                    else
                    {
                        inspeccion.Estado_gomas = "Una o varias gomas presentan fallas";

                    }

                    db.SaveChanges();
                }

                MessageBox.Show("Inspeccion al vehiculo " + comboVehiculo.Text.ToString() + " editado Satisfactoriamente", "RENT-CAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


                Refresh();
                LimpiarCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (BD_Context db = new BD_Context())
                {
                    int id = int.Parse(dataGridViewInspeccion.CurrentRow.Cells[0].Value.ToString());

                    Class.Inspeccion inspeccion = db.Inspeccions.FirstOrDefault(x => x.Id_Transacción == id);

                    db.Inspeccions.Remove(inspeccion);

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
