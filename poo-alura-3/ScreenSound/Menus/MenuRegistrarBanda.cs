using Google.GenAI;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);

        var apiKey = Environment.GetEnvironmentVariable("GEMINI_API_KEY") ?? "";
        var client = new Client(apiKey: apiKey);
        var response = client.Models.GenerateContentAsync(
            model: "gemini-2.5-flash",
            contents: $"Resuma a banda {nomeDaBanda} em 1 parágrafo. Adote um estilo informal."
        ).GetAwaiter().GetResult();
        banda.Resumo = response.Candidates[0].Content.Parts[0].Text;

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
