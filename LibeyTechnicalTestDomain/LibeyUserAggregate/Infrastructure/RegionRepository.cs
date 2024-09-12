using LibeyTechnicalTestDomain.EFCore;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Infrastructure
{
    public class RegionRepository:IRegionRepository
    {
        private readonly Context _context;

        public RegionRepository(Context context)
        {
            _context = context;
        }

        public List<RegionResponses> GetAll()
        {
            var documentsType = _context.Regions.ToList();

            var responseList = new List<RegionResponses>();
            foreach (var r in documentsType)
            {
                var response = new RegionResponses()
                {
                    RegionCode = r.RegionCode,
                    RegionDescription = r.RegionDescription
                };

                responseList.Add(response);
            }
            return responseList;
        }
    }
}
