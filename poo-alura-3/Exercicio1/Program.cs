using Alura.Filmes;
List<Filme> filmes = new();
Filme f1 = new Filme("StarWars 1", 2);
filmes.Add(f1);
Filme f2 = new Filme("StarWars 2", 2);
filmes.Add(f2);
Filme f3 = new Filme("StarWars 3", 2);
filmes.Add(f3);
Filme f4 = new Filme("StarWars 4", 2);
filmes.Add(f4);
Filme f5 = new Filme("StarWars 5", 2);
filmes.Add(f5);

Artista a1 = new Artista("Pedro", 20);
Artista a2 = new Artista("João", 25);
Artista a3 = new Artista("Leonardo", 22);
Artista a4 = new Artista("Gabriel", 21);
Artista a5 = new Artista("Maria", 18);

a1.AdicionarFilme(f1);
f2.AdicionarElenco(a1);
f3.AdicionarElenco(a4);

foreach (Filme filme in filmes)
{
    Console.WriteLine($"Filme: {filme.Titulo}");
    filme.ExibirElenco();
}
