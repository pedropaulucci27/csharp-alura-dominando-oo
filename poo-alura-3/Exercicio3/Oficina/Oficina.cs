public class Oficina
{
    public Oficina(string nome)
    {
        Mecanicos = new List<Mecanico>();
        Clientes = new List<Cliente>();
        Veiculos = new List<Veiculo>();
        Nome = nome;
    }

    public List<Mecanico> Mecanicos { get; set; }
    public List<Cliente> Clientes { get; set; }
    public List<Veiculo> Veiculos { get; set; }
    public string Nome { get; set; }

    public void AdicionarCliente(Cliente cliente) => Clientes.Add(cliente);
    public void AdicionarMecanico(Mecanico mecanico) => Mecanicos.Add(mecanico);
    public void AdicionarVeiculo(Veiculo veiculo) => Veiculos.Add(veiculo);

    public void AgendarServico(Mecanico mecanico, Veiculo veiculo, Cliente cliente, DateTime dataAgendamento)
    {
        AdicionarVeiculo(veiculo);
        AdicionarMecanico(mecanico);
        AdicionarCliente(cliente);

        Console.WriteLine($"Serviço para o cliente {cliente.Nome} agendado para o dia {dataAgendamento.Day}, {dataAgendamento.DayOfWeek}");
    }

    public void RealizarServico(Veiculo veiculo, Mecanico mecanico, Cliente cliente)
    {
        if (Veiculos.Contains(veiculo))
        {
            Console.WriteLine($"Serviço do veiculo {veiculo.Marca} realizado pelo mecânico {mecanico.Nome}");
            Mecanicos.Remove(mecanico);
            Veiculos.Remove(veiculo);
            Clientes.Remove(cliente);
        }
        else
        {
            Console.WriteLine($"O veículo {veiculo.Marca} não está na oficina");
        }
    }
}
