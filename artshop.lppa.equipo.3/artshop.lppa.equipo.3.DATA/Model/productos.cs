using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artshop.lppa.equipo._3.DATA.Model
{
    public class productos: Identity
    {
        public string nombre { get; set; }

        public tipoAutor autor { get; set; }
    }
}
