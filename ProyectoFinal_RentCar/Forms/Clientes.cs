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
                using (BD_Context db = new BD_Context())
                {
                    Cliente cliente = new Cliente();

                    cliente.Nombre = txtNombre.Text.ToString();
                    cliente.Cedula = txtCedula.Text.ToString();
                    cliente.No_Tarjeta_CR = txtTarjeta.Text.ToString();
                    cliente.Límite_Credito = txtCredito.Text.ToString();
                    cliente.Tipo_Persona = comboPersona.Text.ToString();
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
                }

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
                using (BD_Context db = new BD_Context())
                {
                    int id = int.Parse(dataGridViewCliente.CurrentRow.Cells[0].Value.ToString());

                    Cliente cliente = db.Clientes.FirstOrDefault(x=>x.Id_Cliente==id);

                    cliente.Nombre = txtNombre.Text.ToString();
                    cliente.Cedula = txtCedula.Text.ToString();
                    cliente.No_Tarjeta_CR = txtTarjeta.Text.ToString();
                    cliente.Límite_Credito = txtCredito.Text.ToString();
                    cliente.Tipo_Persona = comboPersona.Text.ToString();

                    if (ChckEstado.Checked)
                    {
                        cliente.Estado = "INACTIVO";
                    }
                    else
                    {
                        cliente.Estado = "ACTIVO";
                    }

                    db.SaveChanges();
                    
                }
                MessageBox.Show("Cliente editado Satisfactoriamente", "RENT-CAR",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Refresh();
                LimpiarCampos();

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
    }
}
