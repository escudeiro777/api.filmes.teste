using senai_filme_webAPI.Domains;
using System.Collections.Generic;

namespace senai_filme_webAPI.Interfaces
{
    interface IGeneroRepositorio
    {
        List<GeneroDomain> ListarTodos();
        GeneroDomain BuscarPorId(int idGenero);

        void Cadastrar(GeneroDomain novoGenero);

        void AtualizarIdCorpo(GeneroDomain generoAtualizado);

        void AtualizarIdUrl(int idGenero, GeneroDomain generoAtualizado);

        void Deletar(int idGenero);
    }
}
