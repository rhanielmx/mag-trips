using System.Net;
using mag_trip_api.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace mag_trip_api.Controllers
{
    [EnableCors("DevPolicy")]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LocalController : ControllerBase
    {
       public readonly ILocalService _localService;

        public LocalController(ILocalService localService)
        {
            _localService = localService;
        }

        [HttpGet("search/{name}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetLocal([FromRoute] string name){
            var response = await _localService.GetLocal(name);
            if(response.CodigoHttp == HttpStatusCode.OK) {
                return Ok(response.DadosRetorno);
            } else {
                return StatusCode((int) response.CodigoHttp, response.ErroRetorno);
            }
         }
    }
}
