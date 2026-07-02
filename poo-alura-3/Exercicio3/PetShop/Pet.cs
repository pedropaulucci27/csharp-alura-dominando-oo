public class Pet
{
    public Pet(string nome, string especie, int idade, Dono dono)
    {
        this.Nome = nome;
        this.Especie = especie;
        this.Idade = idade;
        this.Dono = dono;
    }

    public string Nome { get; set; }
    public string Especie { get; set; }
    public int Idade { get; set; }
    public Dono Dono { get; set; } // corrigido: PascalCase
}
