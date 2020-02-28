using senai.Peoples.WebApi.Domains;
using senai.Peoples.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Peoples.WebApi.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private string stringConexao = "Data Source=DEV1201\\SQLEXPRESS; initial catalog=T_Peoples; user Id=sa; pwd=sa@132";

        public void AtualizarIdUrl(int id, TipoUsuarioDomain tipoUsuario)
        {
            throw new NotImplementedException();
        }

        public TipoUsuarioDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<TipoUsuarioDomain> Listar()
        {
            List<TipoUsuarioDomain> tipoUsuarios = new List<TipoUsuarioDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string QuerySelectAll = "SELECT IdTipoUsuario, Titulo FROM TipoUsuario";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand (QuerySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        TipoUsuarioDomain tipoUsuario = new TipoUsuarioDomain
                        {
                            IdTipoUsuario = Convert.ToInt32(rdr[0]),

                            Titulo = rdr["Titulo"].ToString()
                        };
                        tipoUsuarios.Add(tipoUsuario);
                    }
                }
            }
            return tipoUsuarios;
        }
    }
}
