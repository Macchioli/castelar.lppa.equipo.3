using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using artshop.lppa.equipo._3.DATA.Model;

namespace artshop.lppa.equipo._3.DATA.Services
{
    public class InMemoryProductosData : IProductosData
    {

        readonly List<productos> productos;  

        public InMemoryProductosData()
        {
            productos = new List<productos>()
            {
                new productos(){id = 1, autor=tipoAutor.Klimt, nombre="El Beso"},
                new productos(){id = 2, autor=tipoAutor.Picasso, nombre="Guernica"},
                new productos(){id = 3, autor=tipoAutor.Rembrandt, nombre="La ronda de noche"}
            };
        }

        IEnumerable<productos> IProductosData.GetAll()
        {
            return productos.OrderBy(o=> o.nombre);
        }
    }
}
