using Data.Entities;
using System.Text.Json;

namespace ManageDistribution
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<User>> GetUsersAsync(string url)
        {
            try
            {
                var response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    var users = JsonSerializer.Deserialize<List<User>>(data, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return users;
                }
                else
                {
                    return new List<User>();
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new Exception($"Error al obtener usuarios: {ex.Message}");
            }
        }

    }
}
