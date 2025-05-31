using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadParcial2pcg
{
    public class Parcial2PcgContext : DbContext
    {
        public Parcial2PcgContext()
            : base("Server=.;Database=Parcial2pcg; User Id=usrparcial2pcg; Password=12345678;") { }

        public DbSet<Serie> Series { get; set; }
    }
}
