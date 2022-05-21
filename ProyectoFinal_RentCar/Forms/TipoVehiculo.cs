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
    public partial class TipoVehiculo : Form
    {
        public TipoVehiculo()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            using (BD_Context db = new BD_Context())
            {
                dataGridViewTipoVehiculo.DataSource = db.Tipo_Vehiculos.ToList();
            }
        }

        private void LimpiarCampos()
        {
            txtTipoVehiculo.Text = "";
            ChckEstado.Checked = false;
        }

        private void TipoVehiculo_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void dataGridViewTipoVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTipoVehiculo.Text = dataGridViewTipoVehiculo.CurrentRow.Cells[1].Value.ToString();

            if (dataGridViewTipoVehiculo.CurrentRow.Cells[2].Value.ToString() == "INACTIVO")
            {
                ChckEstado.Checked = true;
            }
            else if (dataGridViewTipoVehiculo.CurrentRow.Cells[2].Value.ToString() == "ACTIVO")
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
                    Class.Tipo_Vehiculo  tipoVehiculo = new Class.Tipo_Vehiculo();

                    tipoVehiculo.Descripcion = txtTipoVehiculo.Text.ToString().ToUpper();

                    if (ChckEstado.Checked)
                    {
                        tipoVehiculo.Estado = "INACTIVO";
                    }
                    else
                    {
                        tipoVehiculo.Estado = "ACTIVO";
                    }

                    db.Tipo_Vehiculos.Add(tipoVehiculo);

                    db.SaveChanges();
                }

                MessageBox.Show("El registro " + txtTipoVehiculo.Text.ToString().ToUpper() + " fue creado satisfactoriamente!", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
