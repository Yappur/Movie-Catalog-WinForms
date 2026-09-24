public enum Genero
{
    Accion,
    Drama,
    Comedia,
    Terror,
    Romance,
    Crimen,
    CienciaFiccion
}

public enum TipoContenido
{
    Pelicula,
    Serie
}

public abstract class ContenidoAudioVisual
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty; // La propiedad se inicilaliza vacia y no da error de nulos
    public string Director { get; set; } = string.Empty;
    public int Anio { get; set; }
    public Genero Genero { get; set; }
    public TipoContenido TipoContenido { get; set; }
    public bool Destacado { get; set; }

    public ContenidoAudioVisual(int id, string nombre, string director, int anio, Genero genero, TipoContenido tipoContenido, bool destacado)
    {
        Id = id;
        Nombre = nombre;
        Director = director;
        Anio = anio;
        Genero = genero;
        TipoContenido = tipoContenido;
        Destacado = destacado;
    }
}
