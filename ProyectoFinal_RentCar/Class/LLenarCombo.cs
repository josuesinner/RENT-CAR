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

        public List<Modelos> ComboModelo(int pId)
        {
            using (BD_Context db = new BD_Context())
            {
                return db.Modelos.Where(m=>m.MarcaId==pId).ToList();
            }
        }
    }
}
