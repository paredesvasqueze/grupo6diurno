using FrontEnd.Models;

namespace FrontEnd.Servicio
{
    public class UsuarioService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly string _baseURL;

        public UsuarioService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _baseURL = _configuration["UrlBaseAPIs"];
            _httpClient.BaseAddress = new Uri(_baseURL);
        }

        // Obtener todos los usuarios
        public async Task<IEnumerable<Usuario>> GetUsuariosAsync(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.GetAsync("Usuario/ObtenerUsuarioTodos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<Usuario>>();
        }

        // Crear un nuevo usuario
        public async Task<bool> CreateUsuarioAsync(Usuario usuario, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PostAsJsonAsync("Usuario/InsertarUsuario", usuario);
            return response.IsSuccessStatusCode;
        }

        // Actualizar un usuario existente
        public async Task<bool> UpdateUsuarioAsync(Usuario usuario, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PutAsJsonAsync("Usuario/ActualizarUsuario", usuario);
            return response.IsSuccessStatusCode;
        }

        // Eliminar un usuario
        public async Task<bool> DeleteUsuarioAsync(int id, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.DeleteAsync($"Usuario/EliminarUsuario/{id}");
            return response.IsSuccessStatusCode;
        }

        internal async Task<dynamic> GetUsuariosAsync()
        {
            throw new NotImplementedException();
        }
    }
}


