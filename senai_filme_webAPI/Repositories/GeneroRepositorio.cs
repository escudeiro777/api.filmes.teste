using senai_filme_webAPI.Domains;
using senai_filme_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filme_webAPI.Repositories
{
    public class GeneroRepositorio : IGeneroRepositorio
    { 
        public void AtualizarIdCorpo(GeneroDomain generoAtualizado)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int idGenero, GeneroDomain generoAtualizado)
        {
            throw new NotImplementedException();
        }

        public GeneroDomain BuscarPorId(int idGenero)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(GeneroDomain novoGenero)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idGenero)
        {
            throw new NotImplementedException();
        }

        public List<GeneroDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
