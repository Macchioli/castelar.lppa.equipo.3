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
    public class Product : IdentityBase
    {
        [Required]
        [DisplayName("Título")]
        public string Title { get; set; }
        [Required]
        [DisplayName("Descripción")]
        public string Description { get; set; }
        public int ArtistId { get; set; }
        public string Image = "Imagen";
        [Required]
        [DisplayName("Precio")]
        public double Price { get; set; }
        public int QuantitySold { get; set; }
        public double AvgStars { get; set; }

        public virtual Artist Artist { get; set; }


    }
}