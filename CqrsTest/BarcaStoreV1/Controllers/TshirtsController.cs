using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarcaStore.Commands;
using BarcaStoreV1.Queries;
using BarcaStoreV1;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using BarcaStoreV1.Commands;
namespace BarcaStore.Controllers
{
    [ApiController]
    [Route("api/tshirts")]
    public class TshirtsController : ControllerBase
    {
        private readonly ISender _sender;
        public TshirtsController(ISender sender) => _sender = sender;

        [HttpGet]
        public async Task<ActionResult> GetTshirts()
        {
            var tshirts = await _sender.Send(new GetAllTshirtsQuery());
            return Ok (tshirts);
        }
        [HttpGet ("{id}", Name = "GetTshirstById")]
        public async Task<ActionResult> GeTshirtsByIdQuery(int id)
        {
            var tshirts = await _sender.Send(new GetTshirtsByIdQuery(id));
            return Ok(tshirts);
        }

        [HttpPost]
        public async Task<ActionResult> AddTshirt(int id, [FromBody]Tshirt tshirt)
        {
            await _sender.Send(new AddTshirtCommand(tshirt));
            return StatusCode(201);
        }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id )
    {
        var tshirts = await _sender.Send(new DeleteTshirtCommand(id));
        return NoContent();
    }
    }
}