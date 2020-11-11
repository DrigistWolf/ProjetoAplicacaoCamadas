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

        public void ContratarFuncionarios(Funcionario funcionario)
        {
            if (!vereficaFuncionario(funcionario.Nome))
            {
                repository.addFuncionario(funcionario);
            }
            else
            {
                throw new Exception("Produto já cadastrado!");
            }
        }
        public bool vereficaFuncionario(string nome)
        {
            Funcionario func = (from c in lstFuncionario where c.Nome == nome select c).FirstOrDefault();
            if (func == null)
            {
                return false;
            }

            return true;
        }

        //isso vai ser implementado assim que a exclusão e inclusão com a lista de funcionarios for adicionada
        //enviar email para diretoria
    }
}
