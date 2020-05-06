using LearnAll.Domain.Entities.Base;
using LearnAll.Domain.ValueObjects;

namespace LearnAll.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; set; }
    }
}
