using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_RentCar.Class
{
    public class LLenarCombo
    {
        public List<Marcas> ComboMarca()
        {
            using (BD_Context db = new BD_Context())
            {
                return db.Marcas.ToList();
            }
        }

        public List<Modelos> ComboModelo(/*int pId*/)
        {
            using (BD_Context db = new BD_Context())
            {
                //return db.Modelos.Where(m=>m.MarcaId==pId).ToList();
                return db.Modelos.ToList();

            }
        }

        public List<Vehiculo> ComboVehiculo()
        {
            using (BD_Context db = new BD_Context())
            {
                return db.Vehiculos.ToList();
            }
        }

        public List<Cliente> ComboCliente()
        {
            using (BD_Context db = new BD_Context())
            {
                return db.Clientes.ToList();
            }
        }

        public List<Empleado> ComboEmpleado()
        {
            using (BD_Context db = new BD_Context())
            {
                return db.Empleados.ToList();
            }
        }

        public List<Combustible> ComboCombustible()
        {
            using (BD_Context db = new BD_Context())
            {
                return db.Combustibles.ToList();
            }
        }

        public List<Tipo_Vehiculo> tipoVehiculo()
        {
            using (BD_Context db = new BD_Context())
            {
                return db.Tipo_Vehiculos.ToList();
            }
        }
    }
}
