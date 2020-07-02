using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace artshop.lppa.equipo._3.DATA.Model
{
    public class  Artist :IdentityBase
    {

        [Required]
        [DisplayName("Nombre")]
        public string FirstName { get; set; }

        [DisplayName("Apellido")]
        [Required]
        public string LastName { get; set; }
        public string LifeSpan { get; set; }

        [DisplayName("Nacionalidad")]
        [Required]
        public string Country { get; set; }
        [DisplayName("Descripción")]
        [Required]
        public string Description { get; set; }
        [DisplayName("Total de obras")]
        public int TotalProducts { get; set; }

        [DisplayName("Nombre completo")]
        [NotMapped]
        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
        public virtual ICollection<Product> Product { get; set; }

    }

}

