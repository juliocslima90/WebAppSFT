using System;
using System.Collections.Generic;
using System.Text;

namespace SFT.ApplicationCore.Entity
{
    public class Produto
    {
        public Produto()
        {

        }

        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public int CodBarra { get; set; }
        public decimal Valor { get; set; }
        public decimal Quantidade { get; set; }
    }
}
