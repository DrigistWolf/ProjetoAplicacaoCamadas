
using Persistencia.Entity;
using Persistencia.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
    public class FuncionarioService
    {
        FuncionarioRepository repository;
        public FuncionarioService()
        {
            repository = new FuncionarioRepository();
        }

        public void ContratarFuncionarios(Funcionario func)
        {
            //verifica se ta kay
            repository.addFuncionario(func);

            //enviar email para diretoria
        }
    }
}
