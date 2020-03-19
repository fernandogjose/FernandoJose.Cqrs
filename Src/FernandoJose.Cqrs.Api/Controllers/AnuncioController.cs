﻿using FernandoJose.Cqrs.Domain.Commands;
using FernandoJose.Cqrs.Domain.Handles;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FernandoJose.Cqrs.Api.Controllers
{
    [Route("api/anuncio")]
    [ApiController]
    public class AnuncioController : ControllerBase
    {
        [HttpPost("adicionar")]
        [ProducesResponseType(typeof(ResponseCommand), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Adicionar([FromBody]AnuncioAdicionarCommand requestCommand, [FromServices]AnuncioHandler handler)
        {
            ResponseCommand responseCommand = handler.Handle(requestCommand);
            if (responseCommand.Sucesso)
            {
                return Ok(responseCommand);
            }

            return BadRequest(responseCommand);
        }
    }
}