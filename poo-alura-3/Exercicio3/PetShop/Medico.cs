public class Medico
{
    public Medico(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
        Consultas = new List<Consulta>();
    }

    public string Nome { get; set; }
    public string Especialidade { get; set; }
    public List<Consulta> Consultas { get; set; }
}
