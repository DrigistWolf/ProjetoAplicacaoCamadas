using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.Entity
{
    public class Funcionario : Pessoa
    {
        public DateTime DataAdimicao { get; set; }
        public long Registro { get; set; }
    }
}
