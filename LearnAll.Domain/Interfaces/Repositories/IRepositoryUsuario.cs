using LearnAll.Domain.Entities;
using System;

namespace LearnAll.Domain.Interfaces.Repositories
{
    public interface IRepositoryUsuario
    {
        Usuario GetById(Guid Id);
        Usuario Get(string email, string senha);
        bool Exists(string email);
        void Save(Usuario usuario);


    }
}
