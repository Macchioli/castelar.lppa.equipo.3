using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artshop.lppa.equipo._3.DATA.Model
{
    public class productos: IdentityBase
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public tipoAutor autor { get; set; }
    }
}
