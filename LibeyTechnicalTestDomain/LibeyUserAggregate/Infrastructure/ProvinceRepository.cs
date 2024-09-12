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
    public class ProvinceRepository:IProvinceRepository
    {
        private readonly Context _context;
        public ProvinceRepository(Context context)
        {
            _context = context;
        }

        public List<ProvinceReponses> List(string region)
        {
            var province = _context.Provinces.Where(r => r.RegionCode == region).ToList();
            var responseList = new List<ProvinceReponses>();
            foreach (var p in province)
            {
                var response = new ProvinceReponses()
                {
                    ProvinceCode = p.ProvinceCode,
                    RegionCode = p.RegionCode,
                    ProvinceDescription = p.ProvinceDescription
                };

                responseList.Add(response);
            }
            return responseList;
        }
    }
}
