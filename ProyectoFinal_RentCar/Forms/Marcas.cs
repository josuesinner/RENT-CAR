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
using ProyectoFinal_RentCar.Class;


namespace ProyectoFinal_RentCar.Forms
{
    public partial class Marcas : Form
    {
        public Marcas()
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
                dataGridViewMarcas.DataSource = db.Marcas.ToList();
            }
        }

        private void LimpiarCampos()
        {
            txtMarca.Text = "";
            ChckEstado.Checked = false;
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void dataGridViewMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMarca.Text = dataGridViewMarcas.CurrentRow.Cells[1].Value.ToString();
            
            if (dataGridViewMarcas.CurrentRow.Cells[2].Value.ToString() == "INACTIVO")
            {
                ChckEstado.Checked = true;
            }
            else if (dataGridViewMarcas.CurrentRow.Cells[2].Value.ToString() == "ACTIVO")
            {
                ChckEstado.Checked = false;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMarca.Text == "")
                {
                    MessageBox.Show("No puede haber campos vacios",
                            "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtMarca.Text != "")
                {

                    using (BD_Context db = new BD_Context())
                    {
                        Class.Marcas marcas = new Class.Marcas();

                        marcas.Descripcion = txtMarca.Text.ToString().ToUpper();

                        if (ChckEstado.Checked)
                        {
                            marcas.Estado = "INACTIVO";
                        }
                        else
                        {
                            marcas.Estado = "ACTIVO";
                        }

                        db.Marcas.Add(marcas);

                        db.SaveChanges();
                    }

                    MessageBox.Show("Marca " + txtMarca.Text.ToString().ToUpper() + " creada satisfactoriamente!", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if (txtMarca.Text == "")
                {
                    MessageBox.Show("No puede haber campos vacios",
                            "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtMarca.Text != "")
                {

                    using (BD_Context db = new BD_Context())
                    {
                        int id = int.Parse(dataGridViewMarcas.CurrentRow.Cells[0].Value.ToString());

                        Class.Marcas marcas = db.Marcas.FirstOrDefault(x => x.Id_Marca == id);

                        marcas.Descripcion = txtMarca.Text.ToString();

                        if (ChckEstado.Checked)
                        {
                            marcas.Estado = "INACTIVO";
                        }
                        else
                        {
                            marcas.Estado = "ACTIVO";
                        }

                        db.SaveChanges();

                    }
                    MessageBox.Show("Marca editada Satisfactoriamente", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh();
                    LimpiarCampos();
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
                    int id = int.Parse(dataGridViewMarcas.CurrentRow.Cells[0].Value.ToString());

                    Class.Marcas marcas = db.Marcas.FirstOrDefault(x => x.Id_Marca == id);

                    db.Marcas.Remove(marcas);

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

        ErrorProvider errorP = new ErrorProvider();

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = soloLetras(e);
            if (!validar)
                errorP.SetError(txtMarca, "Solo Letras");
            else
                errorP.Clear();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BD_Context db = new BD_Context();
            if (txtBuscar.Text != "")
            {
                dataGridViewMarcas.CurrentCell = null;

                foreach (DataGridViewRow r in dataGridViewMarcas.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dataGridViewMarcas.Rows)
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
                dataGridViewMarcas.DataSource = db.Marcas.ToList();
            }
        }
    }
}
