using SuperERP.Models;
using SuperERP.Vendas.DTO;

namespace SuperERP.Vendas.Config
{
    public static class AutoMapperConfig
    {
        public static void Inicializar() {
            ConverteDTOParaModel();
            ConverteModelParaDTO();
        }

        public static void ConverteDTOParaModel()
        {
            AutoMapper.Mapper.CreateMap<PessoaFisicaDTO, PessoaFisica>();
            AutoMapper.Mapper.CreateMap<PessoaJuridicaDTO, PessoaJuridica>();
            AutoMapper.Mapper.CreateMap<ParcelamentoDTO, Parcelamento>();
            AutoMapper.Mapper.CreateMap<ProdutoEstoqueDTO, Produto>();
            AutoMapper.Mapper.CreateMap<VendaDTO, Venda>();
            AutoMapper.Mapper.CreateMap<VendaAtivosDTO, Venda_Ativos>();
            AutoMapper.Mapper.CreateMap<VendaAtivosEstoqueDTO, Venda_Ativos>();
            AutoMapper.Mapper.CreateMap<CompraAtivosEstoqueDTO, Compra_Ativos>();
            AutoMapper.Mapper.CreateMap<CategoriaDTO, Categoria>();
            AutoMapper.Mapper.CreateMap<EmpresaDTO, Empresa>();
        }




        public static void ConverteModelParaDTO()
        {
            AutoMapper.Mapper.CreateMap<PessoaFisica, PessoaFisicaDTO>();
            AutoMapper.Mapper.CreateMap<PessoaJuridica, PessoaJuridicaDTO>();
            AutoMapper.Mapper.CreateMap<Parcelamento, ParcelamentoDTO>();
            AutoMapper.Mapper.CreateMap<Produto, ProdutoEstoqueDTO>();
            AutoMapper.Mapper.CreateMap<Venda, VendaDTO>();
            AutoMapper.Mapper.CreateMap<Venda_Ativos, VendaAtivosDTO>();
            AutoMapper.Mapper.CreateMap<Venda_Ativos, VendaAtivosEstoqueDTO>();
            AutoMapper.Mapper.CreateMap<Venda_Ativos, CompraAtivosEstoqueDTO>();
            AutoMapper.Mapper.CreateMap<Categoria, CategoriaDTO>();
            AutoMapper.Mapper.CreateMap<Empresa, EmpresaDTO>();
        }
    }
}
