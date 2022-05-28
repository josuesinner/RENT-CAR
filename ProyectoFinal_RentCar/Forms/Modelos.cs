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

        private void ComboMarca()
        {
            LLenarCombo datos = new LLenarCombo();

            var Lst = datos.ComboMarca();
            if (Lst.Count>0)
            {
                comboMarca.DisplayMember = "Descripcion";
                comboMarca.ValueMember = "Id_Marca";
                comboMarca.DataSource = Lst;
            }
        }

        private void Refresh()
        {
            using (BD_Context db = new BD_Context())
            {
                dataGridViewModelo.DataSource = ModelMapper();
            }
        }

        private List<ModeloVieModel> ModelMapper()
        {
            var list = new List<ModeloVieModel>();

            using (BD_Context db = new BD_Context())
            {

                foreach (var item in db.Modelos.ToList())
                {
                    list.Add(new ModeloVieModel
                    {
                        Id_Modelo = item.Id_Modelo,
                        Marca = db.Marcas.FirstOrDefault(x => x.Id_Marca == item.MarcaId).Descripcion,
                        Descripcion = item.Descripcion,
                        Estado = item.Estado
                    });
                }
            }
            
            return list;
        }

        private void LimpiarCampos()
        {
            txtModelo.Text = "";
            ChckEstado.Checked = false;
        }

        private void Modelos_Load(object sender, EventArgs e)
        {
            Refresh();
            ComboMarca();
        }

        private void dataGridViewModelo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboMarca.Text = dataGridViewModelo.CurrentRow.Cells[1].Value.ToString();
            txtModelo.Text = dataGridViewModelo.CurrentRow.Cells[2].Value.ToString();
            
            if (dataGridViewModelo.CurrentRow.Cells[3].Value.ToString() == "INACTIVO")
            {
                ChckEstado.Checked = true;
            }
            else if (dataGridViewModelo.CurrentRow.Cells[3].Value.ToString() == "ACTIVO")
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

            db.Modelos.ToList();


            if (txtBuscar.Text != "")
            {
                dataGridViewModelo.CurrentCell = null;

                foreach (DataGridViewRow r in dataGridViewModelo.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dataGridViewModelo.Rows)
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
                dataGridViewModelo.DataSource = ModelMapper();
            }
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtModelo.Text == "")
                {
                    MessageBox.Show("No puede haber campos vacios",
                            "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtModelo.Text != "")
                {

                    using (BD_Context db = new BD_Context())
                    {
                        Class.Modelos modelos = new Class.Modelos();

                        if (comboMarca.Text == "")
                        {
                            MessageBox.Show("Debe seleccionar una Marca ", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else if (comboMarca.Text != "")
                        {
                            modelos.MarcaId = (int)comboMarca.SelectedValue;
                            modelos.Descripcion = txtModelo.Text.ToString().ToUpper();

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

                            MessageBox.Show("Modelo " + txtModelo.Text.ToString().ToUpper() + " creado satisfactoriamente!", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtModelo.Text == "")
                {
                    MessageBox.Show("No puede haber campos vacios",
                            "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtModelo.Text != "")
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
