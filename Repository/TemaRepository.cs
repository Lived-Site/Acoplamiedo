using Domain.Entities;

namespace Repository;

using Domain.Interfaces; 

public class TemaRepository : ITemaRepository
{
    private readonly List<Tema> _temas;

    public TemaRepository()
    {
        _temas = new List<Tema>();
        CargarDatos();
    }

    public IEnumerable<Tema> ObtenerTodos()
    {
        return _temas;
    }

    public Tema? ObtenerPorId(Guid id)
    {
        return _temas.FirstOrDefault(t => t.Id == id);
    }

    public void AgregarTema(Tema tema)
    {
        _temas.Add(tema);
    }

    private void CargarDatos()
    {
        var srp = new Solid
        {
            Titulo = "Single Responsability Principle (SRP)",
            Descripcion = "Cada componente de software debe tener una sola razón para cambiar",
            Metafora = "Metafora para SRP",
            Principio = "S de SOLID - Responsabilidad Única",
            Causado = "Si una clase maneja la UI y la persistencia juntas, cualquier cambio en la base de datos romperá la UI por efecto dominó."
        };
        
    }
}