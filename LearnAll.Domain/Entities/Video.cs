using LearnAll.Domain.Entities.Base;
using LearnAll.Domain.Enuns;

namespace LearnAll.Domain.Entities
{
    public class Video : EntityBase
    {
        public Canal Canal { get; set; }
        public PlayList PlayList { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Tag { get; set; }
        public int OrdemPlayList { get; set; }
        public string IdVideoYouTube { get; set; }
        public Usuario UsuarioSugeriu { get; set; }
        public EnumStatus Status { get; set; }
    }
}
