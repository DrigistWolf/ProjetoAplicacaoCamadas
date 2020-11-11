using Persistencia.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia.ServicoPercistencia
{
    public class PercistenciaServ
    {
        Produtos telefone;
        private List<Produtos> _Lista;


        public PercistenciaServ()
        {
            Geralista();
        }

        public void Geralista()
        {
            _Lista = new List<Produtos>();
        }

        public bool Adiciona(string nomeproduto, string valorproduto, string quantidadeproduto)
        {
            telefone = new Produtos();

            telefone.NomeProduto = nomeproduto;
            telefone.ValorProduto = valorproduto;
            telefone.QuantidadeProduto = quantidadeproduto;

            _Lista.Add(telefone);
            return true;
        }

        public void ExcluiProduto(string nomeProduto)
        {
            foreach (Produtos tel in _Lista)
            {
                if (nomeProduto == tel.NomeProduto)
                {
                    _Lista.Remove(telefone);
                    break;
                }

            }
        }

        public List<Produtos> Search(string nome = null)
        {
            if (!String.IsNullOrEmpty(nome))
            {
                return _Lista.Where(l => l.NomeProduto.Contains(nome)).ToList();
            }
            else
            {
                return _Lista;
            }
        }

        private bool verificarCadastro(string nomeProduto)
        {
            Produtos prod = (from c in _Lista where c.NomeProduto == nomeProduto select c).FirstOrDefault();
            if (prod == null)
            {
                return false;
            }

            return true;
        }


        public void adicionarProduto(string nomeProduto, string valorProduto, string quantidadeProduto)
        {

            if (!verificarCadastro(nomeProduto))
            {
                Adiciona(nomeProduto, valorProduto, quantidadeProduto);
            }
            else
            {
                throw new Exception("Produto já cadastrado!");
            }
        }

    }
}
