using LearnAll.Domain.Arguments.Usuario;

namespace LearnAll.Domain.Interfaces.Services
{
    public interface IServiceUsuario
    {
        AddUsuarioResponse AddUsuario(AddUsuarioRequest request);
        AuthenticateUsuarioResponse AuthenticateUsuario(AuthenticateUsuarioResquest resquest);
    }
}
