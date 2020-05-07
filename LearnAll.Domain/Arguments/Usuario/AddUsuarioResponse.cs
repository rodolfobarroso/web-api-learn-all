using System;

namespace LearnAll.Domain.Arguments.Usuario
{
    public class AddUsuarioResponse
    {
        public AddUsuarioResponse(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}
