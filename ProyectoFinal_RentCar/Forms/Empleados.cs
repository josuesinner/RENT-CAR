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

        public static bool soloLetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
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
                dataGridViewEmpleado.CurrentCell = null;

                foreach (DataGridViewRow r in dataGridViewEmpleado.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dataGridViewEmpleado.Rows)
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
                dataGridViewEmpleado.DataSource = db.Empleados.ToList();
            }
        }

        ErrorProvider errorP = new ErrorProvider();

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bool validar = soloLetras(e);
            //if (!validar)
            //    errorP.SetError(txtNombre, "Solo Letras");
            //else
            //    errorP.Clear();
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            ValidarCedula validarCedula = new ValidarCedula();

            try
            {
                if (txtNombre.Text == "" || txtCedula.Text == "" || txtComision.Text == "")
                {
                    MessageBox.Show("No puede haber campos vacios",
                            "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNombre.Text != "" || txtCedula.Text != "" || txtComision.Text != "")
                {

                    using (BD_Context db = new BD_Context())
                    {
                        int limite = int.Parse(txtComision.Text.ToString());
                        string vacio = comboHorario.Text.ToString();

                        Class.Empleado empleado = new Class.Empleado();

                        empleado.Nombre = txtNombre.Text.ToString().ToUpper();


                        if (validarCedula.IsValidIdNumber(txtCedula.Text.ToString()))
                        {
                            empleado.Cedula = txtCedula.Text.ToString();

                            if (vacio == "")
                            {
                                empleado.Tanda_Labor = "DIA";

                            }
                            else
                            {
                                empleado.Tanda_Labor = comboHorario.Text.ToString();
                            }

                            if (limite > 15)
                            {
                                MessageBox.Show("La comision no puede ser mayor al 15%",
                                    "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (limite <= 15)
                            {
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

                                MessageBox.Show("Empleado " + txtNombre.Text.ToString().ToUpper() + " creado satisfactoriamente!", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Refresh();
                                LimpiarCampos();
                            }


                        }
                        else
                        {
                            MessageBox.Show("Cedula Invalida",
                                "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                    }


                }
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
                ValidarCedula validarCedula = new ValidarCedula();

                if (txtNombre.Text == "" || txtCedula.Text == "" || txtComision.Text == "")
                {
                    MessageBox.Show("No puede haber campos vacios",
                            "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNombre.Text != "" || txtCedula.Text != "" || txtComision.Text != "")
                {

                    using (BD_Context db = new BD_Context())
                    {
                        int limite = int.Parse(txtComision.Text.ToString());

                        int id = int.Parse(dataGridViewEmpleado.CurrentRow.Cells[0].Value.ToString());

                        Class.Empleado empleado = db.Empleados.FirstOrDefault(x => x.Id_Empleado == id);

                        empleado.Nombre = txtNombre.Text.ToString().ToUpper();


                        if (validarCedula.IsValidIdNumber(txtCedula.Text.ToString()))
                        {
                            empleado.Cedula = txtCedula.Text.ToString();
                            empleado.Tanda_Labor = comboHorario.Text.ToString();

                            if (limite > 15)
                            {
                                MessageBox.Show("La comision no puede ser mayor al 15%",
                                    "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (limite <= 15)
                            {
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
                                MessageBox.Show("Empleado editado Satisfactoriamente", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Refresh();
                                LimpiarCampos();
                            }


                        }
                        else
                        {
                            MessageBox.Show("Cedula Invalida",
                                "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }



                    }

                }

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
