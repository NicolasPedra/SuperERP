using System;
namespace SuperERP.Vendas.DTO
{
    public class OrdemServicoDTO
    {

        public String numero_Os { get; set; }
        public DateTime data_Inicio { get; set; }
        public DateTime data_Entrega { get; set; }
        public String equipamento_Recebido { get; set; }
        public String numeroSerie { get; set; }
        public String marca { get; set; }
        public String modelo { get; set; }
        public String obs_Recebimento { get; set; }
        public String obs_Problema { get; set; }
        public String descr_Servico { get; set; }
        public String obs_Interno { get; set; }
        public String servicoNome { get; set; }
        public String status_ServicoNome { get; set; }

    }
        
}
