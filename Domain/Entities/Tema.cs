namespace Domain.Entities;

public abstract class Tema
{
    public Guid Id { get; protected set; } = Guid.NewGuid();
    public string Titulo { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public string Metafora { get; set; } = string.Empty;
}