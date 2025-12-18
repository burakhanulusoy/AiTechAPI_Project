
namespace AiTech.WebUI.DTOs.GeminiDtos
{
    public class GeminiRequestDto
    {

        public List<Content> contents { get; set; }
        public GenerationConfig? generationConfig { get; set; }
    
    }


    public class Content
    {
        public string role { get; set; }
        public List<Part> parts { get; set; }

    }

    public class Part
    {
        public string text { get; set; }
    }

    public class GenerationConfig()
    {
        public float? temperature { get; set; }

        public int? maxOutputTokens { get; set; }


    }



}


 

