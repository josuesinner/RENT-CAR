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

        private void Tipo_Vehiculo()
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
                dataGridViewVehiculo.DataSource = db.Vehiculos.ToList();
            }
        }

        private void Vehiculo_Load(object sender, EventArgs e)
        {
            Refresh();
            ComboCombustible();
            Tipo_Vehiculo();
            ComboMarca();
            ComboModelo();
        }
    }
}
