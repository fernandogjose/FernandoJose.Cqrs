using FernandoJose.Cqrs.Domain.Models;
using System.Collections.Generic;

namespace FernandoJose.Cqrs.Domain.Interfaces.Repositories
{
    public interface IAnuncioRepository
    {
        int Adicionar(Anuncio request);

        void Editar(Anuncio request);

        void Deletar(int request);

        Anuncio Obter(Anuncio request);

        IEnumerable<Anuncio> Listar(Anuncio request);
    }
}
