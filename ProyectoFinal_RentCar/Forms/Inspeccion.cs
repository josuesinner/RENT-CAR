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
    public partial class Inspeccion : Form
    {
        public Inspeccion()
        {
            InitializeComponent();
        }

        private void ComboVehiculo()
        {
            LLenarCombo datos = new LLenarCombo();

            var LstVehi = datos.ComboVehiculo();
            if (LstVehi.Count > 0)
            {
                comboVehiculo.DisplayMember = "Descripción";
                comboVehiculo.ValueMember = "Id_Vehiculo";
                comboVehiculo.DataSource = LstVehi;
            }
        }

        private void ComboCliente()
        {
            LLenarCombo datos = new LLenarCombo();

            var LstCli = datos.ComboCliente();
            if (LstCli.Count > 0)
            {
                comboCliente.DisplayMember = "Nombre";
                comboCliente.ValueMember = "Id_Cliente";
                comboCliente.DataSource = LstCli;
            }
        }

        private void ComboEmpleado()
        {
            LLenarCombo datos = new LLenarCombo();

            var LstEmp = datos.ComboEmpleado();
            if (LstEmp.Count > 0)
            {
                comboEmpleado.DisplayMember = "Nombre";
                comboEmpleado.ValueMember = "Id_Empleado";
                comboEmpleado.DataSource = LstEmp;
            }
        }

        private void ComboCombustible()
        {
            LLenarCombo datos = new LLenarCombo();

            var LstComb = datos.ComboCombustible();
            if (LstComb.Count > 0)
            {
                comboEmpleado.DisplayMember = "Descripcion";
                comboEmpleado.ValueMember = "Id_Combustible";
                comboEmpleado.DataSource = LstComb;
            }
        }

        private void Refresh()
        {
            using (BD_Context db = new BD_Context())
            {
                dataGridViewInspeccion.DataSource = db.Inspeccions.ToList();
            }
        }

        private void LimpiarCampos()
        {
            checkRalladuras.Checked = false;
            checkRepuesta.Checked = false;
            checkGato.Checked = false;
            checkCristal.Checked = false;
            checkIzFrontal.Checked = false;
            checkDereFrontal.Checked = false;
            checkDerTrasera.Checked = false;
            checkIzTrasera.Checked = false;
            ChckEstado.Checked = false;
        }

        private void Inspeccion_Load(object sender, EventArgs e)
        {
            Refresh();
            ComboVehiculo();
            ComboCliente();
            ComboEmpleado();
            ComboCombustible();
        }

        private void dataGridViewInspeccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                using (BD_Context db = new BD_Context())
                {
                    Class.Inspeccion inspeccion = new Class.Inspeccion();

                    //modelos.MarcaId = (int)comboMarca.SelectedValue;
                    //modelos.Descripcion = txtModelo.Text.ToString().ToUpper();

                    if (checkRalladuras.Checked)
                    {
                        inspeccion.Tiene_Ralladuras = "SI";
                    }
                    else
                    {
                        inspeccion.Tiene_Ralladuras = "NO";
                    }

                    if (checkRepuesta.Checked)
                    {
                        inspeccion.Goma_respuesta = "SI";
                    }
                    else
                    {
                        inspeccion.Goma_respuesta = "NO";
                    }

                    if (checkGato.Checked)
                    {
                        inspeccion.Tiene_Gato = "SI";
                    }
                    else
                    {
                        inspeccion.Tiene_Gato = "NO";
                    }

                    if (checkCristal.Checked)
                    {
                        inspeccion.roturas_cristal = "SI";
                    }
                    else
                    {
                        inspeccion.roturas_cristal = "NO";
                    }

                    if (checkIzFrontal.Checked && checkDereFrontal.Checked && checkIzTrasera.Checked && checkDerTrasera.Checked)
                    {
                        inspeccion.Estado_gomas = "Las 4 gomas estan bien";
                    }
                    else if(checkIzFrontal.Checked = false && checkDereFrontal.Checked && checkIzTrasera.Checked && checkDerTrasera.Checked)
                    {
                        inspeccion.Estado_gomas = "Goma Frontal Izquierda con desgaste";
                    }
                    else if (checkDereFrontal.Checked = false && checkIzFrontal.Checked && checkIzTrasera.Checked && checkDerTrasera.Checked)
                    {
                        inspeccion.Estado_gomas = "Goma Frontal Derecha con desgaste";
                    }
                    else if (checkIzTrasera.Checked = false && checkIzFrontal.Checked && checkDereFrontal.Checked && checkDerTrasera.Checked)
                    {
                        inspeccion.Estado_gomas = "Goma Trasera Izquierda con desgaste";
                    }
                    else if (checkDerTrasera.Checked = false && checkIzFrontal.Checked && checkDereFrontal.Checked && checkIzTrasera.Checked)
                    {
                        inspeccion.Estado_gomas = "Goma Trasera Derecha con desgaste";
                    }

                    if (checkIzFrontal.Checked && checkDereFrontal.Checked == false)
                    {
                        inspeccion.Estado_gomas = "Gomas Frontales con desgaste";
                    }
                    else if (checkDerTrasera.Checked && checkIzTrasera.Checked == false)
                    {
                        inspeccion.Estado_gomas = "Gomas Traseras con desgaste";
                    }

                    db.Inspeccions.Add(inspeccion);

                    db.SaveChanges();
                }

                MessageBox.Show("Inspeccion del " + comboVehiculo.Text.ToString() + " para el Cliente " + comboCliente.Text.ToString() + " creado satisfactoriamente!", "RENT-CAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
