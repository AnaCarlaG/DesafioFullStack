using Domain.Model;
using Domain.Services;
using Domain.Services.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DesafioFullStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorController(IFornecedorService fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }
        // GET: api/<EmpresaController>
        [HttpGet]
        public IEnumerable<FornecedorViewModel> Get()
        {
            return _fornecedorService.GetAll();
        }

        // GET api/<EmpresaController>/5
        [HttpGet("{id}")]
        public FornecedorViewModel Get(long id)
        {
            return _fornecedorService.GetId(id);
        }

        // POST api/<EmpresaController>
        [HttpPost]
        public IActionResult Post([FromBody] FornecedorViewModel value)
        {
            try
            {
                _fornecedorService.Add(value);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<EmpresaController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] FornecedorViewModel value)
        {
            try
            {
                _fornecedorService.Update(value);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // DELETE api/<EmpresaController>/5
        [HttpDelete("{id}")]
        public void Delete(long value)
        {
            _fornecedorService.Delete(value);
        }
    }
}
