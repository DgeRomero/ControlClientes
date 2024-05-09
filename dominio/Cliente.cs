using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Articulos { get; set; }
        public decimal Precio { get; set; }
        public bool Pagado { get; set; }
    }
}
