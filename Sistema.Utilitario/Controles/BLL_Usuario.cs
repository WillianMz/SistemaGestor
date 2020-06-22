using DAO;
using Modelo.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Utilitario.Controles
{
    public class BLL_Usuario
    {
        DAO_Usuario dao;

        public List<Usuario> listarUsuarios(bool ativo)
        {
            dao = new DAO_Usuario();
            List<Usuario> usuarios = dao.getAll(ativo);
            return usuarios;
        }

        public bool verificarUsuario(string login, string senha)
        {
            dao = new DAO_Usuario();
            List<Usuario> u = dao.getUsuario(login, senha, true);

            if (u.Count == 1)
                return true;
            else
                return false;
        }

        public Usuario userID(int id)
        {
            dao = new DAO_Usuario();
            Usuario usuario = dao.getUsuario_ID(id, true);
            return usuario;
        }

        public int usuario(string login, string senha)
        {
            dao = new DAO_Usuario();
            Usuario usuario = dao.getDetalhes(login, senha);
            return usuario.Id;
        }
    }
}
