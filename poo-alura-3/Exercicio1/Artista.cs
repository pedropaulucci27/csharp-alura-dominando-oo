namespace Alura.Filmes;

class Artista
{
    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        Filmes = new List<Filme>();
    }

    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Filme> Filmes { get; set; }

    public void AdicionarFilme(Filme filme)
    {
        Filmes.Add(filme);
        if (!filme.Artistas.Contains(this))
        {
            filme.AdicionarElenco(this);
        }
    }

    public void MostrarFilmes()
    {
        if (Filmes.Count == 0)
        {
            Console.WriteLine($"Artista {Nome} não possui participação em filmes");
            return;
        }
        else
        {
            Console.WriteLine($"Filmes do artista {Nome}: ");
            foreach (Filme filme in Filmes)
            {
                Console.WriteLine(filme.Titulo);
            }
        }
    }
}
