using System;
using System.Linq;
using System.Collections.Generic;

namespace SalesWebMvc.Models
{
    public class Departamento
    {
        //Clase Basica do departamento.
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {

        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionarVendedores(Vendedor vendedor )
        {
            Vendedores.Add(vendedor);
        }
        public double TotalVendas(DateTime initial, DateTime final)
        {
            return Vendedores.Sum(vendedor => vendedor.TotalVendas(initial, final));
        }
    }
}
