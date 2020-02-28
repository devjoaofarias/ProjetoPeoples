using senai.Peoples.WebApi.Domains;
using senai.Peoples.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Peoples.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string stringConexao = "Data Source=DEV1201\\SQLEXPRESS; initial catalog=T_Peoples; user Id=sa; pwd=sa@132";

        public void AtualizarIdUrl(int id, UsuarioDomain Usuario)
        {
            throw new NotImplementedException();
        }

        public UsuarioDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioDomain> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
