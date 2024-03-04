using mag_trip_api.DTOs;

namespace mag_trip_api.Interfaces
{
  public interface ILocalService
  {    
    Task<ResponseGenerico<LocalResponse>> GetLocal(string name);
  }
}
