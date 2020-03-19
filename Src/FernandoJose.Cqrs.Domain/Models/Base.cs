namespace FernandoJose.Cqrs.Domain.Models
{
    public abstract class Base
    {
        public int Id { get; private set; }

        protected void PreencherId(int id)
        {
            Id = id;
        }
    }
}
