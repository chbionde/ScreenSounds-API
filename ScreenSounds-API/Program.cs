using System.Text.Json;
using ScreenSounds_API.Filtros;
using ScreenSounds_API.Modelos;

using (HttpClient client = new())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistas(musicas);
        //LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Nome Artista");

        var musicasFavoritas = new MusicasPreferidas("Carlos");
        musicasFavoritas.AddMusicasFavoritas(musicas[1]);
        musicasFavoritas.AddMusicasFavoritas(musicas[3]);
        musicasFavoritas.AddMusicasFavoritas(musicas[6]);
        musicasFavoritas.AddMusicasFavoritas(musicas[120]);
        musicasFavoritas.AddMusicasFavoritas(musicas[540]);

        musicasFavoritas.ExibirMusicasFavoritas();
        musicasFavoritas.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}