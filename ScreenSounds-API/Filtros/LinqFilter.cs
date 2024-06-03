using ScreenSounds_API.Modelos;

namespace ScreenSounds_API.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistaPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("Artista por genero: ");
        foreach (var artista in artistaPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();
        Console.WriteLine("Musicas por artista: ");
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
