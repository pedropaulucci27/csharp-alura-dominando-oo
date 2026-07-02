class Sms : INotificavel
{
    public void EnviarNotificacao(string mensagem)
    {
        Console.WriteLine($"Enviando SMS: {mensagem}");
    }
}
