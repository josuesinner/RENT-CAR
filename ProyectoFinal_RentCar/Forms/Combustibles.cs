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
    }
}
