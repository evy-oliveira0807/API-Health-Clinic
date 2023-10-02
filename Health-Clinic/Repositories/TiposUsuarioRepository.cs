﻿using Health_Clinic.Contexts;
using Health_Clinic.Domains;
using Health_Clinic.Interfaces;

namespace Health_Clinic.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {

        
        private readonly ClinicContext ctx;
        
        public TiposUsuarioRepository()
        {
            ctx = new ClinicContext();
        }

        public void Cadastrar(TiposUsuario tiposUsuario)
        {
            try
            {
                tiposUsuario.IdTiposUsuario = Guid.NewGuid();

                ctx.TiposUsuario.Add(tiposUsuario);

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            TiposUsuario TipousuarioBuscado = ctx.TiposUsuario.Find(id);

            ctx.TiposUsuario.Remove(TipousuarioBuscado);

            ctx.SaveChanges();
        }

        public List<TiposUsuario> Listar()
        {
            try
            {
                return ctx.TiposUsuario.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

       
         
    }
}

