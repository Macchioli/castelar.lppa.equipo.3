using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using artshop.lppa.equipo._3.DATA.Model;

namespace artshop.lppa.equipo._3.DATA.Services
{
    public class InMemoryProductosData : BaseDataService<productos>
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

        public override List<productos> Get(Expression<Func<productos, bool>> whereExpression = null, Func<IQueryable<productos>, IOrderedQueryable<productos>> orderFunction = null, string includeEntities = "")
        {
            return productos.OrderBy(o => o.nombre).ToList();
        }
    
    }
}
