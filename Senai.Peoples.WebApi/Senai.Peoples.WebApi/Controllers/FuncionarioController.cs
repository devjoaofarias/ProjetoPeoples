using Microsoft.AspNetCore.Mvc;
using Senai.Peoples.WebApi.Domains;
using Senai.Peoples.WebApi.Interfaces;
using Senai.Peoples.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Controllers
{
    // Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    // Define que a rota de uma requisição será no formato domínio/api/NomeController
    [Route("api/[controller]")]

    // Define que é um controlador de API
    [ApiController]

    public class FuncionarioController : ControllerBase
    {
        private IFuncionarioRepository _funcionarioRepository { get; set; }

        public FuncionarioController()
        {
            _funcionarioRepository = new FuncionarioRepository();
        }

        [HttpGet]
        public IEnumerable<FuncionarioDomain> Get()
        {
            return _funcionarioRepository.Listar();
        }     

        [HttpPost]
        public IActionResult Post (FuncionarioDomain funcionarioDomain)
        {
            _funcionarioRepository.Cadastrar(funcionarioDomain);

            return StatusCode(201);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (int id)
        {
            _funcionarioRepository.Deletar(id);

            return Ok("Funcionario Deletado do Sistema!");
        }

        [HttpGet("{id}")]
        public IActionResult GetById (int id)
        { 
            FuncionarioDomain funcionario = _funcionarioRepository.BuscarPorId(id);
            if (funcionario == null)
            {
                return NotFound("Nenhum funcionario foi encontrado");
            }
                    return Ok(funcionario);
                }
        }
    }

