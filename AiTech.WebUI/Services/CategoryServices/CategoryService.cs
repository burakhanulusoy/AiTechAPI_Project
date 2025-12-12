using AiTech.WebUI.DTOs.CategoryDto;
using Newtonsoft.Json;
using System.Text;

namespace AiTech.WebUI.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _client;

        public CategoryService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7203/api/");


            _client = client;
        }

        public async Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            var json = JsonConvert.SerializeObject(createCategoryDto);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            await _client.PostAsync("Categories", content);



        }

        public async Task DeleteCategoryAsync(int id)
        {
            await _client.DeleteAsync("Categories/" + id);

        }

        public async Task<List<ResultCategoryDto>> GetAllCategoriesAsync()
        {
            var response =await _client.GetAsync("Categories");
            if(!response.IsSuccessStatusCode)
            {
                throw new Exception("Kategori Listesi Getirilemedi");
            }
            var jsonContent = await response.Content.ReadAsStringAsync();

            var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonContent);

            return values;
        }

        public async Task<UpdateCategoryDto> GetCategoryByIdAsync(int id)
        {
            var response = await _client.GetAsync("categories/" + id);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Kategori Getirilemedi");
            }
            var jsonContent = await response.Content.ReadAsStringAsync();
            var value=JsonConvert.DeserializeObject<UpdateCategoryDto>(jsonContent);
            return value;




        }

        public async Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {

            var json = JsonConvert.SerializeObject(updateCategoryDto);
            var content=new StringContent(json, Encoding.UTF8, "application/json");

            await _client.PutAsync("Categories", content);



        }
    }
}
