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
    public partial class Combustibles : Form
    {
        public Combustibles()
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
                dataGridViewCombustible.DataSource = db.Combustibles.ToList();
            }
        }

        private void LimpiarCampos()
        {
            txtCombustible.Text = "";
            ChckEstado.Checked = false;
        }

        private void dataGridViewCombustible_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCombustible.Text = dataGridViewCombustible.CurrentRow.Cells[1].Value.ToString();

            if (dataGridViewCombustible.CurrentRow.Cells[2].Value.ToString() == "INACTIVO")
            {
                ChckEstado.Checked = true;
            }
            else if (dataGridViewCombustible.CurrentRow.Cells[2].Value.ToString() == "ACTIVO")
            {
                ChckEstado.Checked = false;
            }
        }

        private void Combustibles_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCombustible.Text == "" )
                {
                    MessageBox.Show("No puede haber campos vacios",
                            "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtCombustible.Text != "" )
                {

                    using (BD_Context db = new BD_Context())
                    {
                        Combustible combustible = new Combustible();

                        combustible.Descripcion = txtCombustible.Text.ToString().ToUpper();

                        if (ChckEstado.Checked)
                        {
                            combustible.Estado = "INACTIVO";
                        }
                        else
                        {
                            combustible.Estado = "ACTIVO";
                        }

                        db.Combustibles.Add(combustible);

                        db.SaveChanges();
                    }

                    MessageBox.Show("El Combustible " + txtCombustible.Text.ToString().ToUpper() + " fue creado satisfactoriamente!", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    int id = int.Parse(dataGridViewCombustible.CurrentRow.Cells[0].Value.ToString());

                    Class.Combustible combustible = db.Combustibles.FirstOrDefault(x => x.Id_Combustible == id);

                    combustible.Descripcion = txtCombustible.Text.ToString().ToUpper();

                    if (ChckEstado.Checked)
                    {
                        combustible.Estado = "INACTIVO";
                    }
                    else
                    {
                        combustible.Estado = "ACTIVO";
                    }

                    db.SaveChanges();

                }
                MessageBox.Show("Combustible editado Satisfactoriamente", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    int id = int.Parse(dataGridViewCombustible.CurrentRow.Cells[0].Value.ToString());

                    Class.Combustible combustible = db.Combustibles.FirstOrDefault(x => x.Id_Combustible == id);

                    db.Combustibles.Remove(combustible);

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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BD_Context db = new BD_Context();
            if (txtBuscar.Text != "")
            {
                dataGridViewCombustible.CurrentCell = null;

                foreach (DataGridViewRow r in dataGridViewCombustible.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dataGridViewCombustible.Rows)
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
                dataGridViewCombustible.DataSource = db.Combustibles.ToList();
            }
        }

        ErrorProvider errorP = new ErrorProvider();

        private void txtCombustible_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = soloLetras(e);
            if (!validar)
                errorP.SetError(txtCombustible, "Solo Letras");
            else
                errorP.Clear();
        }
    }
}
