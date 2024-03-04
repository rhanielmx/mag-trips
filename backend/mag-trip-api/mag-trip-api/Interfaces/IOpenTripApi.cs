using mag_trip_api.DTOs;
using mag_trip_api.Models;

namespace mag_trip_api.Interfaces
{
 interface IOpenTripApi
 {
    Task<ResponseGenerico<LocalModel>> GetLocalByName(string name);
 }
}
