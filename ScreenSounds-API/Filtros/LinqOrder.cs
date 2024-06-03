using ScreenSounds_API.Modelos;

namespace ScreenSounds_API.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistas(List<Musica> musicas)
    {
        var artistasOrdernados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        foreach (var artista in artistasOrdernados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
