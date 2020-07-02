using artshop.lppa.equipo._3.DATA.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artshop.lppa.equipo._3.DATA.Services
{
    public partial class ArtDBContext :DbContext
    {

        public ArtDBContext() : base("name=DefaultConnection")
        {
            Database.SetInitializer<ArtDBContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        /// DbSet Artist se utiliza para representar una tabla.
        public virtual DbSet<Artist> Artist { get; set; }

        /// DbSet Product se utiliza para representar una tabla.
        public virtual DbSet<Product> Product { get; set; }
        /// DbSet Product se utiliza para representar una tabla.
        public virtual DbSet<Error> Error { get; set; }

    }
}
