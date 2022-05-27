using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal_RentCar.Class;

namespace ProyectoFinal_RentCar.Forms
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            comboPersona.Items.Add("COMUN");
            comboPersona.Items.Add("JURIDICA");
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

        private void Refresh()
        {
            using (BD_Context db = new BD_Context())
            {
                dataGridViewCliente.DataSource = db.Clientes.ToList();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtTarjeta.Text = "";
            txtCredito.Text = "";
            comboPersona.Text = "";
            ChckEstado.Checked = false;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtCedula.Text == "" || txtCredito.Text == "" || txtTarjeta.Text == "")
                {
                    MessageBox.Show("No puede haber campos vacios",
                            "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(txtNombre.Text != "" || txtCedula.Text != "" || txtCredito.Text != "" || txtTarjeta.Text != "")
                {
                    using (BD_Context db = new BD_Context())
                    {
                        string vacio = comboPersona.Text.ToString();
                        int limite = int.Parse(txtCredito.Text.ToString());
                        Cliente cliente = new Cliente();

                        cliente.Nombre = txtNombre.Text.ToString().ToUpper();
                        cliente.Cedula = txtCedula.Text.ToString();
                        cliente.No_Tarjeta_CR = txtTarjeta.Text.ToString();
                        if (vacio == "")
                        {
                            cliente.Tipo_Persona = "COMUN";

                        }
                        else
                        {
                            cliente.Tipo_Persona = comboPersona.Text.ToString();
                        }

                        if (limite > 25000)
                        {
                            MessageBox.Show("No puede ser mayor a 25,000 pesos",
                                "Limite de Credito alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if ((limite < 25000))
                        {
                            cliente.Límite_Credito = txtCredito.Text.ToString();

                            if (ChckEstado.Checked)
                            {
                                cliente.Estado = "INACTIVO";
                            }
                            else
                            {
                                cliente.Estado = "ACTIVO";
                            }

                            db.Clientes.Add(cliente);

                            db.SaveChanges();

                            MessageBox.Show("Cliente " + txtNombre.Text.ToString().ToUpper() +
                                " creado Satisfactoriamente", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Refresh();
                            LimpiarCampos();
                        }

                    }
                }

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
                    int id = int.Parse(dataGridViewCliente.CurrentRow.Cells[0].Value.ToString());

                    Cliente cliente = db.Clientes.FirstOrDefault(x => x.Id_Cliente == id);

                    db.Clientes.Remove(cliente);

                    if (MessageBox.Show("Esta seguro que quiere borrar este registro?","RENT-CAR",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtCedula.Text == "" || txtCredito.Text == "" || txtTarjeta.Text == "")
                {
                    MessageBox.Show("No puede haber campos vacios",
                            "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNombre.Text != "" || txtCedula.Text != "" || txtCredito.Text != "" || txtTarjeta.Text != "") {

                    using (BD_Context db = new BD_Context())
                    {
                        string vacio = comboPersona.Text.ToString();
                        int limite = int.Parse(txtCredito.Text.ToString());

                        int id = int.Parse(dataGridViewCliente.CurrentRow.Cells[0].Value.ToString());

                        Cliente cliente = db.Clientes.FirstOrDefault(x => x.Id_Cliente == id);

                        cliente.Nombre = txtNombre.Text.ToString().ToUpper();
                        cliente.Cedula = txtCedula.Text.ToString();
                        cliente.No_Tarjeta_CR = txtTarjeta.Text.ToString();
                        if (vacio == "")
                        {
                            cliente.Tipo_Persona = "COMUN";

                        }
                        else
                        {
                            cliente.Tipo_Persona = comboPersona.Text.ToString();
                        }

                        if (limite > 25000)
                        {
                            MessageBox.Show("No puede ser mayor a 25,000 pesos",
                                "Limite de Credito alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if ((limite < 25000))
                        {
                            cliente.Límite_Credito = txtCredito.Text.ToString();

                            if (ChckEstado.Checked)
                            {
                                cliente.Estado = "INACTIVO";
                            }
                            else
                            {
                                cliente.Estado = "ACTIVO";
                            }

                            db.SaveChanges();
                            MessageBox.Show("Cliente editado Satisfactoriamente", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Refresh();
                            LimpiarCampos();
                        }
                    }
                    
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dataGridViewCliente.CurrentRow.Cells[1].Value.ToString();
            txtCedula.Text = dataGridViewCliente.CurrentRow.Cells[2].Value.ToString();
            txtTarjeta.Text = dataGridViewCliente.CurrentRow.Cells[3].Value.ToString();
            txtCredito.Text = dataGridViewCliente.CurrentRow.Cells[4].Value.ToString();
            comboPersona.Text = dataGridViewCliente.CurrentRow.Cells[5].Value.ToString();
            if (dataGridViewCliente.CurrentRow.Cells[6].Value.ToString() == "INACTIVO")
            {
                ChckEstado.Checked = true;
            }
            else if (dataGridViewCliente.CurrentRow.Cells[6].Value.ToString() == "ACTIVO")
            {
                ChckEstado.Checked = false;
            }
        }

        ErrorProvider errorP = new ErrorProvider();

        private void txtCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = soloNumeros(e);
            if (!validar)
                errorP.SetError(txtCredito, "Solo Numeros");
            else
                errorP.Clear();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BD_Context db = new BD_Context();
            if (txtBuscar.Text !="")
            {
                dataGridViewCliente.CurrentCell = null;

                foreach (DataGridViewRow r in dataGridViewCliente.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dataGridViewCliente.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtBuscar.Text.ToUpper())==0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dataGridViewCliente.DataSource = db.Clientes.ToList();
            }
        }
    }
}
