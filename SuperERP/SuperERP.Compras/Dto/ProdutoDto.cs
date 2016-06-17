using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperERP.Vendas.DTO;

namespace SuperERP.Compras.DTO
{
    public class ProdutoDTO
    {
        public int ID { get; set; }
        public int IDEmpresa { get; set; }
        public int IDCategoria { get; set; }
        public Nullable<int> IDCliente { get; set; }
        public Nullable<int> IDNcm { get; set; }
        public Nullable<int> IDUnidadeMedida { get; set; }
        public double ICMS { get; set; }
        public double IPI { get; set; }
        public double IVA { get; set; }
        public double ST { get; set; }
        public double PIS { get; set; }
        public double COFINS { get; set; }
        public string Nome { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoBarras { get; set; }
        public double ValorVenda { get; set; }
        public int Estoque { get; set; }
        public int EstoqueMax { get; set; }
        public int EstoqueMin { get; set; }
        public Nullable<double> PesoLiquido { get; set; }
        public Nullable<double> PesoBruto { get; set; }
        public string ean { get; set; }
        public virtual CategoriaDTO Categoria { get; set; }
        public virtual ClienteFornecedorDTO ClienteFornecedor { get; set; }
        public virtual ICollection<CompraAtivosDTO> CompraAtivos { get; set; }
        public virtual EmpresaDTO Empresa { get; set; }
        public virtual NcmDTO Ncm { get; set; }
        public virtual UnidadeMedidaDTO UnidadeMedida { get; set; }
        public virtual ICollection<ProdutoFornecedorDTO> ProdutoFornecedors { get; set; }
    }
}
