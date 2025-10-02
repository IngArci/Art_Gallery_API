using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GaleriadeArte   // IMPORTANTE: mismo namespace que tus formularios
{
    public class ApiService
    {
        private readonly RestClient client;

        public ApiService()
        {
            // Configuración con autenticación básica
            var options = new RestClientOptions("http://localhost:8090/pinturas")
            {
                Authenticator = new HttpBasicAuthenticator("admin", "admin") // usuario y contraseña del backend
            };

            client = new RestClient(options);
        }

        // HealthCheck
        public async Task<string> HealthCheckAsync()
        {
            var request = new RestRequest("healthCheck", Method.Get);
            var response = await client.ExecuteAsync(request);

            if (!response.IsSuccessful)
                throw new Exception("Error de conexión: " + response.ErrorMessage);

            return response.Content;
        }

        // Listar solo activas
        public async Task<List<Pintura>> GetPinturasAsync()
        {
            var request = new RestRequest("", Method.Get);
            var response = await client.ExecuteAsync(request);

            if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
                throw new Exception("Error al listar pinturas: " + response.ErrorMessage);

            return JsonConvert.DeserializeObject<List<Pintura>>(response.Content);
        }

        // Listar todas (incluye inactivas)
        public async Task<List<Pintura>> GetTodasPinturasAsync()
        {
            var request = new RestRequest("all", Method.Get);
            var response = await client.ExecuteAsync(request);

            if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
                throw new Exception("Error al listar todas las pinturas: " + response.ErrorMessage);

            return JsonConvert.DeserializeObject<List<Pintura>>(response.Content);
        }

        // Obtener por ID
        public async Task<Pintura> GetPinturaAsync(int id)
        {
            var request = new RestRequest("/{id}", Method.Get);
            request.AddUrlSegment("id", id);
            var response = await client.ExecuteAsync(request);

            if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
                throw new Exception("No se pudo obtener la pintura: " + response.ErrorMessage);

            return JsonConvert.DeserializeObject<Pintura>(response.Content);
        }

        // Crear pintura
        public async Task<Pintura> CrearPinturaAsync(Pintura p)
        {
            var request = new RestRequest("", Method.Post);
            request.AddJsonBody(p);
            var response = await client.ExecuteAsync(request);

            if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
                throw new Exception("Error al crear pintura: " + response.ErrorMessage);

            return JsonConvert.DeserializeObject<Pintura>(response.Content);
        }

        // Actualizar pintura
        public async Task<Pintura> ActualizarPinturaAsync(int id, Pintura cambios)
        {
            var request = new RestRequest("/{id}", Method.Put);
            request.AddUrlSegment("id", id);
            request.AddJsonBody(cambios);
            var response = await client.ExecuteAsync(request);

            if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
                throw new Exception("Error al actualizar pintura: " + response.ErrorMessage);

            return JsonConvert.DeserializeObject<Pintura>(response.Content);
        }

        // Eliminar pintura (soft delete)
        public async Task<bool> EliminarPinturaAsync(int id)
        {
            var request = new RestRequest("/{id}", Method.Delete);
            request.AddUrlSegment("id", id);
            var response = await client.ExecuteAsync(request);

            return response.IsSuccessful;
        }

        // Buscar pinturas con filtros
        public async Task<List<Pintura>> BuscarPinturasAsync(
            string autor = null,
            string estado = null,
            double? minPrecio = null,
            string tecnica = null,
            string textura = null)
        {
            var request = new RestRequest("search", Method.Get);

            if (!string.IsNullOrEmpty(autor))
                request.AddQueryParameter("autor", autor);
            if (!string.IsNullOrEmpty(estado))
                request.AddQueryParameter("estado", estado);
            if (minPrecio.HasValue)
                request.AddQueryParameter("minPrecio", minPrecio.ToString());
            if (!string.IsNullOrEmpty(tecnica))
                request.AddQueryParameter("tecnica", tecnica);
            if (!string.IsNullOrEmpty(textura))
                request.AddQueryParameter("textura", textura);

            var response = await client.ExecuteAsync(request);

            if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
                throw new Exception("Error en la búsqueda: " + response.ErrorMessage);

            return JsonConvert.DeserializeObject<List<Pintura>>(response.Content);
        }
    }
}
