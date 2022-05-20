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
            txtModelo.Text = dataGridViewModelo.CurrentRow.Cells[1].Value.ToString();
            
            if (dataGridViewModelo.CurrentRow.Cells[4].Value.ToString() == "INACTIVO")
            {
                ChckEstado.Checked = true;
            }
            else if (dataGridViewModelo.CurrentRow.Cells[4].Value.ToString() == "ACTIVO")
            {
                ChckEstado.Checked = false;
            }
        }
    }
}
