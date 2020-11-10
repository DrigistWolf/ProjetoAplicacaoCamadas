using Persistencia.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia.Servicos
{
    public class FuncionarioRepository
    {
        List<Funcionario> lstFuncionarios;


        public FuncionarioRepository()
        {
            lstFuncionarios = new List<Funcionario>();
        }


        private void ApagaFuncionario(string nome)
        {
            foreach (Funcionario func in lstFuncionarios)
            {
                if (nome == func.Nome)
                {
                    lstFuncionarios.Remove(func);
                    break;
                }

            }
        }

     
        public List<Funcionario> BuscarFuncionario()
        {
            return lstFuncionarios;
        }

        public void addFuncionario(Funcionario funcionario)
        {
            lstFuncionarios.Add(funcionario);
        }

      

        public List<Funcionario> Search(string nome = null)
        {
            if (!String.IsNullOrEmpty(nome))
            {
                return lstFuncionarios.Where(l => l.Nome.Contains(nome)).ToList();
            }
            else
            {
                return lstFuncionarios;
            }
        }

    }
}
//implementar a procura de um funcionario


