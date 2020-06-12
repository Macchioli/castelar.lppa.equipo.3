using artshop.lppa.equipo._3.DATA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artshop.lppa.equipo._3.DATA.Services
{
    public interface IProductosData
    {
        IEnumerable<productos> GetAll();
    }
}
