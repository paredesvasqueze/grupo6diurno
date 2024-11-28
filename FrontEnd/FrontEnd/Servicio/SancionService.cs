using FrontEnd.Models;

namespace FrontEnd.Servicio
{
    public class SancionService //: ISancionService
    {

        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        string _baseURL = string.Empty;

        public SancionService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _baseURL = _configuration["UrlBaseAPIs"];
            _httpClient.BaseAddress = new Uri(_baseURL);
        }

        public async Task<IEnumerable<Sancion>> GetSancionsAsync(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.GetAsync("Sancion/ObtenerSancionTodos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<Sancion>>();
        }

        public async Task<bool> CreateSancionAsync(Sancion Sancion, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PostAsJsonAsync("Sancion/InsertarSancion", Sancion);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateSancionAsync(Sancion Sancion, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PutAsJsonAsync($"Sancion/ActualizarSancion", Sancion);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteSancionAsync(int id, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.DeleteAsync($"Sancion/EliminarSancion/{id}");
            return response.IsSuccessStatusCode;
        }


    }
}

