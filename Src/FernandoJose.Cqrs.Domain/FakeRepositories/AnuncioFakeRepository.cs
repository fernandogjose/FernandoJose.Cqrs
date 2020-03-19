using FernandoJose.Cqrs.Domain.Interfaces.Repositories;
using FernandoJose.Cqrs.Domain.Models;
using System.Collections.Generic;

namespace FernandoJose.Cqrs.Domain.FakeRepositories
{
    public class AnuncioFakeRepository : IAnuncioRepository
    {
        public int Adicionar(Anuncio request)
        {
            return 1;
        }

        public void Deletar(int request)
        {
        }

        public void Editar(Anuncio request)
        {
        }

        public IEnumerable<Anuncio> Listar(Anuncio request)
        {
            return new List<Anuncio>();
        }

        public Anuncio Obter(Anuncio request)
        {
            return new Anuncio();
        }
    }
}
