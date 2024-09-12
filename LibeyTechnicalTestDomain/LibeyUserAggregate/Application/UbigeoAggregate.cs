using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application
{
    public class UbigeoAggregate : IUbigeoAggregate
    {
        private readonly IUbigeoRepository _repository;
        public UbigeoAggregate(IUbigeoRepository repository)
        {
            _repository = repository;
        }

        public List<UbigeoResponses> List(string region, string province)
        {
            return _repository.List(region, province);
        }

        public List<UbigeoResponses> ListForUser(string ubigeo)
        {
            return _repository.ListForUser(ubigeo);
        }
    }
}
