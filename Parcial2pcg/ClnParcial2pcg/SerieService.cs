﻿using CadParcial2pcg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnParcial2pcg
{
    public class SerieService
    {
        public static int insertar(Serie serie)
        {
            using (var context = new Parcial2pcgEntities())
            {
                context.Serie.Add(serie);
                context.SaveChanges();
                return serie.id;
            }
        }

        public static int actualizar(Serie serie)
        {
            using (var context = new Parcial2pcgEntities())
            {
                var existente = context.Serie.Find(serie.id);
                existente.titulo = serie.titulo;
                existente.sinopsis = serie.sinopsis;
                existente.director = serie.director;
                existente.episodios = serie.episodios;
                existente.fechaEstreno = serie.fechaEstreno;
                existente.estado = serie.estado;
                existente.urlPortada = serie.urlPortada;
                existente.idiomaOriginal = serie.idiomaOriginal;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuario)
        {
            using (var context = new Parcial2pcgEntities())
            {
                var serie = context.Serie.Find(id);
                serie.estado = -1;
                return context.SaveChanges();
            }
        }

        public static Serie obtenerUno(int id)
        {
            using (var context = new Parcial2pcgEntities())
            {
                return context.Serie.Find(id);
            }
        }

        public static List<Serie> listar()
        {
            using (var context = new Parcial2pcgEntities())
            {
                return context.Serie.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paSerieListar_Result> listarPa(string parametro)
        {
            using (var context = new Parcial2pcgEntities())
            {
                return context.paSerieListar(parametro).ToList();
            }
        }
    }
}