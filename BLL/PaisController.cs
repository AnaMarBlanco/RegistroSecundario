using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistroSecundario.DAL;
using RegistroSecundario.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroSecundario.BLL
{
    public class PaisController
    {
        public static bool Guardar(Paises pais)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (pais.PaisId > 0)
                    paso = Modificar(pais);
                else
                    paso = Insertar(pais);
               
            }
            catch (Exception)
            {

                throw;
            }
            contexto.Dispose();
            return paso;
        }
        public static bool Insertar(Paises pais)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Paises.Add(pais);

                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            contexto.Dispose();
            return paso;
        }

        public static bool Modificar(Paises pais)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(pais).State =EntityState.Modified;

                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            contexto.Dispose();
            return paso;
        }

        public static Paises Buscar(int PaisId)
        {
            Paises pais = new Paises();
            Contexto contexto = new Contexto();
            try
            {
                pais= contexto.Paises.Find(PaisId);
            }
            catch (Exception)
            {

                throw;
            }
            contexto.Dispose();
            return pais;
        }

        public static bool Eliminar(int PaisId)
        {
            bool paso = false;
            Paises pais = new Paises();
            Contexto contexto = new Contexto();
            try
            {
                var busqueda= contexto.Paises.Find(PaisId);
                if (pais!=null)
                {
                    contexto.Paises.Remove(busqueda);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            contexto.Dispose();
            return paso;
        }
    }
}
