public class Consulta
{
    public Consulta(Pet animal, Medico medico, DateTime dataConsulta)
    {
        Animal = animal;
        Medico = medico;
        DataConsulta = dataConsulta;
    }

    public Pet Animal { get; set; }       // corrigido: public
    public Medico Medico { get; set; }    // corrigido: public
    public DateTime DataConsulta { get; set; }
}
