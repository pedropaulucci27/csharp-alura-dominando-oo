namespace Alura.Filmes;
class Filme
{
    public Filme(string titulo, int duracao)
    {
        this.Titulo = titulo;
        this.Duracao = duracao;
        Artistas = new List<Artista>();
    }

    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public List<Artista> Artistas { get; set; }

    public void AdicionarElenco(Artista artista)
    {
        Artistas.Add(artista);
        if (!artista.Filmes.Contains(this))
        {
            artista.Filmes.Add(this);
        }
    }

    public void ExibirElenco()
    {
        if (Artistas.Count == 0)
        {
            Console.WriteLine("Filme não possui elenco!");
        }
        else
        {
            Console.WriteLine("Elenco: ");
            foreach (Artista artista in Artistas)
            {
                Console.WriteLine(artista.Nome);
            }
        }
    }
}
