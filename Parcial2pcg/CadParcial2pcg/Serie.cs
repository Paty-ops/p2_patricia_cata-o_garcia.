using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadParcial2pcg
{
    public class Serie
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string Director { get; set; }
        public int Episodios { get; set; }
        public DateTime FechaEstreno { get; set; }
        public string UrlPortada { get; set; }
        public string IdiomaOriginal { get; set; }
        public short Estado { get; set; }
    }
}
