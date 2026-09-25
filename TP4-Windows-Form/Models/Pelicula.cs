public class Pelicula : ContenidoAudioVisual
{
    public int DuracionMinutos { get; set; }

    public Pelicula(int id, string nombre, string director, int anio, Genero genero, bool destacado, int duracionMinutos)
        : base(id, nombre, director, anio, genero, TipoContenido.Pelicula, destacado)
    {
        DuracionMinutos = duracionMinutos;
    }
}