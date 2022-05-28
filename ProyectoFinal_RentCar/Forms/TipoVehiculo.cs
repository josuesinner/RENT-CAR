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
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        ErrorProvider errorP = new ErrorProvider();

        private void txtTipoVehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = soloLetras(e);
            if (!validar)
                errorP.SetError(txtTipoVehiculo, "Solo Letras");
            else
                errorP.Clear();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BD_Context db = new BD_Context();
            if (txtBuscar.Text != "")
            {
                dataGridViewTipoVehiculo.CurrentCell = null;

                foreach (DataGridViewRow r in dataGridViewTipoVehiculo.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dataGridViewTipoVehiculo.Rows)
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
                dataGridViewTipoVehiculo.DataSource = db.Tipo_Vehiculos.ToList();
            }
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtTipoVehiculo.Text == "")
                {
                    MessageBox.Show("No puede haber campos vacios",
                            "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtTipoVehiculo.Text != "")
                {

                    using (BD_Context db = new BD_Context())
                    {
                        Class.Tipo_Vehiculo tipoVehiculo = new Class.Tipo_Vehiculo();

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

                    MessageBox.Show("El tipo de Vhiculo " + txtTipoVehiculo.Text.ToString().ToUpper() + " fue creado satisfactoriamente!", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Refresh();
                    LimpiarCampos();
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
                if (txtTipoVehiculo.Text == "")
                {
                    MessageBox.Show("No puede haber campos vacios",
                            "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtTipoVehiculo.Text != "")
                {

                    using (BD_Context db = new BD_Context())
                    {
                        int id = int.Parse(dataGridViewTipoVehiculo.CurrentRow.Cells[0].Value.ToString());

                        Class.Tipo_Vehiculo tipo_Vehiculo = db.Tipo_Vehiculos.FirstOrDefault(x => x.Id_Tipo_Vehiculo == id);

                        tipo_Vehiculo.Descripcion = txtTipoVehiculo.Text.ToString();

                        if (ChckEstado.Checked)
                        {
                            tipo_Vehiculo.Estado = "INACTIVO";
                        }
                        else
                        {
                            tipo_Vehiculo.Estado = "ACTIVO";
                        }

                        db.SaveChanges();

                    }
                    MessageBox.Show("Tipo de Vehiculo editado Satisfactoriamente", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh();
                    LimpiarCampos();
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
                    int id = int.Parse(dataGridViewTipoVehiculo.CurrentRow.Cells[0].Value.ToString());

                    Class.Tipo_Vehiculo tipo_Vehiculo = db.Tipo_Vehiculos.FirstOrDefault(x => x.Id_Tipo_Vehiculo == id);

                    db.Tipo_Vehiculos.Remove(tipo_Vehiculo);

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
