using LearnAll.Domain.Entities.Base;
using LearnAll.Domain.Enuns;

namespace LearnAll.Domain.Entities
{
    public class PlayList : EntityBase
    {
        public Usuario Usuario { get; set; }
        public EnumStatus Status { get; set; }
    }
}
