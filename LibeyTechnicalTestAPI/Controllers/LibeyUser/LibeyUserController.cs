using AutoMapper;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;
using Microsoft.AspNetCore.Mvc;
namespace LibeyTechnicalTestAPI.Controllers.LibeyUser
{
    [ApiController]
    [Route("[controller]")]
    public class LibeyUserController : Controller
    {
        private readonly ILibeyUserAggregate _aggregate;
        public LibeyUserController(ILibeyUserAggregate aggregate)
        {
            _aggregate = aggregate;
        }
        [HttpGet]
        [Route("{documentNumber}")]
        public IActionResult FindResponse(string documentNumber)
        {
            try
            {
                var row = _aggregate.FindResponse(documentNumber);
                return Ok(row);
            }
            catch(Exception ex)
            {
                throw ex;
            }  
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                var response = _aggregate.GetAll();
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create(UserUpdateorCreateCommand command)
        {
            try
            {
                _aggregate.Create(command);
                return Ok(new { success = true, message = "Registro exitoso" });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("Update")]
        public IActionResult Update(UserUpdateorCreateCommand command)
        {
            try
            {
                _aggregate.Update(command);
                return Ok(new { success = true, message = "Actualización exitosa" });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("Delete")]
        public IActionResult Delete(string documentNumber)
        {
            try
            {
                _aggregate.Delete(documentNumber);
                return Ok(new { success = true, message = "Eliminación exitosa" });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}