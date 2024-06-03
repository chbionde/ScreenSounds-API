using System.Text.Json.Serialization;

namespace ScreenSounds_API.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Nome:{Nome}");
        Console.WriteLine($"Artista:{Artista}");
        Console.WriteLine($"Duracao:{Duracao/1000}");
        Console.WriteLine($"Genero:{Genero}");
    }
}
