using CadParcial2pcg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnParcial2pcg
{
    public class SerieService
    {
        private readonly Parcial2PcgContext _context;

        public SerieService()
        {
            _context = new Parcial2PcgContext();
        }

        public List<Serie> ObtenerSeries()
        {
            return _context.Series.Where(s => s.Estado == 1).ToList();
        }

        public void AgregarSerie(Serie s)
        {
            s.Estado = 1;
            _context.Series.Add(s);
            _context.SaveChanges();
        }

        public void ActualizarSerie(Serie s)
        {
            var serieExistente = _context.Series.Find(s.Id);
            if (serieExistente != null)
            {
                serieExistente.Titulo = s.Titulo;
                serieExistente.Sinopsis = s.Sinopsis;
                serieExistente.Director = s.Director;
                serieExistente.Episodios = s.Episodios;
                serieExistente.FechaEstreno = s.FechaEstreno;
                _context.SaveChanges();
            }
        }

        public void EliminarSerieLogicamente(int id)
        {
            var serie = _context.Series.Find(id);
            if (serie != null)
            {
                serie.Estado = 0;
                _context.SaveChanges();
            }
        }
    }
}
    }
}
