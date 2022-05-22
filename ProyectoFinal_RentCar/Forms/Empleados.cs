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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
            comboHorario.Items.Add("DIA");
            comboHorario.Items.Add("TARDE");
            comboHorario.Items.Add("NOCHE");

        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtComision.Text = "";
            ChckEstado.Checked = false;
        }

        private void Refresh()
        {
            using (BD_Context db = new BD_Context())
            {
                dataGridViewEmpleado.DataSource = db.Empleados.ToList();
            }
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void dataGridViewEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dataGridViewEmpleado.CurrentRow.Cells[1].Value.ToString();
            txtCedula.Text = dataGridViewEmpleado.CurrentRow.Cells[2].Value.ToString();
            comboHorario.Text = dataGridViewEmpleado.CurrentRow.Cells[3].Value.ToString();
            txtComision.Text = dataGridViewEmpleado.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = DateTime.Parse(dataGridViewEmpleado.CurrentRow.Cells[5].Value.ToString()).ToString();


            if (dataGridViewEmpleado.CurrentRow.Cells[6].Value.ToString() == "INACTIVO")
            {
                ChckEstado.Checked = true;
            }
            else if (dataGridViewEmpleado.CurrentRow.Cells[6].Value.ToString() == "ACTIVO")
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
                    Class.Empleado empleado = new Class.Empleado();

                    empleado.Nombre = txtNombre.Text.ToString().ToUpper();
                    empleado.Cedula = txtCedula.Text.ToString();
                    empleado.Tanda_Labor = comboHorario.Text.ToString();
                    empleado.Porciento_Comision = txtComision.Text.ToString();
                    empleado.Fecha_Ingreso = DateTime.Parse(dateTimePicker1.Text.ToString());

                    if (ChckEstado.Checked)
                    {
                        empleado.Estado = "INACTIVO";
                    }
                    else
                    {
                        empleado.Estado = "ACTIVO";
                    }

                    db.Empleados.Add(empleado);

                    db.SaveChanges();
                }

                MessageBox.Show("Empleado " + txtNombre.Text.ToString().ToUpper() + " creado satisfactoriamente!", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    int id = int.Parse(dataGridViewEmpleado.CurrentRow.Cells[0].Value.ToString());

                    Class.Empleado empleado = db.Empleados.FirstOrDefault(x => x.Id_Empleado == id);

                    empleado.Nombre = txtNombre.Text.ToString().ToUpper();
                    empleado.Cedula = txtCedula.Text.ToString();
                    empleado.Tanda_Labor = comboHorario.Text.ToString();
                    empleado.Porciento_Comision = txtComision.Text.ToString();
                    empleado.Fecha_Ingreso = DateTime.Parse(dateTimePicker1.Text.ToString());

                    if (ChckEstado.Checked)
                    {
                        empleado.Estado = "INACTIVO";
                    }
                    else
                    {
                        empleado.Estado = "ACTIVO";
                    }

                    db.SaveChanges();

                }
                MessageBox.Show("Empleado editado Satisfactoriamente", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    int id = int.Parse(dataGridViewEmpleado.CurrentRow.Cells[0].Value.ToString());

                    Class.Empleado empleado = db.Empleados.FirstOrDefault(x => x.Id_Empleado == id);

                    db.Empleados.Remove(empleado);

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
