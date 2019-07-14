using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroVenda>  Vendas { get; set; } = new List<RegistroVenda>();

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime nascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Nascimento = nascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionaVendas(RegistroVenda rv)
        {
            Vendas.Add(rv);
        }
        public void RemoveVendas(RegistroVenda rv)
        {
            Vendas.Remove(rv);
        }
        public double TotalVendas(DateTime initial, DateTime final)
        {
            return Vendas.Where(rv => rv.Data >= initial && rv.Data <= final).Sum( rv => rv.Montante);
        }
    }
}
