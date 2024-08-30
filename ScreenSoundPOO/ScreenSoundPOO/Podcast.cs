using System.Xml;

class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    public string Nome { get; }
    public string Host { get; }
    public int TotalDeEpisodios => episodios.Count();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public void AdicionarEpisodios(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do podcast: {Nome}, " + $"Host: {Host}");
        Console.WriteLine($"Episódios: ");

        foreach (var episodio in episodios.OrderBy(e => e.Numero))
        {
            Console.WriteLine($"{episodio.Numero} - {episodio.Titulo}");
        }

        Console.WriteLine($"\nTotal de episódios = {TotalDeEpisodios}");
    }

    
}