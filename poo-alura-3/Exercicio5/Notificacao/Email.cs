class Email : INotificavel
{
    public void EnviarNotificacao(string mensagem)
    {
        Console.WriteLine($"Enviando e-mail: {mensagem}");
    }
}
