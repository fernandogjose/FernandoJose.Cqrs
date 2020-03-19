using FernandoJose.Cqrs.Domain.Commands;
using FernandoJose.Cqrs.Domain.Interfaces.Handles;
using FernandoJose.Cqrs.Domain.Interfaces.Repositories;
using FernandoJose.Cqrs.Domain.Models;
using System.Linq;

namespace FernandoJose.Cqrs.Domain.Handles
{
    public class AnuncioHandler : IHandler<AnuncioAdicionarCommand>, IHandler<AnuncioEditarCommand>, IHandler<AnuncioDeletarCommand>
    {
        private readonly IAnuncioRepository _anuncioRepository;

        public AnuncioHandler(IAnuncioRepository anuncioRepository)
        {
            _anuncioRepository = anuncioRepository;
        }

        public ResponseCommand Handle(AnuncioAdicionarCommand requestCommand)
        {
            // Validar
            requestCommand.Validar();
            if (requestCommand.Erros.Any())
            {
                return new ResponseCommand(false, "Falha ao adicionar o anuncio", requestCommand.Erros);
            }

            // Persistir
            Anuncio requestModel = new Anuncio();
            requestModel.PreencherAdicionar(requestCommand.Marca, requestCommand.Modelo, requestCommand.Versao, requestCommand.Ano, requestCommand.Quilometragem, requestCommand.Observacao);
            int id = _anuncioRepository.Adicionar(requestModel);

            // Notificar
            return new ResponseCommand(true, "Anuncio adicionado com sucesso", id);
        }

        public ResponseCommand Handle(AnuncioEditarCommand requestCommand)
        {
            // Validar
            requestCommand.Validar();
            if (requestCommand.Erros.Any())
            {
                return new ResponseCommand(false, "Falha ao editar o anuncio", requestCommand.Erros);
            }

            // Persistir
            Anuncio requestModel = new Anuncio();
            requestModel.PreencherEditar(requestCommand.Id, requestCommand.Marca, requestCommand.Modelo, requestCommand.Versao, requestCommand.Ano, requestCommand.Quilometragem, requestCommand.Observacao);
            _anuncioRepository.Editar(requestModel);

            // Notificar
            return new ResponseCommand(true, "Anuncio editado com sucesso", requestModel);
        }

        public ResponseCommand Handle(AnuncioDeletarCommand requestCommand)
        {
            // Validar
            requestCommand.Validar();
            if (requestCommand.Erros.Any())
            {
                return new ResponseCommand(false, "Falha ao deletar o anuncio", requestCommand.Erros);
            }

            // Persistir
            _anuncioRepository.Deletar(requestCommand.Id);

            // Notificar
            return new ResponseCommand(true, "Anuncio deletado com sucesso", requestCommand.Id);
        }
    }
}
