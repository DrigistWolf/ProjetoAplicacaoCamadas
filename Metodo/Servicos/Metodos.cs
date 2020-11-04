using System;
using Entity;
using ServicoPercistencia;
using System.Collections.Generic;

namespace Servico
{
    public class Metodos
    {
        private PercistenciaServ pers;


        public Metodos()
        {
            pers = new PercistenciaServ();
            gerarLista();
        }


        public void gerarLista()
        {
            pers.Geralista();
        }

        public void Excluiproduto(String nomeProduto) 
        {
            pers.ExcluiProduto(nomeProduto);
        }
        
        public bool AdicionaProduto(string nomeproduto, string valorproduto, string quantidadeproduto)
        {

            if (String.IsNullOrWhiteSpace(valorproduto) || String.IsNullOrWhiteSpace(quantidadeproduto))
            {
                throw new Exception("Precisam ser informados valor e quantidade de produtos!");
            }

            double valor = Double.Parse(valorproduto);
            int quantidade = Int32.Parse(quantidadeproduto);

            if (valor <= 0)
            {
                throw new Exception("Valor Precisa ser maior que zero");
            }
            if (quantidade <= 0)
            {
                throw new Exception("quantidade Precisa ser maior que zero");
            }

            pers.adicionarProduto(nomeproduto,valorproduto,quantidadeproduto);

            return true;
        }

        public List<Produtos> RetornaLista(string nomeProduto = null)
        {
            if (nomeProduto == null)
                return pers.Search();
            else
                return pers.Search(nomeProduto);
        }

       
    }
}
