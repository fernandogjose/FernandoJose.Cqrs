﻿using FernandoJose.Cqrs.Domain.Interfaces.Repositories;
using FernandoJose.Cqrs.Domain.Models;
using System;
using System.Collections.Generic;

namespace FernandoJose.Cqrs.Infra.Data.Dapper.Repositories
{
    public class AnuncioRepository : IAnuncioRepository
    {
        public int Adicionar(Anuncio request)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int request)
        {
            throw new NotImplementedException();
        }

        public void Editar(Anuncio request)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Anuncio> Listar(Anuncio request)
        {
            throw new NotImplementedException();
        }

        public Anuncio Obter(Anuncio request)
        {
            throw new NotImplementedException();
        }
    }
}
