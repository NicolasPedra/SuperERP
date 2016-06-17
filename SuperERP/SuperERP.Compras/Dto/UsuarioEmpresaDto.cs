using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperERP.Compras.DTO
{
    public class UsuarioEmpresaDTO
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
    }
}
