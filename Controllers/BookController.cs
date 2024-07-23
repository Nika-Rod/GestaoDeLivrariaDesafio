using GestãoDeLivrariaDesafio.Communication.Requests;
using GestãoDeLivrariaDesafio.Communication.Response;
using Microsoft.AspNetCore.Mvc;

namespace GestãoDeLivrariaDesafio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(ResponseGetBook), StatusCodes.Status200OK)]
        public IActionResult Get() 
        {
            var response = new ResponseGetBook
            {
                Id = 1,    
                Autor = "Fulano",
                Preco = 10.90,
                Quantidade = 50,
                Title = "Teste",
                Genero = Genero.Romance
            };

            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(typeof (ResponseCreateBook), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] RequestCreateBook request)
        {
            var response = new ResponseCreateBook
            {
                Id = request.Id,
                Title = request.Title,
                Autor = request.Autor,
            };
            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update(RequestUpdate request,int id) 
        { 
            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete() 
        { 
            return NoContent();
        } 

    }
}
