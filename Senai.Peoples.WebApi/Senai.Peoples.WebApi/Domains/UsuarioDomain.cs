using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Peoples.WebApi.Domains
{
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }
        public int IdTipoUsuario { get; set; }
        public TipoUsuarioDomain TipoUsuario { get; set; }
        public int IdFuncionario { get; set; }
        public FuncionarioDomain Funcionario { get; set; }
        public string Email { get; set; }
        protected string Senha { get; set; }
    }
}
