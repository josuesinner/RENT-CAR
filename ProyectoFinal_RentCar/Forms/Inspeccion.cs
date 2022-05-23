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
            comboCombustible.Items.Add("1/4");
            comboCombustible.Items.Add("1/2");
            comboCombustible.Items.Add("3/4");
            comboCombustible.Items.Add("FULL");

        }

        private List<InspeccionViewModel> ModelMapperInspeccion()
        {
            var list = new List<InspeccionViewModel>();

            using (BD_Context db = new BD_Context())
            {

                foreach (var item in db.Inspeccions.ToList())
                {
                    list.Add(new InspeccionViewModel
                    {
                        Vehículo = db.Vehiculos.FirstOrDefault(x => x.Id_Vehiculo == item.VehículoId).Descripción,
                        Cedula = db.Clientes.FirstOrDefault(x => x.Id_Cliente == item.ClienteId).Cedula,
                        Cliente = db.Clientes.FirstOrDefault(x => x.Id_Cliente == item.ClienteId).Nombre,
                        Tiene_Ralladuras = item.Tiene_Ralladuras,
                        Cantidad_Combustible = item.Cantidad_Combustible,
                        Goma_respuesta = item.Goma_respuesta,
                        Tiene_Gato = item.Tiene_Gato,
                        roturas_cristal = item.roturas_cristal,
                        Estado_gomas = item.Estado_gomas,
                        Etc = item.Etc,
                        Fecha = item.Fecha,
                        Empleado = db.Empleados.FirstOrDefault(x => x.Id_Empleado == item.EmpleadoId).Nombre,
                        Estado = item.Estado
                    });
                }
            }

            return list;
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
                comboCombustible.DisplayMember = "Descripcion";
                comboCombustible.ValueMember = "Id_Combustible";
                comboCombustible.DataSource = LstComb;
            }
        }

        private void Refresh()
        {
            using (BD_Context db = new BD_Context())
            {
                dataGridViewInspeccion.DataSource = ModelMapperInspeccion();
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
            //ComboCombustible();
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

                    inspeccion.VehículoId = (int)comboVehiculo.SelectedValue;
                    inspeccion.ClienteId = (int)comboCliente.SelectedValue;
                    inspeccion.EmpleadoId = (int)comboEmpleado.SelectedValue;
                    inspeccion.Cantidad_Combustible = comboCombustible.Text.ToString();

                    inspeccion.Fecha = DateTime.Parse(dateTimePicker1.Text.ToString());

                    if (ChckEstado.Checked)
                    {
                        inspeccion.Estado = "INACTIVO";
                    }
                    else
                    {
                        inspeccion.Estado = "ACTIVO";
                    }

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
                    else
                    {
                        inspeccion.Estado_gomas = "Una o varias gomas presentan fallas";

                    }
                    //else if(checkIzFrontal.Checked = false && checkDereFrontal.Checked && checkIzTrasera.Checked && checkDerTrasera.Checked)
                    //{
                    //    inspeccion.Estado_gomas = "Goma Frontal Izquierda con desgaste";
                    //}
                    //else if (checkDereFrontal.Checked = false && checkIzFrontal.Checked && checkIzTrasera.Checked && checkDerTrasera.Checked)
                    //{
                    //    inspeccion.Estado_gomas = "Goma Frontal Derecha con desgaste";
                    //}
                    //else if (checkIzTrasera.Checked = false && checkIzFrontal.Checked && checkDereFrontal.Checked && checkDerTrasera.Checked)
                    //{
                    //    inspeccion.Estado_gomas = "Goma Trasera Izquierda con desgaste";
                    //}
                    //else if (checkDerTrasera.Checked = false && checkIzFrontal.Checked && checkDereFrontal.Checked && checkIzTrasera.Checked)
                    //{
                    //    inspeccion.Estado_gomas = "Goma Trasera Derecha con desgaste";
                    //}

                    //if (checkIzFrontal.Checked && checkDereFrontal.Checked == false)
                    //{
                    //    inspeccion.Estado_gomas = "Gomas Frontales con desgaste";
                    //}
                    //else if (checkDerTrasera.Checked && checkIzTrasera.Checked == false)
                    //{
                    //    inspeccion.Estado_gomas = "Gomas Traseras con desgaste";
                    //}

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
