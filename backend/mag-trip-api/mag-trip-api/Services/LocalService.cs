using AutoMapper;
using mag_trip_api.Interfaces;

namespace mag_trip_api.DTOs
{
    class LocalService : ILocalService
    {
        private readonly IMapper _mapper;
        private readonly IOpenTripApi _openTripAPI;

        public LocalService(IMapper mapper, IOpenTripApi openTripAPI)
        {
            _mapper = mapper;
            _openTripAPI = openTripAPI;
        }

        public async Task<ResponseGenerico<LocalResponse>> GetLocal(string name)
        {
            var local = await _openTripAPI.GetLocalByName(name);
            return _mapper.Map<ResponseGenerico<LocalResponse>>(local);
        }
    }
}