using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_RentCar.Class
{
    public class VehiculoViewModel
    {
        [Key]
        public int Id_Vehiculo { get; set; }
        public string Descripción { get; set; }
        public string No_Chasis { get; set; }
        public string No_Motor { get; set; }
        public string No_Placa { get; set; }
        public string Tipo_Vehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tipo_Combustible { get; set; }
        public string Estado { get; set; }
    }
}
