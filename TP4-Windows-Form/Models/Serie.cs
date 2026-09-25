public class Serie : ContenidoAudioVisual
{
    public int Temporadas { get; set; }

    public Serie(int id, string nombre, string director, int anio, Genero genero, bool destacado, int temporadas)
        : base(id, nombre, director, anio, genero, TipoContenido.Serie, destacado)
    {
        Temporadas = temporadas;
    }
}