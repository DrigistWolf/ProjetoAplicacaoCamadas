using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Entity

{
    public class Produtos
    {
        public Produtos()
        {
            NomeProduto = null;
            ValorProduto = null;
            QuantidadeProduto = null;
        }
        public string NomeProduto { get; set; }
        public string ValorProduto { get; set; }
        public string QuantidadeProduto { get; set; }
    }
}