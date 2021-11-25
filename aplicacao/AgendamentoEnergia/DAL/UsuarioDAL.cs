using AgendamentoEnergia.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AgendamentoEnergia.DAL
{
    public class UsuarioDAL
    {
        EFContext context = new EFContext();

        public void GravarUsuario(Usuario usuario)
        {
            if (usuario.UsuarioID == 0)
                context.Usuarios.Add(usuario);
            else
                context.Entry(usuario).State = EntityState.Modified;

            context.SaveChanges();
        }
    }
}