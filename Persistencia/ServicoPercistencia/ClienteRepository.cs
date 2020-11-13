using Persistencia.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Persistencia.ServicoPercistencia
{
    public class ClienteRepository
    {
        List<Cliente> lstCliente;

        public ClienteRepository()
        {
            Geralista();
        }

        public void Geralista() 
        {
            lstCliente = new List<Cliente>();
        }

        public void AddCliente(string nomeCliente, long telefoneCLiente, DateTime diaNascimento, DateTime datUltimaCompra)
        {
            if (!VereficaCliente(nomeCliente))
            {
                Cliente cliente = new Cliente
                {
                   Nome = nomeCliente,
                   Telefone = telefoneCLiente,
                   DataNascimento = diaNascimento,
                   datUltimaCompra = datUltimaCompra
                }; 
                
                lstCliente.Add(cliente);
            }
            else
            {
                throw new Exception("Funcionario já cadastrado!");
            }
        }

        public bool VereficaCliente(string nomeCliente)
        {
            Cliente cli = (from c in lstCliente where c.Nome == nomeCliente select c).FirstOrDefault();
            if (cli == null)
            {
                return false;
            }
            return true;
        }

        //ExcluiCliente: eu acho que não é necessário?
        public void RemoveCli(string nome)
        {
            foreach (Cliente cli in lstCliente) 
            {
                if (nome == cli.Nome) 
                {
                    lstCliente.Remove(cli);
                    break;
                }
            }
        }

        public List<Cliente> ProcuraCliente(string nome = null) 
        {
            if (!String.IsNullOrEmpty(nome))
            {
                return lstCliente.Where(l => l.Nome.Contains(nome)).ToList();
            }
            else
            {
                return lstCliente;
            }
        }

        //ProcuraCliente
    }
}
