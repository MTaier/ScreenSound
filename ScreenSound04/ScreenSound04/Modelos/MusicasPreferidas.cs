using System.Text.Json;

namespace ScreenSound04.Modelos;

internal class MusicasPreferidas
{
    public string Nome { get; }
    public List<Musica> listaDeMusicasFavoritas;

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        listaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        listaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são suas músicas favoritas, {Nome}");
        foreach (var musica in listaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = listaDeMusicasFavoritas
        });

        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso!\n" +
            $"{Path.GetFullPath(nomeDoArquivo)}");
    }
}
