using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Models
{
    public class RegistroVenda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Montante { get; set; }
        public SituacaoVenda Situacao { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVenda()
        {

        }

        public RegistroVenda(int id, DateTime data, double montante, SituacaoVenda situacao, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Montante = montante;
            Situacao = situacao;
            Vendedor = vendedor;
        }
    }
}
