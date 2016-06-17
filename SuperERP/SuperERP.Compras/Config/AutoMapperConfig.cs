using AutoMapper;
using SuperERP.Compras.DTO;
using SuperERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperERP.Compras.Config
{
    public static class AutoMapperConfig
    {
        public static void Inicializar()
        {
            ConverteDTOParaModel();
            ConverteModelParaDTO();
        }

        public static void ConverteDTOParaModel()
        {
            AutoMapper.Mapper.CreateMap<EmpresaDTO, Empresa>();
            AutoMapper.Mapper.CreateMap<PerfilDTO, Perfil>();
            AutoMapper.Mapper.CreateMap<FuncionalidadeDTO, Funcionalidade>();
            AutoMapper.Mapper.CreateMap<ProdutoDTO, Produto>();
            AutoMapper.Mapper.CreateMap<UsuarioDTO, Usuario>();
         
        }

        public static void ConverteModelParaDTO()
        {
            AutoMapper.Mapper.CreateMap<Empresa, EmpresaDTO>();
            AutoMapper.Mapper.CreateMap<Perfil, PerfilDTO >();
            AutoMapper.Mapper.CreateMap<Funcionalidade, FuncionalidadeDTO>();
            AutoMapper.Mapper.CreateMap<Produto, ProdutoDTO>();
            AutoMapper.Mapper.CreateMap<Usuario, UsuarioDTO>();
        }
    }
}
