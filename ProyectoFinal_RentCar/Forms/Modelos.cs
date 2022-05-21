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
    public partial class Modelos : Form
    {
        public Modelos()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            using (BD_Context db = new BD_Context())
            {
                dataGridViewModelo.DataSource = db.Modelos.ToList();
            }
        }

        private void LimpiarCampos()
        {
            txtModelo.Text = "";
            ChckEstado.Checked = false;
        }

        private void Modelos_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void dataGridViewModelo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboMarca.Text = dataGridViewModelo.CurrentRow.Cells[2].Value.ToString();
            txtModelo.Text = dataGridViewModelo.CurrentRow.Cells[3].Value.ToString();
            
            if (dataGridViewModelo.CurrentRow.Cells[4].Value.ToString() == "INACTIVO")
            {
                ChckEstado.Checked = true;
            }
            else if (dataGridViewModelo.CurrentRow.Cells[4].Value.ToString() == "ACTIVO")
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
                    Class.Modelos modelos = new Class.Modelos();

                    modelos.Marca.Descripcion = comboMarca.Text.ToString();
                    modelos.Descripcion = txtModelo.Text.ToString();

                    if (ChckEstado.Checked)
                    {
                        modelos.Estado = "INACTIVO";
                    }
                    else
                    {
                        modelos.Estado = "ACTIVO";
                    }

                    db.Modelos.Add(modelos);

                    db.SaveChanges();
                }

                MessageBox.Show("Modelo "+ txtModelo.Text.ToString().ToUpper()+" creado satisfactoriamente!", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    int id = int.Parse(dataGridViewModelo.CurrentRow.Cells[0].Value.ToString());

                    Class.Modelos modelos = db.Modelos.FirstOrDefault(x => x.Id_Modelo == id);

                    modelos.Descripcion = txtModelo.Text.ToString();

                    if (ChckEstado.Checked)
                    {
                        modelos.Estado = "INACTIVO";
                    }
                    else
                    {
                        modelos.Estado = "ACTIVO";
                    }

                    db.SaveChanges();

                }
                MessageBox.Show("Modelo editado Satisfactoriamente", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    int id = int.Parse(dataGridViewModelo.CurrentRow.Cells[0].Value.ToString());

                    Class.Modelos modelos = db.Modelos.FirstOrDefault(x => x.Id_Modelo == id);

                    db.Modelos.Remove(modelos);

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
