
using System.Dynamic;
using System.Text.Json;
using mag_trip_api.DTOs;
using mag_trip_api.Interfaces;
using mag_trip_api.Models;

namespace mag_trip_api.REST
{
    class OpenTripAPI : IOpenTripApi
    {
        public async Task<ResponseGenerico<LocalModel>> GetLocalByName(string name)
        {
          var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.opentripmap.com/0.1/en/places/geoname?name={name}&apikey=5ae2e3f221c38a28845f05b604f5fbf1a66f1cc9d908fabe4a8265a9");

          var response = new ResponseGenerico<LocalModel>();

          using (var client = new HttpClient()) {
            var responseAPI = await client.SendAsync(request);
            var content = await responseAPI.Content.ReadAsStringAsync();
            var objResponse = JsonSerializer.Deserialize<LocalModel>(content);

            if(responseAPI.IsSuccessStatusCode) {
              response.CodigoHttp = responseAPI.StatusCode;
              response.DadosRetorno = objResponse;
            } else {
              response.CodigoHttp = responseAPI.StatusCode;
              response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(content);
            }
          }
        return response;
        }
    }
}