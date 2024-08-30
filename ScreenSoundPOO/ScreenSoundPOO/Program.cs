using ScreenSoundPOO;
using System.Xml;

Album albumDoQueen =  new Album("A Night at the Opera");

Banda queen = new Banda("Queen");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false
};

Episodio episodio1 = new Episodio(2, "Técnicas de facilitação", 45);
episodio1.AdicionarConvidado("Maria");
episodio1.AdicionarConvidado("Marcelo");
Console.WriteLine(episodio1.Resumo);

Episodio episodio2 = new Episodio(1, "Técnicas de aprendizado", 45);
episodio1.AdicionarConvidado("Maria");
episodio1.AdicionarConvidado("Marcelo");
Console.WriteLine(episodio1.Resumo);

Podcast podcast = new Podcast("Podcast Alura", "Marcio");
podcast.AdicionarEpisodios(episodio1);
podcast.AdicionarEpisodios(episodio2);

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();

podcast.ExibirDetalhes();