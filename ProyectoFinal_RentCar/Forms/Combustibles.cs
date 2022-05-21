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

            if (dataGridViewCombustible.CurrentRow.Cells[4].Value.ToString() == "INACTIVO")
            {
                ChckEstado.Checked = true;
            }
            else if (dataGridViewCombustible.CurrentRow.Cells[4].Value.ToString() == "ACTIVO")
            {
                ChckEstado.Checked = false;
            }
        }

        private void Combustibles_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
