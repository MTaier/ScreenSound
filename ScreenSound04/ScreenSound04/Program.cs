using ScreenSound04.Filtros;
using ScreenSound04.Modelos;
using System.Text.Json;
using System.Text.Json.Nodes;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        LinqFilter.FiltrarMusicasDeTonalidadeDoSustenido(musicas);

        var minhasMusicasPreferidas = new MusicasPreferidas("Marcio");
        minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[354]);
        minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[500]);
        minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[598]);
        minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[216]);
        minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[143]);

        minhasMusicasPreferidas.ExibirMusicasFavoritas();

        var musicasPreferidasEmily = new MusicasPreferidas("Emily");
        musicasPreferidasEmily.AdicionarMusicasFavoritas(musicas[27]);
        musicasPreferidasEmily.AdicionarMusicasFavoritas(musicas[637]);
        musicasPreferidasEmily.AdicionarMusicasFavoritas(musicas[428]);
        musicasPreferidasEmily.AdicionarMusicasFavoritas(musicas[13]);
        musicasPreferidasEmily.AdicionarMusicasFavoritas(musicas[71]);

        musicasPreferidasEmily.ExibirMusicasFavoritas();

        musicasPreferidasEmily.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}