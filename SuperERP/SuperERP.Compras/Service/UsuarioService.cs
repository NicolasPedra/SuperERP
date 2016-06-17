using SuperERP.Compras.DTO;
using SuperERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperERP.Compras.Service
{
   public class UsuarioService
    {
        public static void Cadastrar(UsuarioDTO usuario)
        {
            ServicoGenerico<Usuario, UsuarioDTO>.Cadastrar(usuario);

        }
        public static void Alterar(UsuarioDTO usuario)
        {
            ServicoGenerico<Usuario, UsuarioDTO>.Alterar(usuario);
        }
        public static ICollection<UsuarioDTO> Listar()
        {
            return ServicoGenerico<Usuario, UsuarioDTO>.Listar();
        }
        public static void Deletar(int IdUsuario)
        {
            ServicoGenerico<Usuario, UsuarioDTO>.Deletar(IdUsuario);
        }
        public static UsuarioDTO BuscaPorId(int IdUsuario)
        {
            return ServicoGenerico<Usuario, UsuarioDTO>.BuscaPorId(IdUsuario);
        }
    }
}
