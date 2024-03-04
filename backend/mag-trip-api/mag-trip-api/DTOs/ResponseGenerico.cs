using System.Dynamic;
using System.Net;

namespace mag_trip_api.DTOs
{
  public class ResponseGenerico<T> where T : class
  {
    public HttpStatusCode CodigoHttp  { get; set; }
    public T? DadosRetorno  { get; set; }
    public ExpandoObject? ErroRetorno { get; set; }
  }
}
