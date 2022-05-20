using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProyectoFinal_RentCar.Class
{
   public class BD_Context : DbContext
    {
        public BD_Context() : base("connectionstr")
        {

        }

        public  DbSet<Cliente> Clientes { set; get; }
        public  DbSet<Combustible> Combustibles { set; get; }
        public  DbSet<Empleado> Empleados { set; get; }
        public  DbSet<Inspeccion> Inspeccions { set; get; }
        public  DbSet<Marcas> Marcas { set; get; }
        public  DbSet<Modelos> Modelos { set; get; }
        public  DbSet<Renta_Devolucion> Renta_Devolucions { set; get; }
        public  DbSet<Tipo_Vehiculo> Tipo_Vehiculos { set; get; }
        public  DbSet<Vehiculo> Vehiculos { set; get; }
    }
}
