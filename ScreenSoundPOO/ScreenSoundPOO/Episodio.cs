class Episodio
{
    public List<string> convidados = new List<string>();
    public int Numero { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public Podcast Podcast { get; }
    public string Resumo =>
        $"Episódio nmr. {Numero}, {Titulo}.\n" +
        $"Duração: {Duracao}\n" +
        $"Convidado: {string.Join(", ", convidados)}\n";

    public Episodio(int numero, string titulo, int duracao)
    {
        Numero = numero;
        Titulo = titulo;
        Duracao = duracao;
    }

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }

}