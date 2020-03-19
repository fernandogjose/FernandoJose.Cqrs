using FernandoJose.Cqrs.Domain.Interfaces.Commands;
using System.Collections.Generic;

namespace FernandoJose.Cqrs.Domain.Commands
{
    public class AnuncioDeletarCommand : IRequestCommand
    {
        public int Id { get; set; }

        public List<string> Erros { get; set; }

        public void Validar()
        {
            if (Id == 0)
            {
                Erros.Add("Id é obrigatório");
            }
        }
    }
}
