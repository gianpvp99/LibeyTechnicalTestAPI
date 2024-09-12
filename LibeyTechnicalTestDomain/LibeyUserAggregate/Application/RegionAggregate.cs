using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application
{
    public class RegionAggregate:IRegionAggregate
    {
        private readonly IRegionRepository _regionRepository;
        public RegionAggregate(IRegionRepository regionRepository) 
        {
            _regionRepository = regionRepository;
        }

        public List<RegionResponses> GetAll()
        {
            return _regionRepository.GetAll();
        }
    }
}
