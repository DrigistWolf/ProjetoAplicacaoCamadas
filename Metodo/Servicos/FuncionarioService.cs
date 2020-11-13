using Persistencia.Entity;
using Persistencia.ServicoPercistencia;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metodo.Servicos
{
    public class FuncionarioService
    {
        List<Funcionario> lstFuncionario;
        FuncionarioRepository repository;

        public FuncionarioService()
        {
            repository = new FuncionarioRepository();
            lstFuncionario = new List<Funcionario>();
        }

        public bool ContratarFuncionarios(Funcionario funcionario)//pode ser void
        {
            try
            {
                repository.AddFuncionario(funcionario);
                // EnviaEmail();//exemplo de chamada
            }
           catch
            {
                throw new Exception("Funcionario já cadastrado!");
            }
            return true;
        }

        public void DemiteFuncionario(String Nome)
        {
            repository.ApagaFuncionario(Nome);
        }

        //public void EnviaEmail() 
        //{
        //    //criar uma classe Email
        //}
    }
}
