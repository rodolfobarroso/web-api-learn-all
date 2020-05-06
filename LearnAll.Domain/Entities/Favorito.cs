using LearnAll.Domain.Entities.Base;

namespace LearnAll.Domain.Entities
{
    public class Favorito : EntityBase
    {
        public Video Video { get; set; }
        public Usuario Usuario { get; set; }
    }
}
