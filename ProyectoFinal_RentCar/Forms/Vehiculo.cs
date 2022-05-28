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
    public partial class Vehiculo : Form
    {
        public Vehiculo()
        {
            InitializeComponent();
        }


        private void LimpiarCampos()
        {
            txtDescrip.Text = "";
            txtPlaca.Text = "";
            txtChasis.Text = "";
            txtNoMotor.Text = "";
            ChckEstado.Checked = false;
        }


        private List<VehiculoViewModel> ModelMapperVehiculo()
        {
            var list = new List<VehiculoViewModel>();

            using (BD_Context db = new BD_Context())
            {

                foreach (var item in db.Vehiculos.ToList())
                {
                    list.Add(new VehiculoViewModel
                    {
                        Id_Vehiculo = item.Id_Vehiculo,
                        Descripción = item.Descripción,
                        No_Chasis = item.No_Chasis,
                        No_Motor = item.No_Motor,
                        No_Placa = item.No_Placa,
                        Tipo_Vehiculo = db.Tipo_Vehiculos.FirstOrDefault(x => x.Id_Tipo_Vehiculo == item.Tipo_VehiculoId).Descripcion,
                        Marca = db.Marcas.FirstOrDefault(x => x.Id_Marca == item.MarcaId).Descripcion,
                        Modelo = db.Modelos.FirstOrDefault(x => x.Id_Modelo == item.ModeloId).Descripcion,
                        Tipo_Combustible = db.Combustibles.FirstOrDefault(x => x.Id_Combustible == item.CombustibleId).Descripcion,
                        Estado = item.Estado
                    });
                }
            }

            return list;
        }

        private void ComboModelo()
        {
            LLenarCombo datos = new LLenarCombo();

            var Lst = datos.ComboModelo();
            if (Lst.Count > 0)
            {
                comboModelo.DisplayMember = "Descripcion";
                comboModelo.ValueMember = "Id_Modelo";
                comboModelo.DataSource = Lst;
            }
        }

        private void ComboMarca()
        {
            LLenarCombo datos = new LLenarCombo();

            var Lst = datos.ComboMarca();
            if (Lst.Count > 0)
            {
                comboMarca.DisplayMember = "Descripcion";
                comboMarca.ValueMember = "Id_Marca";
                comboMarca.DataSource = Lst;
            }
        }

        private void ComboTipo_Vehiculo()
        {
            LLenarCombo datos = new LLenarCombo();

            var LstTipoVehiculo = datos.tipoVehiculo();
            if (LstTipoVehiculo.Count > 0)
            {
                ComboTipoVehiculo.DisplayMember = "Descripcion";
                ComboTipoVehiculo.ValueMember = "Id_Tipo_Vehiculo";
                ComboTipoVehiculo.DataSource = LstTipoVehiculo;
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
                dataGridViewVehiculo.DataSource = ModelMapperVehiculo();
            }
        }

        private void Vehiculo_Load(object sender, EventArgs e)
        {
            Refresh();
            ComboCombustible();
            ComboTipo_Vehiculo();
            ComboMarca();
            ComboModelo();
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

        private void dataGridViewVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDescrip.Text = dataGridViewVehiculo.CurrentRow.Cells[1].Value.ToString();
            txtChasis.Text = dataGridViewVehiculo.CurrentRow.Cells[2].Value.ToString();
            txtNoMotor.Text = dataGridViewVehiculo.CurrentRow.Cells[3].Value.ToString();
            txtPlaca.Text = dataGridViewVehiculo.CurrentRow.Cells[4].Value.ToString();
            ComboTipoVehiculo.Text = dataGridViewVehiculo.CurrentRow.Cells[5].Value.ToString();
            comboMarca.Text = dataGridViewVehiculo.CurrentRow.Cells[6].Value.ToString();
            comboModelo.Text = dataGridViewVehiculo.CurrentRow.Cells[7].Value.ToString();
            comboCombustible.Text = dataGridViewVehiculo.CurrentRow.Cells[8].Value.ToString();

            if (dataGridViewVehiculo.CurrentRow.Cells[9].Value.ToString() == "INACTIVO")
            {
                ChckEstado.Checked = true;
            }
            else if (dataGridViewVehiculo.CurrentRow.Cells[9].Value.ToString() == "ACTIVO")
            {
                ChckEstado.Checked = false;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BD_Context db = new BD_Context();
            if (txtBuscar.Text != "")
            {
                dataGridViewVehiculo.CurrentCell = null;

                foreach (DataGridViewRow r in dataGridViewVehiculo.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dataGridViewVehiculo.Rows)
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
                dataGridViewVehiculo.DataSource = ModelMapperVehiculo();
            }
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtDescrip.Text == "" || txtChasis.Text == "" || txtNoMotor.Text == "" || txtPlaca.Text == "")
                {
                    MessageBox.Show("No puede haber campos vacios",
                            "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtDescrip.Text != "" || txtChasis.Text != "" || txtNoMotor.Text != "" || txtPlaca.Text != "")
                {

                    using (BD_Context db = new BD_Context())
                    {
                        Class.Vehiculo vehiculo = new Class.Vehiculo();

                        vehiculo.Descripción = txtDescrip.Text.ToString().ToUpper();
                        vehiculo.No_Chasis = txtChasis.Text.ToString().ToUpper();
                        vehiculo.No_Motor = txtNoMotor.Text.ToString().ToUpper();
                        vehiculo.No_Placa = txtPlaca.Text.ToString().ToUpper();
                        vehiculo.MarcaId = (int)comboMarca.SelectedValue;
                        vehiculo.Tipo_VehiculoId = (int)ComboTipoVehiculo.SelectedValue;
                        vehiculo.ModeloId = (int)comboModelo.SelectedValue;
                        vehiculo.CombustibleId = (int)comboCombustible.SelectedValue;

                        if (ChckEstado.Checked)
                        {
                            vehiculo.Estado = "INACTIVO";
                        }
                        else
                        {
                            vehiculo.Estado = "ACTIVO";
                        }

                        db.Vehiculos.Add(vehiculo);

                        db.SaveChanges();
                    }

                    MessageBox.Show("Vehiculo " + comboMarca.Text + " " +
                        "" + comboModelo.Text + " creado satisfactoriamente!",
                        "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if (txtDescrip.Text == "" || txtChasis.Text == "" || txtNoMotor.Text == "" || txtPlaca.Text == "")
                {
                    MessageBox.Show("No puede haber campos vacios",
                            "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtDescrip.Text != "" || txtChasis.Text != "" || txtNoMotor.Text != "" || txtPlaca.Text != "")
                {

                    using (BD_Context db = new BD_Context())
                    {
                        int id = int.Parse(dataGridViewVehiculo.CurrentRow.Cells[0].Value.ToString());

                        Class.Vehiculo vehiculo = db.Vehiculos.FirstOrDefault(x => x.Id_Vehiculo == id);

                        vehiculo.Descripción = txtDescrip.Text.ToString().ToUpper();
                        vehiculo.No_Chasis = txtChasis.Text.ToString().ToUpper();
                        vehiculo.No_Motor = txtNoMotor.Text.ToString().ToUpper();
                        vehiculo.No_Placa = txtPlaca.Text.ToString().ToUpper();
                        vehiculo.MarcaId = (int)comboMarca.SelectedValue;
                        vehiculo.Tipo_VehiculoId = (int)ComboTipoVehiculo.SelectedValue;
                        vehiculo.ModeloId = (int)comboModelo.SelectedValue;
                        vehiculo.CombustibleId = (int)comboCombustible.SelectedValue;

                        if (ChckEstado.Checked)
                        {
                            vehiculo.Estado = "INACTIVO";
                        }
                        else
                        {
                            vehiculo.Estado = "ACTIVO";
                        }

                        db.SaveChanges();

                    }
                    MessageBox.Show("Vehiculo editado Satisfactoriamente", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    int id = int.Parse(dataGridViewVehiculo.CurrentRow.Cells[0].Value.ToString());

                    Class.Vehiculo vehiculo = db.Vehiculos.FirstOrDefault(x => x.Id_Vehiculo == id);

                    db.Vehiculos.Remove(vehiculo);

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
