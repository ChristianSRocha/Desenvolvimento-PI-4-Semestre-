﻿using BookAPI.Entities.Clientes;
using BookAPI.mappings;
using BookAPI.Repositories.Clientes;
using BookAPI.Services.Token;
using BookModels.DTOs.Clientes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteRepository _repository;

		public ClienteController(IClienteRepository repository)
		{
			_repository = repository;
		}

		[HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetAllAsync()
        {
            var clientes = await _repository.GetAllClientAsync();


            try
            {
                if (clientes == null) return BadRequest("Não foram encontrados clientes");

                return Ok(clientes);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
            }
        }

        [HttpPost("login")]
        public async Task<ActionResult<Cliente>> Login([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (string.IsNullOrEmpty(clienteDTO.Email) || string.IsNullOrEmpty(clienteDTO.Senha))
                    return BadRequest("Campos não podem ser nulos");

                var cliente = await _repository.Login(clienteDTO.Email, clienteDTO.Senha);

                if (cliente == null)
                    return BadRequest("Cliente não encontrado");

                return Ok(cliente);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
            }
        }

        [AllowAnonymous]
        [HttpPost("create")]
        public async Task<ActionResult<ClienteDTO>> Create(ClienteDTO clienteDTO)
        {
            try
            {
				var cliente = clienteDTO.ConverterClienteDTOParaCliente();

				if (cliente == null) return BadRequest("Cliente não pode ser nulo");

                await _repository.Create(cliente);

                var token = TokenService.GenerateToken(cliente);

                return Ok(new
                {
                    cliente = new
                    {
                        cliente.Id,
                        cliente.Email,
                        cliente.Nome
                    },
                    token = token
                });
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
            }
        }
    }
}
