using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibeyTechnicalTestAPI.Controllers.Location
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : Controller
    {
        private readonly IRegionAggregate _regionAggregate;
        private readonly IProvinceAggregate _provinceAggregate;
        private readonly IUbigeoAggregate _ubigeoAggregate;
        public LocationController(IRegionAggregate regionAggregate, IProvinceAggregate provinceAggregate, IUbigeoAggregate ubigeoAggregate) 
        {
            _regionAggregate = regionAggregate;
            _provinceAggregate = provinceAggregate;
            _ubigeoAggregate = ubigeoAggregate;
        }
        
        [HttpGet]
        [Route("Region/GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                var list = _regionAggregate.GetAll();
                return Ok(list);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("Province/List")]
        public IActionResult List(string region)
        {
            try
            {
                var list = _provinceAggregate.List(region);
                return Ok(list);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("Ubigeo/List")]
        public IActionResult List(string region, string province)
        {
            try
            {
                var list = _ubigeoAggregate.List(region, province);
                return Ok(list);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpGet]
        [Route("Ubigeo/ListForUser")]
        public IActionResult ListForUser(string ubigeo)
        {
            try
            {
                var list = _ubigeoAggregate.ListForUser(ubigeo);
                return Ok(list);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
