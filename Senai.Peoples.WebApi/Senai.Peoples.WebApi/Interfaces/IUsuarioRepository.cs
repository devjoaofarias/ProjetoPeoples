using senai.Peoples.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Peoples.WebApi.Interfaces
{
    interface IUsuarioRepository
    {
        List<UsuarioDomain> Listar();

        UsuarioDomain BuscarPorId(int id);

        void AtualizarIdUrl(int id, UsuarioDomain Usuario);

        void Deletar(int id);
    }
}
