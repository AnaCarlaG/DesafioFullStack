using Domain.Model;
using Domain.Services.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DesafioFullStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaService _empresaService;

        public EmpresaController(IEmpresaService empresaService)
        {
            _empresaService = empresaService;
        }
        // GET: api/<EmpresaController>
        [HttpGet]
        public IEnumerable<EmpresaViewModel> Get()
        {
            return _empresaService.GetAll();
        }

        // GET api/<EmpresaController>/5
        [HttpGet("{id}")]
        public EmpresaViewModel Get(long id)
        {
            return _empresaService.GetId(id);
        }

        // POST api/<EmpresaController>
        [HttpPost]
        public IActionResult Post([FromBody] EmpresaViewModel value)
        {
            try
            {
                _empresaService.Add(value);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<EmpresaController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] EmpresaViewModel value)
        {
            try
            {
                _empresaService.Update(value);
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
            _empresaService.Delete(value);
        }
    }
}
