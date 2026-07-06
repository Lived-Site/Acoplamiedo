namespace Domain.Interfaces;

using Domain.Entities;

public interface ITemaRepository
{
    IEnumerable<Tema> ObtenerTodos();
    Tema? ObtenerPorId(Guid id);
    void AgregarTema(Tema tema);
}