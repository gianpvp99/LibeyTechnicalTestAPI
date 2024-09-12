using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibeyTechnicalTestAPI.Controllers.DocumentType
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentTypeController : Controller
    {
        private readonly IDocumentTypeAggregate _aggregate;

        public DocumentTypeController(IDocumentTypeAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                var list = _aggregate.GetAll();
                return Ok(list);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
