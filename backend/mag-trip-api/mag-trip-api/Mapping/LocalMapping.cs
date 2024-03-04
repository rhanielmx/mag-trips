using mag_trip_api.DTOs;
using mag_trip_api.Models;
using AutoMapper;

namespace mag_trip_api.Mapping
{
  class LocalMapping : Profile
  {
    public LocalMapping()
    {
      CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));      
      CreateMap<LocalResponse, LocalModel>();      
      CreateMap<LocalModel, LocalResponse>();      
    }
  }
}