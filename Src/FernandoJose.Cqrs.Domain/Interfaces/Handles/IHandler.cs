using FernandoJose.Cqrs.Domain.Commands;
using FernandoJose.Cqrs.Domain.Interfaces.Commands;

namespace FernandoJose.Cqrs.Domain.Interfaces.Handles
{
    public interface IHandler<T> where T : IRequestCommand
    {
        ResponseCommand Handle(T requestCommand);
    }
}
