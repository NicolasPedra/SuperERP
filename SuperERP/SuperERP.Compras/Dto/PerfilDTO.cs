using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperERP.Compras.DTO
{
    public class PerfilDTO
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<UsuarioDTO> Usuarios { get; set; }
        public virtual ICollection<FuncionalidadeDTO> Funcionalidades { get; set; }
    }
}
