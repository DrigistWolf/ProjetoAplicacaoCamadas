using Persistencia.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia.ServicoPercistencia
{
    public class FuncionarioRepository
    {
        List<Funcionario> lstFuncionarios;


        public FuncionarioRepository()
        {
            lstFuncionarios = new List<Funcionario>();
        }

        public void AddFuncionario(Funcionario funcionario)
        {
            bool Teste = addFuncionario(funcionario);
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



        public bool addFuncionario(Funcionario funcionario)
        {
            Funcionario func = (from c in lstFuncionarios where c.Nome == funcionario.Nome select c).FirstOrDefault();
            if (func == null)
            {
                return false;
            }

            return true;


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


