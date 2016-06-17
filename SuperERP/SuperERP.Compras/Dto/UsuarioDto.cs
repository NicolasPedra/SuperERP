using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperERP.Compras.DTO
{
    public class UsuarioDTO
    {
        public int ID { get; set; }
        public int ID_Perfil { get; set; }
        public int ID_Empresa { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public  EmpresaDTO Empresa { get; set; }
        public  PerfilDTO Perfil { get; set; }

    }
}
