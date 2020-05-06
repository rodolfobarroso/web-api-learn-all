using LearnAll.Domain.Entities.Base;

namespace LearnAll.Domain.Entities
{
    public class Canal : EntityBase
    {
        public string Nome { get; set; }
        public string UrlLogo { get; set; }
        public Usuario Usuario { get; set; }
    }
}
