using Persistencia.Entity;
using Persistencia.ServicoPercistencia;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;

namespace Metodo.Servicos
{
    public class ClienteService
    {
        ClienteRepository clienRep;
        
        public ClienteService() 
        {
            clienRep = new ClienteRepository();

        }

        public void GerarListaCLientes() 
        {
            clienRep.Geralista();
        }

        public void ExcluirCliente(string nomeCliente)
        {
            clienRep.RemoveCli(nomeCliente);
        }

        public bool AdiconaCliente(string nomeCliente,long telegoneCLiente,DateTime diaNascimento, DateTime datUltimaCompra) 
        {
            try
            {
                clienRep.AddCliente(nomeCliente, telegoneCLiente, diaNascimento, datUltimaCompra);
            }
            catch (Exception ex)
            {
                throw new Exception("Cliente já cadastrado!");
            }
            return true;
        }

        public void RemoveCliente(string nome) 
        {
           
        }
    }
}
