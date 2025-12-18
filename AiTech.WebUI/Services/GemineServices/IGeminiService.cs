namespace AiTech.WebUI.Services.GemineServices
{
    public interface IGeminiService
    {

        Task<string> GenerateGeminiAsync(string prompt);

    }
}
