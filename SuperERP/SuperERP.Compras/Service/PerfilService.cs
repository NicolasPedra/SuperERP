using SuperERP.Compras.DTO;
using SuperERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperERP.Compras.Service
{
    public class PerfilService
    {
        public static void Cadastrar(PerfilDTO perfil)
        {
            ServicoGenerico<Perfil, PerfilDTO>.Cadastrar(perfil);
        }
        public static void Alterar(PerfilDTO perfil)
        {
            ServicoGenerico<Perfil, PerfilDTO>.Alterar(perfil);
        }
        public static ICollection<PerfilDTO> Listar()
        {
            return ServicoGenerico<Perfil, PerfilDTO>.Listar();
        }
        public static void Deletar(int IdPerfil)
        {
            ServicoGenerico<Perfil, PerfilDTO>.Deletar(IdPerfil);
        }
        public static PerfilDTO BuscaPorId(int IdPerfil)
        {
            return ServicoGenerico<Perfil, PerfilDTO>.BuscaPorId(IdPerfil);
        }
    }
}
