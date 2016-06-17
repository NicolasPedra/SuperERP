using SuperERP.Compras.DTO;
using SuperERP.Vendas.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SuperERP.Models;

namespace SuperERP.Compras.Service
{
    public class ProdutoService
    {
        public static void Cadastrar(ProdutoDTO produto)
        {
            ServicoGenerico<Produto, ProdutoDTO>.Cadastrar(produto);
        }
        public static void Alterar(ProdutoDTO produto)
        {
            ServicoGenerico<Produto, ProdutoDTO>.Alterar(produto);
        }
        public static ICollection<ProdutoDTO> Listar()
        {
            return ServicoGenerico<Produto, ProdutoDTO>.Listar();
        }
        public static void Deletar(int IDProduto)
        {
            ServicoGenerico<Produto, ProdutoDTO>.Deletar(IDProduto);
        }

        public static ProdutoDTO BuscaPorId(int IdProduto)
        {
            return ServicoGenerico<Produto, ProdutoDTO>.BuscaPorId(IdProduto);
        }
    }
}
