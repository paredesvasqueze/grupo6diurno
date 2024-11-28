using FrontEnd.Models;

namespace FrontEnd.Servicio
{
    public class PrestamoService //: IPrestamoService
    {

        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        string _baseURL = string.Empty;

        public PrestamoService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _baseURL = _configuration["UrlBaseAPIs"];
            _httpClient.BaseAddress = new Uri(_baseURL);
        }

        public async Task<IEnumerable<Prestamo>> GetPrestamosAsync(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.GetAsync("Prestamo/ObtenerPrestamoTodos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<Prestamo>>();
        }

        public async Task<bool> CreatePrestamoAsync(Prestamo Prestamo, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PostAsJsonAsync("Prestamo/InsertarPrestamo", Prestamo);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdatePrestamoAsync(Prestamo Prestamo, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PutAsJsonAsync($"Prestamo/ActualizarPrestamo", Prestamo);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeletePrestamoAsync(int id, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.DeleteAsync($"Prestamo/EliminarPrestamo/{id}");
            return response.IsSuccessStatusCode;
        }


    }
}

